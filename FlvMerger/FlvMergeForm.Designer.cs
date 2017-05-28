namespace FlvMerger
{
    partial class FlvMergeForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.lbInputFileName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutputFileName
            // 
            this.txtOutputFileName.Location = new System.Drawing.Point(14, 296);
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.Size = new System.Drawing.Size(463, 22);
            this.txtOutputFileName.TabIndex = 0;
            // 
            // lbInputFileName
            // 
            this.lbInputFileName.AllowDrop = true;
            this.lbInputFileName.FormattingEnabled = true;
            this.lbInputFileName.ItemHeight = 12;
            this.lbInputFileName.Location = new System.Drawing.Point(12, 24);
            this.lbInputFileName.Name = "lbInputFileName";
            this.lbInputFileName.Size = new System.Drawing.Size(881, 244);
            this.lbInputFileName.TabIndex = 1;
            this.lbInputFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbInputFileName_DragDrop);
            this.lbInputFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbInputFileName_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File Name";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(483, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 12);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(564, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpItem
            // 
            this.btnUpItem.Location = new System.Drawing.Point(645, 296);
            this.btnUpItem.Name = "btnUpItem";
            this.btnUpItem.Size = new System.Drawing.Size(46, 22);
            this.btnUpItem.TabIndex = 7;
            this.btnUpItem.Text = "up";
            this.btnUpItem.UseVisualStyleBackColor = true;
            this.btnUpItem.Click += new System.EventHandler(this.btnUpItem_Click);
            // 
            // FlvMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 360);
            this.Controls.Add(this.btnUpItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInputFileName);
            this.Controls.Add(this.txtOutputFileName);
            this.MaximizeBox = false;
            this.Name = "FlvMergeForm";
            this.Text = "FlvMerger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutputFileName;
        private System.Windows.Forms.ListBox lbInputFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpItem;
    }
}

