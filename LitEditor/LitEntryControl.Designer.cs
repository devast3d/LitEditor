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
            this._unknown_label = new System.Windows.Forms.Label();
            this._unknown1_textBox = new System.Windows.Forms.TextBox();
            this._unknown2_textBox = new System.Windows.Forms.TextBox();
            this._colorR_textBox = new System.Windows.Forms.TextBox();
            this._color_label = new System.Windows.Forms.Label();
            this._positionY_textBox = new System.Windows.Forms.TextBox();
            this._positionZ_textBox = new System.Windows.Forms.TextBox();
            this._colorG_textBox = new System.Windows.Forms.TextBox();
            this._colorB_textBox = new System.Windows.Forms.TextBox();
            this._enabled_checkBox = new System.Windows.Forms.CheckBox();
            this._enabled_label = new System.Windows.Forms.Label();
            this._remove_button = new System.Windows.Forms.Button();
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
            this._positionX_textBox.TextChanged += new System.EventHandler(this._positionX_textBox_TextChanged);
            this._positionX_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _unknown_label
            // 
            this._unknown_label.AutoSize = true;
            this._unknown_label.Location = new System.Drawing.Point(3, 58);
            this._unknown_label.Name = "_unknown_label";
            this._unknown_label.Size = new System.Drawing.Size(53, 13);
            this._unknown_label.TabIndex = 2;
            this._unknown_label.Text = "Unknown";
            // 
            // _unknown1_textBox
            // 
            this._unknown1_textBox.Location = new System.Drawing.Point(62, 55);
            this._unknown1_textBox.Name = "_unknown1_textBox";
            this._unknown1_textBox.Size = new System.Drawing.Size(65, 20);
            this._unknown1_textBox.TabIndex = 4;
            this._unknown1_textBox.TextChanged += new System.EventHandler(this._unknown1_textBox_TextChanged);
            this._unknown1_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._unknown_textBox_Validating);
            // 
            // _unknown2_textBox
            // 
            this._unknown2_textBox.Location = new System.Drawing.Point(133, 55);
            this._unknown2_textBox.Name = "_unknown2_textBox";
            this._unknown2_textBox.Size = new System.Drawing.Size(65, 20);
            this._unknown2_textBox.TabIndex = 5;
            this._unknown2_textBox.TextChanged += new System.EventHandler(this._unknown2_textBox_TextChanged);
            this._unknown2_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._unknown_textBox_Validating);
            // 
            // _colorR_textBox
            // 
            this._colorR_textBox.Location = new System.Drawing.Point(62, 81);
            this._colorR_textBox.Name = "_colorR_textBox";
            this._colorR_textBox.Size = new System.Drawing.Size(65, 20);
            this._colorR_textBox.TabIndex = 6;
            this._colorR_textBox.TextChanged += new System.EventHandler(this._colorR_textBox_TextChanged);
            this._colorR_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _color_label
            // 
            this._color_label.AutoSize = true;
            this._color_label.Location = new System.Drawing.Point(3, 84);
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
            this._positionY_textBox.TextChanged += new System.EventHandler(this._positionY_textBox_TextChanged);
            this._positionY_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _positionZ_textBox
            // 
            this._positionZ_textBox.Location = new System.Drawing.Point(204, 29);
            this._positionZ_textBox.Name = "_positionZ_textBox";
            this._positionZ_textBox.Size = new System.Drawing.Size(65, 20);
            this._positionZ_textBox.TabIndex = 9;
            this._positionZ_textBox.TextChanged += new System.EventHandler(this._positionZ_textBox_TextChanged);
            this._positionZ_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _colorG_textBox
            // 
            this._colorG_textBox.Location = new System.Drawing.Point(133, 81);
            this._colorG_textBox.Name = "_colorG_textBox";
            this._colorG_textBox.Size = new System.Drawing.Size(65, 20);
            this._colorG_textBox.TabIndex = 10;
            this._colorG_textBox.TextChanged += new System.EventHandler(this._colorG_textBox_TextChanged);
            this._colorG_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _colorB_textBox
            // 
            this._colorB_textBox.Location = new System.Drawing.Point(204, 81);
            this._colorB_textBox.Name = "_colorB_textBox";
            this._colorB_textBox.Size = new System.Drawing.Size(65, 20);
            this._colorB_textBox.TabIndex = 11;
            this._colorB_textBox.TextChanged += new System.EventHandler(this._colorB_textBox_TextChanged);
            this._colorB_textBox.Validating += new System.ComponentModel.CancelEventHandler(this._position_textBox_Validating);
            // 
            // _enabled_checkBox
            // 
            this._enabled_checkBox.AutoSize = true;
            this._enabled_checkBox.Location = new System.Drawing.Point(62, 5);
            this._enabled_checkBox.Name = "_enabled_checkBox";
            this._enabled_checkBox.Size = new System.Drawing.Size(15, 14);
            this._enabled_checkBox.TabIndex = 13;
            this._enabled_checkBox.UseVisualStyleBackColor = true;
            this._enabled_checkBox.CheckedChanged += new System.EventHandler(this._enabled_checkBox_CheckedChanged);
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
            this._remove_button.Click += new System.EventHandler(this._remove_button_Click);
            // 
            // LitEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this._remove_button);
            this.Controls.Add(this._enabled_label);
            this.Controls.Add(this._enabled_checkBox);
            this.Controls.Add(this._colorB_textBox);
            this.Controls.Add(this._colorG_textBox);
            this.Controls.Add(this._positionZ_textBox);
            this.Controls.Add(this._positionY_textBox);
            this.Controls.Add(this._color_label);
            this.Controls.Add(this._colorR_textBox);
            this.Controls.Add(this._unknown2_textBox);
            this.Controls.Add(this._unknown1_textBox);
            this.Controls.Add(this._unknown_label);
            this.Controls.Add(this._positionX_textBox);
            this.Controls.Add(this._position_label);
            this.Name = "LitEntryControl";
            this.Size = new System.Drawing.Size(279, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _position_label;
        private System.Windows.Forms.TextBox _positionX_textBox;
        private System.Windows.Forms.Label _unknown_label;
        private System.Windows.Forms.TextBox _unknown1_textBox;
        private System.Windows.Forms.TextBox _unknown2_textBox;
        private System.Windows.Forms.TextBox _colorR_textBox;
        private System.Windows.Forms.Label _color_label;
        private System.Windows.Forms.TextBox _positionY_textBox;
        private System.Windows.Forms.TextBox _positionZ_textBox;
        private System.Windows.Forms.TextBox _colorG_textBox;
        private System.Windows.Forms.TextBox _colorB_textBox;
        private System.Windows.Forms.CheckBox _enabled_checkBox;
        private System.Windows.Forms.Label _enabled_label;
        private System.Windows.Forms.Button _remove_button;
    }
}
