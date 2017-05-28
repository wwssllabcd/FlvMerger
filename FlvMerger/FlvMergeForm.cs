using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EricCore;


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

        private void string_to_listBox(string[] files, ListBox listbox)
        {
            this.lbInputFileName.Items.Clear();

            IList<string> sortList = new List<string>(files);
            sortList = sortList.OrderBy(q => q).ToList();

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
            string_to_listBox(files, this.lbInputFileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbInputFileName.Items.Clear();
            this.txtOutputFileName.Text = "";
        }

        private void up_down_item(ListBox lb, int select, bool isUpItem)
        {
            var selString = lb.Items[select];
            int selSwitch;
            if (isUpItem)
            {
                selSwitch = select - 1;
            }
            else
            {
                selSwitch = select + 1;
            }
            var switchString = lbInputFileName.Items[selSwitch];

            lb.Items.Insert(select + 1, selString);
            lb.Items.Insert(select + 2, switchString);



        }
        private void btnUpItem_Click(object sender, EventArgs e)
        {
            //int sel = lbInputFileName.SelectedIndex;
            //if (sel == 0)
            //{
            //    return;
            //}

            ////switch up/down
            //int selSwitch = sel - 1;
            //int insertPtr = sel + 1;

            //var selString = lbInputFileName.Items[sel];
            //var upString = lbInputFileName.Items[selSwitch];

            //lbInputFileName.Items.Insert(insertPtr, selString);
            //lbInputFileName.Items.Insert(insertPtr + 1, upString);

            //lbInputFileName.Items.RemoveAt(sel);
            //lbInputFileName.Items.RemoveAt(selSwitch);

            //lbInputFileName.SelectedIndex = sel - 1;
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            int sel = lbInputFileName.SelectedIndex;
            if ((sel+1) == lbInputFileName.Items.Count)
            {
                return;
            }
            int selSwitch = sel + 1;
            int insertPtr = sel + 2;


            //switch up/down
            var selString = lbInputFileName.Items[sel];
            var switchString = lbInputFileName.Items[selSwitch];

            lbInputFileName.Items.Insert(insertPtr, switchString);
            lbInputFileName.Items.Insert(insertPtr+1, selString);



            lbInputFileName.Items.RemoveAt(sel);
            lbInputFileName.Items.RemoveAt(selSwitch);

            lbInputFileName.SelectedIndex = sel + 1;

        }
    }
}
