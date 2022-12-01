using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RecruitmentApp.Program;

namespace RecruitmentApp
{
    public partial class UC_Import : UserControl
    {
        private readonly RecruitmentDbContext _context;
        public UC_Import(RecruitmentDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void browse_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JSON files (*.json)|*.json";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                import_file_path_input.Text = file;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(import_file_path_input.Text))
            {
                string filePath = import_file_path_input.Text;
                UpdateDbFromJsonFile.Update(filePath, _context);
                MessageBox.Show("Database successfully updated.", "Info");
            }
            else
            {
                MessageBox.Show("File does not exists!", "Warning");
            }
        }
    }
}
