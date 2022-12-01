namespace RecruitmentApp
{
    partial class UC_Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Import));
            this.submit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.browse_file_btn = new Guna.UI2.WinForms.Guna2Button();
            this.import_file_path_input = new System.Windows.Forms.TextBox();
            this.import_file_path_label = new System.Windows.Forms.Label();
            this.import_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.submit_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit_btn.Location = new System.Drawing.Point(817, 527);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(180, 45);
            this.submit_btn.TabIndex = 38;
            this.submit_btn.Text = "Import";
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // browse_file_btn
            // 
            this.browse_file_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browse_file_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browse_file_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browse_file_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browse_file_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.browse_file_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_file_btn.ForeColor = System.Drawing.Color.White;
            this.browse_file_btn.Image = ((System.Drawing.Image)(resources.GetObject("browse_file_btn.Image")));
            this.browse_file_btn.Location = new System.Drawing.Point(970, 217);
            this.browse_file_btn.Name = "browse_file_btn";
            this.browse_file_btn.Size = new System.Drawing.Size(27, 27);
            this.browse_file_btn.TabIndex = 37;
            this.browse_file_btn.Click += new System.EventHandler(this.browse_file_btn_Click);
            // 
            // import_file_path_input
            // 
            this.import_file_path_input.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.import_file_path_input.ForeColor = System.Drawing.SystemColors.GrayText;
            this.import_file_path_input.Location = new System.Drawing.Point(69, 217);
            this.import_file_path_input.Name = "import_file_path_input";
            this.import_file_path_input.ReadOnly = true;
            this.import_file_path_input.Size = new System.Drawing.Size(895, 27);
            this.import_file_path_input.TabIndex = 36;
            // 
            // import_file_path_label
            // 
            this.import_file_path_label.AutoSize = true;
            this.import_file_path_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.import_file_path_label.Location = new System.Drawing.Point(69, 182);
            this.import_file_path_label.Name = "import_file_path_label";
            this.import_file_path_label.Size = new System.Drawing.Size(180, 25);
            this.import_file_path_label.TabIndex = 35;
            this.import_file_path_label.Text = "JSON file path";
            // 
            // import_label
            // 
            this.import_label.AutoSize = true;
            this.import_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.import_label.Location = new System.Drawing.Point(69, 92);
            this.import_label.Name = "import_label";
            this.import_label.Size = new System.Drawing.Size(452, 25);
            this.import_label.TabIndex = 34;
            this.import_label.Text = "Update table \'product\' from JSON file";
            // 
            // UC_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.browse_file_btn);
            this.Controls.Add(this.import_file_path_input);
            this.Controls.Add(this.import_file_path_label);
            this.Controls.Add(this.import_label);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Import";
            this.Size = new System.Drawing.Size(1048, 662);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button submit_btn;
        private Guna.UI2.WinForms.Guna2Button browse_file_btn;
        private TextBox import_file_path_input;
        private Label import_file_path_label;
        private Label import_label;
    }
}
