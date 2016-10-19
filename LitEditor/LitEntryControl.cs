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
			UpdateFlags();
            _unknown_textBox.Text = _light.Unknown.ToString();
            Float3 color = _light.Color;
            _colorR_textBox.Text = color.X.ToString();
            _colorG_textBox.Text = color.Y.ToString();
            _colorB_textBox.Text = color.Z.ToString();
        }

		private void UpdateFlags()
		{
			_light.ChangedEventEnabled = false;
			uint flags = _light.GetFlags();

			System.Text.StringBuilder flagsString = new StringBuilder(Convert.ToString(flags, 2));
			while (flagsString.Length < 6)
			{
				flagsString.Insert(0, '0');
			}
			flagsString.Insert(2, ' ');
			flagsString.Insert(5, ' ');
			_flags_textBox.Text = flagsString.ToString();

			_shadow_checkBox.Checked = _light.IsShadow;
			_light_checkBox.Checked = _light.IsLight;

			_dir_checkBox.Checked = _truePoint_checkBox.Checked = _point_checkBox.Checked = false;			
			if (_light.Type == LightType.Directional)
			{
				_dir_checkBox.Checked = true;
			}
			else if (_light.Type == LightType.TruePoint)
			{
				_truePoint_checkBox.Checked = true;
			}
			else
			{
				_point_checkBox.Checked = true;
			}

			_furn_checkBox.Checked = _light.IsFurn;
			_base_checkBox.Checked = _light.IsBase;

			_light.ChangedEventEnabled = true;
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

        private void _unknown_textBox_TextChanged(object sender, EventArgs e)
        {
            float value;
            if (float.TryParse(_unknown_textBox.Text, out value))
            {
                _light.Unknown = value;
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

        private void FloatValidating(object sender, CancelEventArgs e)
        {
            float temp;
            e.Cancel = !float.TryParse((sender as TextBox).Text, out temp);
        }

		private void SetBehaviour(object sender, LightBehaviour flag)
		{
			CheckBox control = sender as CheckBox;
			if (control.Checked)
			{
				_light.Behaviour |= flag;
			}
			else
			{
				_light.Behaviour &= ~flag;
			}
		}

		private void _shadow_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetBehaviour(sender, LightBehaviour.Shadow);
		}

		private void _light_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetBehaviour(sender, LightBehaviour.Light);
		}

		private void _dir_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_dir_checkBox.Checked)
			{
				_light.Type = LightType.Directional;
			}
			else
			{
				if (_light.Type == LightType.Directional)
				{
					_dir_checkBox.CheckedChanged -= _dir_checkBox_CheckedChanged;
					_dir_checkBox.Checked = true;
					_dir_checkBox.CheckedChanged += _dir_checkBox_CheckedChanged;
				}
			}
		}

		private void _truePoint_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_truePoint_checkBox.Checked)
			{
				_light.Type = LightType.TruePoint;
			}
			else
			{
				if (_light.Type == LightType.TruePoint)
				{
					_truePoint_checkBox.CheckedChanged -= _truePoint_checkBox_CheckedChanged;
					_truePoint_checkBox.Checked = true;
					_truePoint_checkBox.CheckedChanged += _truePoint_checkBox_CheckedChanged;
				}
			}
		}

		private void _point_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_point_checkBox.Checked)
			{
				_light.Type = LightType.Point;
			}
			else
			{
				if (_light.Type == LightType.Point)
				{
					_point_checkBox.CheckedChanged -= _point_checkBox_CheckedChanged;
					_point_checkBox.Checked = true;
					_point_checkBox.CheckedChanged += _point_checkBox_CheckedChanged;
				}
			}
		}

		private void SetDomain(object sender, LightDomain flag)
		{
			CheckBox control = sender as CheckBox;
			if (control.Checked)
			{
				_light.Domain |= flag;
			}
			else
			{
				_light.Domain &= ~flag;
			}
		}

		private void _furn_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetDomain(sender, LightDomain.Furn);
		}

		private void _base_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetDomain(sender, LightDomain.Base);
		}
	}
}
