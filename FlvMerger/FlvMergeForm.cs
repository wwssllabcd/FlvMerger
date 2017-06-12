using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EricCore;
using System.IO;


namespace FlvMerger
{
    public partial class FlvMergeForm : Form
    {
        public FlvMergeForm()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting";
            string outputFileName = this.txtOutputFileName.Text;


            FlvMerge flvMerger = new FlvMerge(outputFileName);
            foreach (string file in this.lbInputFileName.Items)
            {
                flvMerger.merge(file);
            }
            flvMerger.closeFile();
            lblStatus.Text = "Finish";
        }

        private void lbInputFileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void string_to_listBox(List<string> sortList, ListBox listbox)
        {
            this.lbInputFileName.Items.Clear();
            foreach (string file in sortList)
            {
                this.lbInputFileName.Items.Add(file);
            }
        }

        private string replace_string_tail(string orgString, string target, string replaceString)
        {
            int idx = orgString.LastIndexOf(target);
            return orgString.Substring(0, idx) + replaceString;
        }

        private void lbInputFileName_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.txtOutputFileName.Text = replace_string_tail(files[0], ".", "_merge.flv");

            List<string> fileList = new List<string>(files);

            string_to_listBox(sort_file_name_by_time(fileList), this.lbInputFileName);
            lblStatus.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbInputFileName.Items.Clear();
            this.txtOutputFileName.Text = "";
        }

        private void btnUpItem_Click(object sender, EventArgs e)
        {
            int sel = lbInputFileName.SelectedIndex;
            if (sel == 0)
            {
                return;
            }
            WfUtility wfu = new WfUtility();

            wfu.up_down_item(lbInputFileName, sel, true);
        }

   
        private void btnItemDown_Click(object sender, EventArgs e)
        {
            int sel = lbInputFileName.SelectedIndex;
            if ((sel + 1) == lbInputFileName.Items.Count)
            {
                return;
            }
            WfUtility wfu = new WfUtility();
            wfu.up_down_item(lbInputFileName, sel, false);
        }
        class FileTime
        {
            public string name;
            public DateTime time;
        }
        List<FileTime> fileTimeColls = new List<FlvMergeForm.FileTime>();

        private List<string> sort_file_name_by_time(List<string> fileNameColls)
        {

            fileTimeColls.Clear();
            foreach (string name in fileNameColls)
            {
                FileTime f = new FileTime();
                f.name = name;
                f.time = File.GetLastWriteTime(name);
                fileTimeColls.Add(f);
            }
            fileTimeColls.Sort((x, y) => {
                return x.time.CompareTo(y.time);
            });

            List<string> fileName = new List<string>();
            foreach (FileTime ft in fileTimeColls)
            {
                fileName.Add(ft.name);
            }
            return fileName;
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            List<String> fileNames = new List<string>();
            foreach (string name in lbInputFileName.Items)
            {
                fileNames.Add(name);
            }
            string_to_listBox(sort_file_name_by_time(fileNames), this.lbInputFileName);
        }
    }
}
