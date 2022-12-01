namespace RecruitmentApp
{
    partial class UC_Auto_Update
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Auto_Update));
            this.start_btn = new Guna.UI2.WinForms.Guna2Button();
            this.browse_directory_btn = new Guna.UI2.WinForms.Guna2Button();
            this.auto_update_directory_path_input = new System.Windows.Forms.TextBox();
            this.auto_update_directory_path_label = new System.Windows.Forms.Label();
            this.auto_update_label = new System.Windows.Forms.Label();
            this.stop_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.start_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.start_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.start_btn.Location = new System.Drawing.Point(808, 526);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(180, 45);
            this.start_btn.TabIndex = 43;
            this.start_btn.Text = "Start";
            this.start_btn.CheckedChanged += new System.EventHandler(this.start_btn_CheckedChanged);
            // 
            // browse_directory_btn
            // 
            this.browse_directory_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browse_directory_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browse_directory_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browse_directory_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browse_directory_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.browse_directory_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_directory_btn.ForeColor = System.Drawing.Color.White;
            this.browse_directory_btn.Image = ((System.Drawing.Image)(resources.GetObject("browse_directory_btn.Image")));
            this.browse_directory_btn.Location = new System.Drawing.Point(961, 216);
            this.browse_directory_btn.Name = "browse_directory_btn";
            this.browse_directory_btn.Size = new System.Drawing.Size(27, 27);
            this.browse_directory_btn.TabIndex = 42;
            this.browse_directory_btn.Click += new System.EventHandler(this.browse_directory_btn_Click);
            // 
            // auto_update_directory_path_input
            // 
            this.auto_update_directory_path_input.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.auto_update_directory_path_input.ForeColor = System.Drawing.SystemColors.GrayText;
            this.auto_update_directory_path_input.Location = new System.Drawing.Point(60, 216);
            this.auto_update_directory_path_input.Name = "auto_update_directory_path_input";
            this.auto_update_directory_path_input.ReadOnly = true;
            this.auto_update_directory_path_input.Size = new System.Drawing.Size(895, 27);
            this.auto_update_directory_path_input.TabIndex = 41;
            // 
            // auto_update_directory_path_label
            // 
            this.auto_update_directory_path_label.AutoSize = true;
            this.auto_update_directory_path_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.auto_update_directory_path_label.Location = new System.Drawing.Point(60, 181);
            this.auto_update_directory_path_label.Name = "auto_update_directory_path_label";
            this.auto_update_directory_path_label.Size = new System.Drawing.Size(270, 25);
            this.auto_update_directory_path_label.TabIndex = 40;
            this.auto_update_directory_path_label.Text = "Auto update directory";
            // 
            // auto_update_label
            // 
            this.auto_update_label.AutoSize = true;
            this.auto_update_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.auto_update_label.Location = new System.Drawing.Point(69, 92);
            this.auto_update_label.Name = "auto_update_label";
            this.auto_update_label.Size = new System.Drawing.Size(619, 25);
            this.auto_update_label.TabIndex = 39;
            this.auto_update_label.Text = "Automatically update table \'product\' from JSON file";
            // 
            // stop_btn
            // 
            this.stop_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.stop_btn.Checked = true;
            this.stop_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stop_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stop_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stop_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stop_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.stop_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stop_btn.Location = new System.Drawing.Point(609, 526);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(180, 45);
            this.stop_btn.TabIndex = 44;
            this.stop_btn.Text = "Stop";
            this.stop_btn.CheckedChanged += new System.EventHandler(this.stop_btn_CheckedChanged);
            // 
            // UC_Auto_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.browse_directory_btn);
            this.Controls.Add(this.auto_update_directory_path_input);
            this.Controls.Add(this.auto_update_directory_path_label);
            this.Controls.Add(this.auto_update_label);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Auto_Update";
            this.Size = new System.Drawing.Size(1048, 662);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button start_btn;
        private Guna.UI2.WinForms.Guna2Button browse_directory_btn;
        private TextBox auto_update_directory_path_input;
        private Label auto_update_directory_path_label;
        private Label auto_update_label;
        private Guna.UI2.WinForms.Guna2Button stop_btn;
    }
}
