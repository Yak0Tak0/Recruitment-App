namespace RecruitmentApp
{
    partial class UC_Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Export));
            this.label1 = new System.Windows.Forms.Label();
            this.export_label = new System.Windows.Forms.Label();
            this.export_directory_label = new System.Windows.Forms.Label();
            this.directory_path_input = new System.Windows.Forms.TextBox();
            this.browse_directory_btn = new Guna.UI2.WinForms.Guna2Button();
            this.submit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // export_label
            // 
            this.export_label.AutoSize = true;
            this.export_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.export_label.Location = new System.Drawing.Point(69, 92);
            this.export_label.Name = "export_label";
            this.export_label.Size = new System.Drawing.Size(413, 25);
            this.export_label.TabIndex = 0;
            this.export_label.Text = "Export table \'product\' to JSON file";
            // 
            // export_directory_label
            // 
            this.export_directory_label.AutoSize = true;
            this.export_directory_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.export_directory_label.Location = new System.Drawing.Point(69, 182);
            this.export_directory_label.Name = "export_directory_label";
            this.export_directory_label.Size = new System.Drawing.Size(202, 25);
            this.export_directory_label.TabIndex = 1;
            this.export_directory_label.Text = "Export directory";
            // 
            // directory_path_input
            // 
            this.directory_path_input.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directory_path_input.ForeColor = System.Drawing.SystemColors.GrayText;
            this.directory_path_input.Location = new System.Drawing.Point(69, 217);
            this.directory_path_input.Name = "directory_path_input";
            this.directory_path_input.ReadOnly = true;
            this.directory_path_input.Size = new System.Drawing.Size(895, 27);
            this.directory_path_input.TabIndex = 2;
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
            this.browse_directory_btn.Location = new System.Drawing.Point(970, 217);
            this.browse_directory_btn.Name = "browse_directory_btn";
            this.browse_directory_btn.Size = new System.Drawing.Size(27, 27);
            this.browse_directory_btn.TabIndex = 32;
            this.browse_directory_btn.Click += new System.EventHandler(this.browse_directory_btn_Click);
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
            this.submit_btn.TabIndex = 33;
            this.submit_btn.Text = "Export";
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // UC_Export
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.browse_directory_btn);
            this.Controls.Add(this.directory_path_input);
            this.Controls.Add(this.export_directory_label);
            this.Controls.Add(this.export_label);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "UC_Export";
            this.Size = new System.Drawing.Size(1048, 662);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label export_label;
        private Label export_directory_label;
        private TextBox directory_path_input;
        private Guna.UI2.WinForms.Guna2Button browse_directory_btn;
        private Guna.UI2.WinForms.Guna2Button submit_btn;
    }
}
