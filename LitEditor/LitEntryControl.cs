using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitEditor
{
    public partial class LitEntryControl : UserControl
    {
        private Light _light;

        public LitEntryControl()
        {
            InitializeComponent();
        }

        public LitEntryControl(Light light)
        {
            InitializeComponent();
            _light = light;
            _light.Changed += _light_Changed;
            UpdateUI();
        }

        public void OnDestroy()
        {
            _light.Changed -= _light_Changed;
        }

        private void _light_Changed()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            BackColor = _light.Enabled ? Color.LightYellow : SystemColors.ControlLight;
            _enabled_checkBox.Checked = _light.Enabled;
            Float3 position = _light.Position;
            _positionX_textBox.Text = position.X.ToString();
            _positionY_textBox.Text = position.Y.ToString();
            _positionZ_textBox.Text = position.Z.ToString();
            _unknown1_textBox.Text = _light.Unknown1.ToString();
            _unknown2_textBox.Text = _light.Unknown2.ToString();
            Float3 color = _light.Color;
            _colorR_textBox.Text = color.X.ToString();
            _colorG_textBox.Text = color.Y.ToString();
            _colorB_textBox.Text = color.Z.ToString();
        }

        private void _enabled_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _light.Enabled = _enabled_checkBox.Checked;
        }

        private void _remove_button_Click(object sender, EventArgs e)
        {
            _light.RemoveFromProject();
        }

        private void _positionX_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 position = _light.Position;
            float value;
            if (float.TryParse(_positionX_textBox.Text, out value))
            {
                position.X = value;
                _light.Position = position;
            }
        }

        private void _positionY_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 position = _light.Position;
            float value;
            if (float.TryParse(_positionY_textBox.Text, out value))
            {
                position.Y = value;
                _light.Position = position;
            }
        }

        private void _positionZ_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 position = _light.Position;
            float value;
            if (float.TryParse(_positionZ_textBox.Text, out value))
            {
                position.Z = value;
                _light.Position = position;
            }
        }

        private void _unknown1_textBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_unknown1_textBox.Text, out value))
            {
                _light.Unknown1 = value;
            }
        }

        private void _unknown2_textBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_unknown2_textBox.Text, out value))
            {
                _light.Unknown2 = value;
            }
        }

        private void _colorR_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 color = _light.Color;
            float value;
            if (float.TryParse(_colorR_textBox.Text, out value))
            {
                color.X = value;
                _light.Color = color;
            }
        }

        private void _colorG_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 color = _light.Color;
            float value;
            if (float.TryParse(_colorG_textBox.Text, out value))
            {
                color.Y = value;
                _light.Color = color;
            }
        }

        private void _colorB_textBox_TextChanged(object sender, EventArgs e)
        {
            Float3 color = _light.Color;
            float value;
            if (float.TryParse(_colorB_textBox.Text, out value))
            {
                color.Z = value;
                _light.Color = color;
            }
        }

        private void _position_textBox_Validating(object sender, CancelEventArgs e)
        {
            float temp;
            e.Cancel = !float.TryParse((sender as TextBox).Text, out temp);
        }

        private void _unknown_textBox_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            e.Cancel = !int.TryParse((sender as TextBox).Text, out temp);
        }
    }
}
