namespace LitEditor
{
    partial class LitEntryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this._position_label = new System.Windows.Forms.Label();
			this._positionX_textBox = new System.Windows.Forms.TextBox();
			this._flags_label = new System.Windows.Forms.Label();
			this._unknown_textBox = new System.Windows.Forms.TextBox();
			this._colorR_textBox = new System.Windows.Forms.TextBox();
			this._color_label = new System.Windows.Forms.Label();
			this._positionY_textBox = new System.Windows.Forms.TextBox();
			this._positionZ_textBox = new System.Windows.Forms.TextBox();
			this._colorG_textBox = new System.Windows.Forms.TextBox();
			this._colorB_textBox = new System.Windows.Forms.TextBox();
			this._enabled_checkBox = new System.Windows.Forms.CheckBox();
			this._enabled_label = new System.Windows.Forms.Label();
			this._remove_button = new System.Windows.Forms.Button();
			this._shadow_checkBox = new System.Windows.Forms.CheckBox();
			this._light_checkBox = new System.Windows.Forms.CheckBox();
			this._dir_checkBox = new System.Windows.Forms.CheckBox();
			this._furn_checkBox = new System.Windows.Forms.CheckBox();
			this._point_checkBox = new System.Windows.Forms.CheckBox();
			this._base_checkBox = new System.Windows.Forms.CheckBox();
			this._flags_textBox = new System.Windows.Forms.TextBox();
			this._unknown_label = new System.Windows.Forms.Label();
			this._truePoint_checkBox = new System.Windows.Forms.CheckBox();
			this._bit12_label = new System.Windows.Forms.Label();
			this._bit34_label = new System.Windows.Forms.Label();
			this._bit56_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _position_label
			// 
			this._position_label.AutoSize = true;
			this._position_label.Location = new System.Drawing.Point(3, 32);
			this._position_label.Name = "_position_label";
			this._position_label.Size = new System.Drawing.Size(44, 13);
			this._position_label.TabIndex = 0;
			this._position_label.Text = "Position";
			// 
			// _positionX_textBox
			// 
			this._positionX_textBox.Location = new System.Drawing.Point(62, 29);
			this._positionX_textBox.Name = "_positionX_textBox";
			this._positionX_textBox.Size = new System.Drawing.Size(65, 20);
			this._positionX_textBox.TabIndex = 1;
			this._positionX_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _flags_label
			// 
			this._flags_label.AutoSize = true;
			this._flags_label.Location = new System.Drawing.Point(3, 58);
			this._flags_label.Name = "_flags_label";
			this._flags_label.Size = new System.Drawing.Size(32, 13);
			this._flags_label.TabIndex = 2;
			this._flags_label.Text = "Flags";
			// 
			// _unknown_textBox
			// 
			this._unknown_textBox.Location = new System.Drawing.Point(62, 159);
			this._unknown_textBox.Name = "_unknown_textBox";
			this._unknown_textBox.Size = new System.Drawing.Size(65, 20);
			this._unknown_textBox.TabIndex = 5;
			this._unknown_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _colorR_textBox
			// 
			this._colorR_textBox.Location = new System.Drawing.Point(62, 185);
			this._colorR_textBox.Name = "_colorR_textBox";
			this._colorR_textBox.Size = new System.Drawing.Size(65, 20);
			this._colorR_textBox.TabIndex = 6;
			this._colorR_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _color_label
			// 
			this._color_label.AutoSize = true;
			this._color_label.Location = new System.Drawing.Point(3, 188);
			this._color_label.Name = "_color_label";
			this._color_label.Size = new System.Drawing.Size(31, 13);
			this._color_label.TabIndex = 7;
			this._color_label.Text = "Color";
			// 
			// _positionY_textBox
			// 
			this._positionY_textBox.Location = new System.Drawing.Point(133, 29);
			this._positionY_textBox.Name = "_positionY_textBox";
			this._positionY_textBox.Size = new System.Drawing.Size(65, 20);
			this._positionY_textBox.TabIndex = 8;
			this._positionY_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _positionZ_textBox
			// 
			this._positionZ_textBox.Location = new System.Drawing.Point(204, 29);
			this._positionZ_textBox.Name = "_positionZ_textBox";
			this._positionZ_textBox.Size = new System.Drawing.Size(65, 20);
			this._positionZ_textBox.TabIndex = 9;
			this._positionZ_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _colorG_textBox
			// 
			this._colorG_textBox.Location = new System.Drawing.Point(133, 185);
			this._colorG_textBox.Name = "_colorG_textBox";
			this._colorG_textBox.Size = new System.Drawing.Size(65, 20);
			this._colorG_textBox.TabIndex = 10;
			this._colorG_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _colorB_textBox
			// 
			this._colorB_textBox.Location = new System.Drawing.Point(204, 185);
			this._colorB_textBox.Name = "_colorB_textBox";
			this._colorB_textBox.Size = new System.Drawing.Size(65, 20);
			this._colorB_textBox.TabIndex = 11;
			this._colorB_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FloatValidating);
			// 
			// _enabled_checkBox
			// 
			this._enabled_checkBox.AutoSize = true;
			this._enabled_checkBox.Location = new System.Drawing.Point(62, 5);
			this._enabled_checkBox.Name = "_enabled_checkBox";
			this._enabled_checkBox.Size = new System.Drawing.Size(15, 14);
			this._enabled_checkBox.TabIndex = 13;
			this._enabled_checkBox.UseVisualStyleBackColor = true;
			// 
			// _enabled_label
			// 
			this._enabled_label.AutoSize = true;
			this._enabled_label.Location = new System.Drawing.Point(3, 6);
			this._enabled_label.Name = "_enabled_label";
			this._enabled_label.Size = new System.Drawing.Size(46, 13);
			this._enabled_label.TabIndex = 14;
			this._enabled_label.Text = "Enabled";
			// 
			// _remove_button
			// 
			this._remove_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._remove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._remove_button.Location = new System.Drawing.Point(249, 2);
			this._remove_button.Name = "_remove_button";
			this._remove_button.Size = new System.Drawing.Size(20, 20);
			this._remove_button.TabIndex = 15;
			this._remove_button.Text = "x";
			this._remove_button.UseVisualStyleBackColor = true;
			// 
			// _shadow_checkBox
			// 
			this._shadow_checkBox.AutoSize = true;
			this._shadow_checkBox.Location = new System.Drawing.Point(62, 83);
			this._shadow_checkBox.Name = "_shadow_checkBox";
			this._shadow_checkBox.Size = new System.Drawing.Size(65, 17);
			this._shadow_checkBox.TabIndex = 16;
			this._shadow_checkBox.Text = "Shadow";
			this._shadow_checkBox.UseVisualStyleBackColor = true;
			this._shadow_checkBox.CheckedChanged += new System.EventHandler(this._shadow_checkBox_CheckedChanged);
			// 
			// _light_checkBox
			// 
			this._light_checkBox.AutoSize = true;
			this._light_checkBox.Location = new System.Drawing.Point(133, 83);
			this._light_checkBox.Name = "_light_checkBox";
			this._light_checkBox.Size = new System.Drawing.Size(49, 17);
			this._light_checkBox.TabIndex = 17;
			this._light_checkBox.Text = "Light";
			this._light_checkBox.UseVisualStyleBackColor = true;
			this._light_checkBox.CheckedChanged += new System.EventHandler(this._light_checkBox_CheckedChanged);
			// 
			// _dir_checkBox
			// 
			this._dir_checkBox.AutoSize = true;
			this._dir_checkBox.Location = new System.Drawing.Point(62, 109);
			this._dir_checkBox.Name = "_dir_checkBox";
			this._dir_checkBox.Size = new System.Drawing.Size(76, 17);
			this._dir_checkBox.TabIndex = 20;
			this._dir_checkBox.Text = "Directional";
			this._dir_checkBox.UseVisualStyleBackColor = true;
			this._dir_checkBox.CheckedChanged += new System.EventHandler(this._dir_checkBox_CheckedChanged);
			// 
			// _furn_checkBox
			// 
			this._furn_checkBox.AutoSize = true;
			this._furn_checkBox.Location = new System.Drawing.Point(62, 135);
			this._furn_checkBox.Name = "_furn_checkBox";
			this._furn_checkBox.Size = new System.Drawing.Size(47, 17);
			this._furn_checkBox.TabIndex = 21;
			this._furn_checkBox.Text = "Furn";
			this._furn_checkBox.UseVisualStyleBackColor = true;
			this._furn_checkBox.CheckedChanged += new System.EventHandler(this._furn_checkBox_CheckedChanged);
			// 
			// _point_checkBox
			// 
			this._point_checkBox.AutoSize = true;
			this._point_checkBox.Location = new System.Drawing.Point(204, 109);
			this._point_checkBox.Name = "_point_checkBox";
			this._point_checkBox.Size = new System.Drawing.Size(50, 17);
			this._point_checkBox.TabIndex = 22;
			this._point_checkBox.Text = "Point";
			this._point_checkBox.UseVisualStyleBackColor = true;
			this._point_checkBox.CheckedChanged += new System.EventHandler(this._point_checkBox_CheckedChanged);
			// 
			// _base_checkBox
			// 
			this._base_checkBox.AutoSize = true;
			this._base_checkBox.Location = new System.Drawing.Point(133, 135);
			this._base_checkBox.Name = "_base_checkBox";
			this._base_checkBox.Size = new System.Drawing.Size(50, 17);
			this._base_checkBox.TabIndex = 24;
			this._base_checkBox.Text = "Base";
			this._base_checkBox.UseVisualStyleBackColor = true;
			this._base_checkBox.CheckedChanged += new System.EventHandler(this._base_checkBox_CheckedChanged);
			// 
			// _flags_textBox
			// 
			this._flags_textBox.Location = new System.Drawing.Point(62, 55);
			this._flags_textBox.Name = "_flags_textBox";
			this._flags_textBox.ReadOnly = true;
			this._flags_textBox.Size = new System.Drawing.Size(65, 20);
			this._flags_textBox.TabIndex = 26;
			// 
			// _unknown_label
			// 
			this._unknown_label.AutoSize = true;
			this._unknown_label.Location = new System.Drawing.Point(3, 162);
			this._unknown_label.Name = "_unknown_label";
			this._unknown_label.Size = new System.Drawing.Size(53, 13);
			this._unknown_label.TabIndex = 27;
			this._unknown_label.Text = "Unknown";
			// 
			// _truePoint_checkBox
			// 
			this._truePoint_checkBox.AutoSize = true;
			this._truePoint_checkBox.Location = new System.Drawing.Point(133, 109);
			this._truePoint_checkBox.Name = "_truePoint_checkBox";
			this._truePoint_checkBox.Size = new System.Drawing.Size(75, 17);
			this._truePoint_checkBox.TabIndex = 28;
			this._truePoint_checkBox.Text = "True Point";
			this._truePoint_checkBox.UseVisualStyleBackColor = true;
			this._truePoint_checkBox.CheckedChanged += new System.EventHandler(this._truePoint_checkBox_CheckedChanged);
			// 
			// _bit12_label
			// 
			this._bit12_label.AutoSize = true;
			this._bit12_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this._bit12_label.Location = new System.Drawing.Point(3, 84);
			this._bit12_label.Name = "_bit12_label";
			this._bit12_label.Size = new System.Drawing.Size(39, 13);
			this._bit12_label.TabIndex = 29;
			this._bit12_label.Text = "Bit 1/2";
			// 
			// _bit34_label
			// 
			this._bit34_label.AutoSize = true;
			this._bit34_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this._bit34_label.Location = new System.Drawing.Point(3, 110);
			this._bit34_label.Name = "_bit34_label";
			this._bit34_label.Size = new System.Drawing.Size(39, 13);
			this._bit34_label.TabIndex = 33;
			this._bit34_label.Text = "Bit 3/4";
			// 
			// _bit56_label
			// 
			this._bit56_label.AutoSize = true;
			this._bit56_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this._bit56_label.Location = new System.Drawing.Point(3, 136);
			this._bit56_label.Name = "_bit56_label";
			this._bit56_label.Size = new System.Drawing.Size(39, 13);
			this._bit56_label.TabIndex = 34;
			this._bit56_label.Text = "Bit 5/6";
			// 
			// LitEntryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._bit56_label);
			this.Controls.Add(this._bit34_label);
			this.Controls.Add(this._bit12_label);
			this.Controls.Add(this._point_checkBox);
			this.Controls.Add(this._base_checkBox);
			this.Controls.Add(this._truePoint_checkBox);
			this.Controls.Add(this._unknown_label);
			this.Controls.Add(this._flags_textBox);
			this.Controls.Add(this._furn_checkBox);
			this.Controls.Add(this._dir_checkBox);
			this.Controls.Add(this._light_checkBox);
			this.Controls.Add(this._shadow_checkBox);
			this.Controls.Add(this._remove_button);
			this.Controls.Add(this._enabled_label);
			this.Controls.Add(this._enabled_checkBox);
			this.Controls.Add(this._colorB_textBox);
			this.Controls.Add(this._colorG_textBox);
			this.Controls.Add(this._positionZ_textBox);
			this.Controls.Add(this._positionY_textBox);
			this.Controls.Add(this._color_label);
			this.Controls.Add(this._colorR_textBox);
			this.Controls.Add(this._unknown_textBox);
			this.Controls.Add(this._flags_label);
			this.Controls.Add(this._positionX_textBox);
			this.Controls.Add(this._position_label);
			this.Name = "LitEntryControl";
			this.Size = new System.Drawing.Size(278, 214);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _position_label;
        private System.Windows.Forms.TextBox _positionX_textBox;
        private System.Windows.Forms.Label _flags_label;
        private System.Windows.Forms.TextBox _unknown_textBox;
        private System.Windows.Forms.TextBox _colorR_textBox;
        private System.Windows.Forms.Label _color_label;
        private System.Windows.Forms.TextBox _positionY_textBox;
        private System.Windows.Forms.TextBox _positionZ_textBox;
        private System.Windows.Forms.TextBox _colorG_textBox;
        private System.Windows.Forms.TextBox _colorB_textBox;
        private System.Windows.Forms.CheckBox _enabled_checkBox;
        private System.Windows.Forms.Label _enabled_label;
        private System.Windows.Forms.Button _remove_button;
		private System.Windows.Forms.CheckBox _shadow_checkBox;
		private System.Windows.Forms.CheckBox _light_checkBox;
		private System.Windows.Forms.CheckBox _dir_checkBox;
		private System.Windows.Forms.CheckBox _furn_checkBox;
		private System.Windows.Forms.CheckBox _point_checkBox;
		private System.Windows.Forms.CheckBox _base_checkBox;
		private System.Windows.Forms.TextBox _flags_textBox;
		private System.Windows.Forms.Label _unknown_label;
		private System.Windows.Forms.CheckBox _truePoint_checkBox;
		private System.Windows.Forms.Label _bit12_label;
		private System.Windows.Forms.Label _bit34_label;
		private System.Windows.Forms.Label _bit56_label;
	}
}
