using System;

namespace LitEditor
{
    public struct Float3
    {
        public float X;
        public float Y;
        public float Z;

        public Float3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override bool Equals(object obj)
        {
            if (obj is Float3)
            {
                Float3 other = (Float3)obj;
                bool result = X == other.X && Y == other.Y && Z == other.Z;
                return result;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public static bool operator ==(Float3 value0, Float3 value1)
        {
            return value0.Equals(value1);
        }

        public static bool operator !=(Float3 value0, Float3 value1)
        {
            return !value0.Equals(value1);
        }

        public static Float3 FromFileFormatPos(int x, int y, int z)
        {
            float m = 1.0f / 1024f;
            Float3 result = new Float3(x * m, y * m, z * m);
            return result;
        }

        public void ToFileFormatPos(out int x, out int y, out int z)
        {
            x = (int)Math.Round(X * 1024, MidpointRounding.AwayFromZero);
            y = (int)Math.Round(Y * 1024, MidpointRounding.AwayFromZero);
            z = (int)Math.Round(Z * 1024, MidpointRounding.AwayFromZero);
        }

        public static Float3 FromFileFormatCol(int x, int y, int z)
        {
            float m = 1.0f / 256f;
            Float3 result = new Float3(x * m, y * m, z * m);
            return result;
        }

        public void ToFileFormatCol(out int x, out int y, out int z)
        {
            x = (int)Math.Round(X * 256, MidpointRounding.AwayFromZero);
            y = (int)Math.Round(Y * 256, MidpointRounding.AwayFromZero);
            z = (int)Math.Round(Z * 256, MidpointRounding.AwayFromZero);
        }
    }
    
    public class Light
    {
        public event Action Changed;
        public event Action<Light> Removing;

        private bool _enabled;
        private Float3 _position;
        private int _unknown1;
        private int _unknown2;
        private Float3 _color;

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (value != _enabled)
                {
                    _enabled = value;
                    FireChangedEvent();
                }
            }
        }

        public Float3 Position
        {
            get { return _position; }
            set
            {
                if (value != _position)
                {
                    _position = value;
                    FireChangedEvent();
                }
            }
        }

        public int Unknown1
        {
            get { return _unknown1; }
            set
            {
                if (value != _unknown1)
                {
                    _unknown1 = value;
                    FireChangedEvent();
                }
            }
        }

        public int Unknown2
        {
            get { return _unknown2; }
            set
            {
                if (value != _unknown2)
                {
                    _unknown2 = value;
                    FireChangedEvent();
                }
            }
        }
        
        public Float3 Color
        {
            get { return _color; }
            set
            {
                if (value != _color)
                {
                    _color = value;
                    FireChangedEvent();
                }
            }
        }
        
        public Light()
        {
            Enabled = true;
            Position = new Float3(0, 1, 0);
            Unknown1 = 0;
            Unknown2 = 0;
            Color = new Float3(1, 1, 1);
        }

        public void RemoveFromProject()
        {
            if (Removing != null) Removing(this);
        }

        private void FireChangedEvent()
        {
            if (Changed != null) Changed();
        }
    }
}
