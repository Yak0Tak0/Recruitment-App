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
    public partial class UC_Export : UserControl
    {
        private readonly RecruitmentDbContext _context;
        public UC_Export(RecruitmentDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void browse_directory_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                directory_path_input.Text = path;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_input.Text))
            {
                string destinationDirectory = directory_path_input.Text;
                string fileName = "dbDump_" + DateTime.Now.ToString("dd-MM-yyyyTHH-mm") + ".json";
                string filePath = Path.Combine(destinationDirectory, fileName);
                string json = DbToJsonString.Convert(_context);
                SaveJsonToFile.Save(json, filePath);
                MessageBox.Show("Database JSON dump created.", "Info");
            }
            else
            {
                MessageBox.Show("Directory does not exists!", "Warning");
            }
        }
    }
}
