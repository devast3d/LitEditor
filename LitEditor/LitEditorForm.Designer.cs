namespace LitEditor
{
    partial class LitEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._import_button = new System.Windows.Forms.Button();
            this._save_button = new System.Windows.Forms.Button();
            this._saveAs_button = new System.Windows.Forms.Button();
            this._filePath_textBox = new System.Windows.Forms.TextBox();
            this._add_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lights_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._disableAll_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _import_button
            // 
            this._import_button.Location = new System.Drawing.Point(12, 12);
            this._import_button.Name = "_import_button";
            this._import_button.Size = new System.Drawing.Size(100, 23);
            this._import_button.TabIndex = 0;
            this._import_button.Text = "Import";
            this._import_button.UseVisualStyleBackColor = true;
            this._import_button.Click += new System.EventHandler(this._import_button_Click);
            // 
            // _save_button
            // 
            this._save_button.Location = new System.Drawing.Point(118, 12);
            this._save_button.Name = "_save_button";
            this._save_button.Size = new System.Drawing.Size(100, 23);
            this._save_button.TabIndex = 1;
            this._save_button.Text = "Save";
            this._save_button.UseVisualStyleBackColor = true;
            this._save_button.Click += new System.EventHandler(this._save_button_Click);
            // 
            // _saveAs_button
            // 
            this._saveAs_button.Location = new System.Drawing.Point(224, 12);
            this._saveAs_button.Name = "_saveAs_button";
            this._saveAs_button.Size = new System.Drawing.Size(100, 23);
            this._saveAs_button.TabIndex = 2;
            this._saveAs_button.Text = "Save As";
            this._saveAs_button.UseVisualStyleBackColor = true;
            this._saveAs_button.Click += new System.EventHandler(this._saveAs_button_Click);
            // 
            // _filePath_textBox
            // 
            this._filePath_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filePath_textBox.Location = new System.Drawing.Point(12, 41);
            this._filePath_textBox.Name = "_filePath_textBox";
            this._filePath_textBox.ReadOnly = true;
            this._filePath_textBox.Size = new System.Drawing.Size(312, 20);
            this._filePath_textBox.TabIndex = 3;
            // 
            // _add_button
            // 
            this._add_button.Location = new System.Drawing.Point(12, 67);
            this._add_button.Name = "_add_button";
            this._add_button.Size = new System.Drawing.Size(100, 23);
            this._add_button.TabIndex = 5;
            this._add_button.Text = "Add New";
            this._add_button.UseVisualStyleBackColor = true;
            this._add_button.Click += new System.EventHandler(this._add_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._lights_flowLayoutPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 500);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lights";
            // 
            // _lights_flowLayoutPanel
            // 
            this._lights_flowLayoutPanel.AutoScroll = true;
            this._lights_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lights_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._lights_flowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this._lights_flowLayoutPanel.Name = "_lights_flowLayoutPanel";
            this._lights_flowLayoutPanel.Size = new System.Drawing.Size(308, 481);
            this._lights_flowLayoutPanel.TabIndex = 0;
            this._lights_flowLayoutPanel.WrapContents = false;
            // 
            // _disableAll_button
            // 
            this._disableAll_button.Location = new System.Drawing.Point(118, 67);
            this._disableAll_button.Name = "_disableAll_button";
            this._disableAll_button.Size = new System.Drawing.Size(100, 23);
            this._disableAll_button.TabIndex = 7;
            this._disableAll_button.Text = "Disable All";
            this._disableAll_button.UseVisualStyleBackColor = true;
            this._disableAll_button.Click += new System.EventHandler(this._disableAll_button_Click);
            // 
            // LitEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 608);
            this.Controls.Add(this._disableAll_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._add_button);
            this.Controls.Add(this._filePath_textBox);
            this.Controls.Add(this._saveAs_button);
            this.Controls.Add(this._save_button);
            this.Controls.Add(this._import_button);
            this.DoubleBuffered = true;
            this.Name = "LitEditorForm";
            this.Text = "LIT Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _import_button;
        private System.Windows.Forms.Button _save_button;
        private System.Windows.Forms.Button _saveAs_button;
        private System.Windows.Forms.TextBox _filePath_textBox;
        private System.Windows.Forms.Button _add_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel _lights_flowLayoutPanel;
        private System.Windows.Forms.Button _disableAll_button;
    }
}

