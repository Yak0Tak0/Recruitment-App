using System.Diagnostics;

namespace RecruitmentApp
{
    public partial class Main_window : Form
    {
        private readonly RecruitmentDbContext _context;

        public Main_window(RecruitmentDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void export_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (export_btn.Checked) uC_Export.BringToFront();
        }

        private void import_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (import_btn.Checked) uC_Import.BringToFront();
        }

        private void auto_update_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_update_btn.Checked) uC_Auto_Update.BringToFront();
        }

        private void logs_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (logs_btn.Checked) uC_Logs.BringToFront();
        }
    }
}