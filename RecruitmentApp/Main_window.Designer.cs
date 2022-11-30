namespace RecruitmentApp
{
    partial class Main_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.top_panel = new System.Windows.Forms.Panel();
            this.top_panel_picture = new System.Windows.Forms.PictureBox();
            this.top_panel_label = new System.Windows.Forms.Label();
            this.close_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.left_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.logs_btn = new Guna.UI2.WinForms.Guna2Button();
            this.auto_update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.import_btn = new Guna.UI2.WinForms.Guna2Button();
            this.export_btn = new Guna.UI2.WinForms.Guna2Button();
            this.middle_panel = new System.Windows.Forms.Panel();
            this.uC_Export = new RecruitmentApp.UC_Export();
            this.uC_Import = new RecruitmentApp.UC_Import();
            this.uC_Auto_Update = new RecruitmentApp.UC_Auto_Update();
            this.uC_Logs = new RecruitmentApp.UC_Logs();
            this.blank_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top_panel_picture)).BeginInit();
            this.left_panel.SuspendLayout();
            this.middle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.top_panel.Controls.Add(this.top_panel_picture);
            this.top_panel.Controls.Add(this.top_panel_label);
            this.top_panel.Controls.Add(this.close_btn);
            this.top_panel.Controls.Add(this.minimize_btn);
            this.top_panel.Controls.Add(this.maximize_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1280, 58);
            this.top_panel.TabIndex = 0;
            // 
            // top_panel_picture
            // 
            this.top_panel_picture.Image = ((System.Drawing.Image)(resources.GetObject("top_panel_picture.Image")));
            this.top_panel_picture.Location = new System.Drawing.Point(12, 3);
            this.top_panel_picture.Name = "top_panel_picture";
            this.top_panel_picture.Size = new System.Drawing.Size(55, 52);
            this.top_panel_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.top_panel_picture.TabIndex = 2;
            this.top_panel_picture.TabStop = false;
            // 
            // top_panel_label
            // 
            this.top_panel_label.AutoSize = true;
            this.top_panel_label.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.top_panel_label.Location = new System.Drawing.Point(73, 12);
            this.top_panel_label.Name = "top_panel_label";
            this.top_panel_label.Size = new System.Drawing.Size(240, 29);
            this.top_panel_label.TabIndex = 2;
            this.top_panel_label.Text = "Recruitment App";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.close_btn.IconColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1208, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(60, 40);
            this.close_btn.TabIndex = 2;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimize_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.minimize_btn.IconColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1076, 9);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(60, 40);
            this.minimize_btn.TabIndex = 3;
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximize_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.maximize_btn.IconColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(1142, 9);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(60, 40);
            this.maximize_btn.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.top_panel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.top_panel_picture;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.top_panel_label;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.logs_btn);
            this.left_panel.Controls.Add(this.auto_update_btn);
            this.left_panel.Controls.Add(this.import_btn);
            this.left_panel.Controls.Add(this.export_btn);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.left_panel.Location = new System.Drawing.Point(0, 58);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(232, 662);
            this.left_panel.TabIndex = 11;
            // 
            // logs_btn
            // 
            this.logs_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logs_btn.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.logs_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.logs_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logs_btn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.logs_btn.Location = new System.Drawing.Point(0, 268);
            this.logs_btn.Name = "logs_btn";
            this.logs_btn.Size = new System.Drawing.Size(232, 62);
            this.logs_btn.TabIndex = 3;
            this.logs_btn.Text = "Logs";
            this.logs_btn.CheckedChanged += new System.EventHandler(this.logs_btn_CheckedChanged);
            // 
            // auto_update_btn
            // 
            this.auto_update_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.auto_update_btn.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.auto_update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.auto_update_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.auto_update_btn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.auto_update_btn.Location = new System.Drawing.Point(0, 200);
            this.auto_update_btn.Name = "auto_update_btn";
            this.auto_update_btn.Size = new System.Drawing.Size(232, 62);
            this.auto_update_btn.TabIndex = 2;
            this.auto_update_btn.Text = "Auto update";
            this.auto_update_btn.CheckedChanged += new System.EventHandler(this.auto_update_btn_CheckedChanged);
            // 
            // import_btn
            // 
            this.import_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.import_btn.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.import_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.import_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.import_btn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.import_btn.Location = new System.Drawing.Point(0, 132);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(232, 62);
            this.import_btn.TabIndex = 1;
            this.import_btn.Text = "Import";
            this.import_btn.CheckedChanged += new System.EventHandler(this.import_btn_CheckedChanged);
            // 
            // export_btn
            // 
            this.export_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.export_btn.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.export_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.export_btn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.export_btn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.export_btn.Location = new System.Drawing.Point(0, 64);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(232, 62);
            this.export_btn.TabIndex = 0;
            this.export_btn.Text = "Export";
            this.export_btn.CheckedChanged += new System.EventHandler(this.export_btn_CheckedChanged);
            // 
            // middle_panel
            // 
            this.middle_panel.Controls.Add(this.blank_panel);
            this.middle_panel.Controls.Add(this.uC_Logs);
            this.middle_panel.Controls.Add(this.uC_Auto_Update);
            this.middle_panel.Controls.Add(this.uC_Import);
            this.middle_panel.Controls.Add(this.uC_Export);
            this.middle_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middle_panel.Location = new System.Drawing.Point(232, 58);
            this.middle_panel.Name = "middle_panel";
            this.middle_panel.Size = new System.Drawing.Size(1048, 662);
            this.middle_panel.TabIndex = 12;
            // 
            // uC_Export
            // 
            this.uC_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Export.Location = new System.Drawing.Point(0, 0);
            this.uC_Export.Name = "uC_Export";
            this.uC_Export.Size = new System.Drawing.Size(1048, 662);
            this.uC_Export.TabIndex = 0;
            // 
            // uC_Import
            // 
            this.uC_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Import.Location = new System.Drawing.Point(0, 0);
            this.uC_Import.Name = "uC_Import";
            this.uC_Import.Size = new System.Drawing.Size(1048, 662);
            this.uC_Import.TabIndex = 1;
            // 
            // uC_Auto_Update
            // 
            this.uC_Auto_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Auto_Update.Location = new System.Drawing.Point(0, 0);
            this.uC_Auto_Update.Name = "uC_Auto_Update";
            this.uC_Auto_Update.Size = new System.Drawing.Size(1048, 662);
            this.uC_Auto_Update.TabIndex = 2;
            // 
            // uC_Logs
            // 
            this.uC_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Logs.Location = new System.Drawing.Point(0, 0);
            this.uC_Logs.Name = "uC_Logs";
            this.uC_Logs.Size = new System.Drawing.Size(1048, 662);
            this.uC_Logs.TabIndex = 3;
            // 
            // blank_panel
            // 
            this.blank_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blank_panel.Location = new System.Drawing.Point(0, 0);
            this.blank_panel.Name = "blank_panel";
            this.blank_panel.Size = new System.Drawing.Size(1048, 662);
            this.blank_panel.TabIndex = 11;
            // 
            // Main_window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.middle_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_window";
            this.Text = "Form1";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top_panel_picture)).EndInit();
            this.left_panel.ResumeLayout(false);
            this.middle_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel top_panel;
        private Label top_panel_label;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2ControlBox close_btn;
        private Guna.UI2.WinForms.Guna2ControlBox minimize_btn;
        private Guna.UI2.WinForms.Guna2ControlBox maximize_btn;
        private Guna.UI2.WinForms.Guna2Panel left_panel;
        private Panel middle_panel;
        private Guna.UI2.WinForms.Guna2Button export_btn;
        private PictureBox top_panel_picture;
        private Guna.UI2.WinForms.Guna2Button logs_btn;
        private Guna.UI2.WinForms.Guna2Button auto_update_btn;
        private Guna.UI2.WinForms.Guna2Button import_btn;
        private Panel blank_panel;
        private UC_Logs uC_Logs;
        private UC_Auto_Update uC_Auto_Update;
        private UC_Import uC_Import;
        private UC_Export uC_Export;
    }
}