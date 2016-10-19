using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitEditor
{
    public partial class LitEditorForm : Form
    {
        private LitProject _project;

        public LitEditorForm()
        {
            InitializeComponent();

            _project = new LitProject();
            _project.Changed += _project_Changed;
            _project.Reset();
        }

        private void _project_Changed()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            foreach (LitEntryControl lightControl in _lights_flowLayoutPanel.Controls)
            {
                lightControl.OnDestroy();
            }
            _lights_flowLayoutPanel.Controls.Clear();

            foreach (Light light in _project.Lights)
            {
                LitEntryControl control = new LitEntryControl(light);
                _lights_flowLayoutPanel.Controls.Add(control);
            }

            _filePath_textBox.Text = _project.FilePath;
        }

        private void _add_button_Click(object sender, EventArgs e)
        {
            _project.AddLight();
        }

        private void _disableAll_button_Click(object sender, EventArgs e)
        {
            _project.DisableAllLights();
        }

        private void _import_button_Click(object sender, EventArgs e)
        {
            if (!_project.Import())
            {
                ShowError("Import");
            }
        }

        private void _save_button_Click(object sender, EventArgs e)
        {
            _project.Save(false);
        }

        private void _saveAs_button_Click(object sender, EventArgs e)
        {
            _project.Save(true);
        }

        private void ShowError(string caption)
        {
            MessageBox.Show("Something is wrong!", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
