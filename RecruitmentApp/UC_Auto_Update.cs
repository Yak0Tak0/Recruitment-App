using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RecruitmentApp.Program;

namespace RecruitmentApp
{
    public partial class UC_Auto_Update : UserControl
    {
        private readonly RecruitmentDbContext _context;
        private System.Timers.Timer timer;
        public UC_Auto_Update(RecruitmentDbContext context)
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
                auto_update_directory_path_input.Text = path;
            }
        }

        private void start_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(auto_update_directory_path_input.Text))
            {
                if (start_btn.Checked)
                {
                    AutoUpdate(null, null);
                    timer = new System.Timers.Timer(300000); // Set timer to 5 minutes 
                    timer.Elapsed += AutoUpdate;
                    timer.AutoReset = true;
                    timer.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Directory does not exists!", "Warning");
            }
        }

        private void stop_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (stop_btn.Checked)
            {
                timer.Enabled = false;
            }
        }

        private void AutoUpdate(Object source, System.Timers.ElapsedEventArgs e)
        {
            string path = auto_update_directory_path_input.Text; // Path to directory with JSON files to import
            string donePath = Path.Combine(path, "Done"); // Path to Done directory
            string logsDir = Path.Combine(path, "Logs"); // Logs directory path
            string logPath = Path.Combine(logsDir, "logs.json"); // Path to Logs file
            Log? log = new Log();

            // If Done directory not exists, then create it
            if (!Directory.Exists(donePath))
            {
                Directory.CreateDirectory(donePath);
            }

            if (!Directory.Exists(logsDir))
            {
                Directory.CreateDirectory(logsDir);
            }

            // Check if .json files exist in specified directory
            string[] files = Directory.GetFiles(path, "*.json");
            if(files.Length > 0)
            {
                string filePath = files[0]; // Path to JSON file to import
                Debug.WriteLine("filePath: " + filePath);
                string doneFilePath = Path.Combine(donePath, Path.GetFileName(filePath)); // Path to move JSON file after import
                Debug.WriteLine("doneFilePath: " + doneFilePath);
                try
                {
                    log = UpdateDbFromJsonFile.Update(filePath, _context);
                    File.Move(filePath, doneFilePath, true);
                    if(log != null) { SaveLogToFile.Save(logPath, log); }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
