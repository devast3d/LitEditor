using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace LitEditor
{
    public class LitProject
    {
        public event Action Changed;

        private string _filePath;
        private List<Light> _lights;

        public ReadOnlyCollection<Light> Lights
        {
            get { return _lights.AsReadOnly(); }
        }

        public string FilePath
        {
            get { return _filePath; }
        }

        public LitProject()
        {
            _filePath = string.Empty;
            _lights = new List<Light>();
        }

        public void Reset()
        {
            _lights.Clear();
            //AddLight();
        }

        private void AddLightItem(Light light)
        {
            _lights.Add(light);
            light.Removing += Light_Removing;
        }

        public bool Import()
        {
            string filePath;
            if (!UIMisc.ShowLitFileDialog(out filePath))
            {
                return true;
            }

            if (!File.Exists(filePath))
            {
                return false;
            }

            if (_lights.Count != 0)
            {
                //TODO make warning?
                _lights.Clear();
            }

            try
            {
                using (BinaryReader br = new BinaryReader(File.OpenRead(filePath)))
                {
                    int fileVersion = br.ReadInt32();
                    int lightCount = br.ReadInt32();

                    for (int i = 0; i < lightCount; ++i)
                    {
                        int positionX = br.ReadInt32();
                        int positionY = br.ReadInt32();
                        int positionZ = br.ReadInt32();

                        uint flags = br.ReadUInt32();
                        int unknown = br.ReadInt32();
						
						int colorX = br.ReadInt32();
                        int colorY = br.ReadInt32();
                        int colorZ = br.ReadInt32();

                        Light light = new Light();
                        light.Position = Float3.FromFileFormatPosition(positionX, positionY, positionZ);
                        light.SetFlags(flags);
                        light.Unknown = LightUtil.FromFileFormatPosition(unknown);
                        light.Color = Float3.FromFileFormatColor(colorX, colorY, colorZ);

                        AddLightItem(light);
                    }
                }
            }
            catch
            {
                _lights.Clear();
                return false;
            }

            _filePath = filePath;

            FireChangedEvent();
            return true;
        }

        private void Light_Removing(Light light)
        {
            if (_lights.Contains(light))
            {
                _lights.Remove(light);
                light.Removing -= Light_Removing;

                FireChangedEvent();
            }
        }

        public void AddLight()
        {
            AddLightItem(new Light());
            FireChangedEvent();
        }

        public void DisableAllLights()
        {
            foreach (Light light in _lights)
            {
                light.Enabled = false;
            }
            FireChangedEvent();
        }

        private bool ExportToFile()
        {
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(_filePath, FileMode.Create, FileAccess.Write)))
                {
                    int version = 1;
                    bw.Write(version);

                    int lightCount = 0;
                    foreach (Light light in _lights)
                    {
                        if (light.Enabled)
                        {
                            ++lightCount;
                        }
                    }
                    bw.Write(lightCount);

                    int x, y, z;
                    foreach (Light light in _lights)
                    {
                        if (light.Enabled)
                        {
                            light.Position.ToFileFormatPosition(out x, out y, out z);
                            bw.Write(x);
                            bw.Write(y);
                            bw.Write(z);

							uint flags = light.GetFlags();
                            bw.Write(flags);

							int unknown = LightUtil.ToFileFormatPosition(light.Unknown);
                            bw.Write(unknown);

                            light.Color.ToFileFormatColor(out x, out y, out z);
                            bw.Write(x);
                            bw.Write(y);
                            bw.Write(z);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save(bool saveAs)
        {
            if (string.IsNullOrEmpty(_filePath) || saveAs)
            {
                string filePath;
                if (UIMisc.ShowLitFileDialog(out filePath))
                {
                    _filePath = filePath;
                }
                else
                {
                    return true;
                }
            }

            bool result = ExportToFile();

            return result;
        }

        private void FireChangedEvent()
        {
            if (Changed != null) Changed();
        }
    }
}
