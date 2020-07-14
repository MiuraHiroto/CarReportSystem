namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpenDate = new System.Windows.Forms.Button();
            this.btSaveDate = new System.Windows.Forms.Button();
            this.pbbtOpen = new System.Windows.Forms.Button();
            this.pbbtDelete = new System.Windows.Forms.Button();
            this.btdgvAddition = new System.Windows.Forms.Button();
            this.btdgvFix = new System.Windows.Forms.Button();
            this.btdgvDelete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.rbMaker = new System.Windows.Forms.GroupBox();
            this.TextReport = new System.Windows.Forms.TextBox();
            this.ofdImageOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.rbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "画像：";
            // 
            // btOpenDate
            // 
            this.btOpenDate.Location = new System.Drawing.Point(10, 291);
            this.btOpenDate.Name = "btOpenDate";
            this.btOpenDate.Size = new System.Drawing.Size(57, 43);
            this.btOpenDate.TabIndex = 7;
            this.btOpenDate.Text = "接続";
            this.btOpenDate.UseVisualStyleBackColor = true;
            this.btOpenDate.Click += new System.EventHandler(this.btOpenDate_Click);
            // 
            // btSaveDate
            // 
            this.btSaveDate.Location = new System.Drawing.Point(10, 340);
            this.btSaveDate.Name = "btSaveDate";
            this.btSaveDate.Size = new System.Drawing.Size(57, 40);
            this.btSaveDate.TabIndex = 8;
            this.btSaveDate.Text = "保存";
            this.btSaveDate.UseVisualStyleBackColor = true;
            this.btSaveDate.Click += new System.EventHandler(this.btSaveDate_Click);
            // 
            // pbbtOpen
            // 
            this.pbbtOpen.Location = new System.Drawing.Point(525, 9);
            this.pbbtOpen.Name = "pbbtOpen";
            this.pbbtOpen.Size = new System.Drawing.Size(75, 23);
            this.pbbtOpen.TabIndex = 9;
            this.pbbtOpen.Text = "開く";
            this.pbbtOpen.UseVisualStyleBackColor = true;
            this.pbbtOpen.Click += new System.EventHandler(this.pbbtOpen_Click);
            // 
            // pbbtDelete
            // 
            this.pbbtDelete.Location = new System.Drawing.Point(623, 9);
            this.pbbtDelete.Name = "pbbtDelete";
            this.pbbtDelete.Size = new System.Drawing.Size(75, 23);
            this.pbbtDelete.TabIndex = 10;
            this.pbbtDelete.Text = "削除";
            this.pbbtDelete.UseVisualStyleBackColor = true;
            this.pbbtDelete.Click += new System.EventHandler(this.pbbtDelete_Click);
            // 
            // btdgvAddition
            // 
            this.btdgvAddition.Location = new System.Drawing.Point(461, 229);
            this.btdgvAddition.Name = "btdgvAddition";
            this.btdgvAddition.Size = new System.Drawing.Size(75, 23);
            this.btdgvAddition.TabIndex = 11;
            this.btdgvAddition.Text = "追加";
            this.btdgvAddition.UseVisualStyleBackColor = true;
            this.btdgvAddition.Click += new System.EventHandler(this.btdgvAddition_Click);
            // 
            // btdgvFix
            // 
            this.btdgvFix.Location = new System.Drawing.Point(542, 229);
            this.btdgvFix.Name = "btdgvFix";
            this.btdgvFix.Size = new System.Drawing.Size(75, 23);
            this.btdgvFix.TabIndex = 12;
            this.btdgvFix.Text = "修正";
            this.btdgvFix.UseVisualStyleBackColor = true;
            this.btdgvFix.Click += new System.EventHandler(this.btdgvFix_Click);
            // 
            // btdgvDelete
            // 
            this.btdgvDelete.Location = new System.Drawing.Point(623, 229);
            this.btdgvDelete.Name = "btdgvDelete";
            this.btdgvDelete.Size = new System.Drawing.Size(75, 23);
            this.btdgvDelete.TabIndex = 13;
            this.btdgvDelete.Text = "削除";
            this.btdgvDelete.UseVisualStyleBackColor = true;
            this.btdgvDelete.Click += new System.EventHandler(this.btdgvDelete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(623, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "終了";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textCreatedDate
            // 
            this.textCreatedDate.Location = new System.Drawing.Point(73, 15);
            this.textCreatedDate.Name = "textCreatedDate";
            this.textCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.textCreatedDate.TabIndex = 15;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(74, 263);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.Size = new System.Drawing.Size(624, 146);
            this.dgvList.TabIndex = 16;
            this.dgvList.Click += new System.EventHandler(this.dgvList_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(73, 50);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(250, 20);
            this.cbAuthor.TabIndex = 17;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(74, 114);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(250, 20);
            this.cbName.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(54, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(107, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(162, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(220, 13);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "外車";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(268, 13);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 24;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbPicture.Location = new System.Drawing.Point(461, 38);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(237, 185);
            this.pbPicture.TabIndex = 25;
            this.pbPicture.TabStop = false;
            // 
            // rbMaker
            // 
            this.rbMaker.Controls.Add(this.radioButton5);
            this.rbMaker.Controls.Add(this.radioButton4);
            this.rbMaker.Controls.Add(this.radioButton3);
            this.rbMaker.Controls.Add(this.radioButton6);
            this.rbMaker.Controls.Add(this.radioButton2);
            this.rbMaker.Controls.Add(this.radioButton1);
            this.rbMaker.Location = new System.Drawing.Point(73, 76);
            this.rbMaker.Name = "rbMaker";
            this.rbMaker.Size = new System.Drawing.Size(328, 38);
            this.rbMaker.TabIndex = 28;
            this.rbMaker.TabStop = false;
            this.rbMaker.Text = "メーカー";
            // 
            // TextReport
            // 
            this.TextReport.Location = new System.Drawing.Point(73, 152);
            this.TextReport.Multiline = true;
            this.TextReport.Name = "TextReport";
            this.TextReport.Size = new System.Drawing.Size(381, 100);
            this.TextReport.TabIndex = 29;
            // 
            // ofdImageOpen
            // 
            this.ofdImageOpen.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.TextReport);
            this.Controls.Add(this.rbMaker);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.textCreatedDate);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btdgvDelete);
            this.Controls.Add(this.btdgvFix);
            this.Controls.Add(this.btdgvAddition);
            this.Controls.Add(this.pbbtDelete);
            this.Controls.Add(this.pbbtOpen);
            this.Controls.Add(this.btSaveDate);
            this.Controls.Add(this.btOpenDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.rbMaker.ResumeLayout(false);
            this.rbMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenDate;
        private System.Windows.Forms.Button btSaveDate;
        private System.Windows.Forms.Button pbbtOpen;
        private System.Windows.Forms.Button pbbtDelete;
        private System.Windows.Forms.Button btdgvAddition;
        private System.Windows.Forms.Button btdgvFix;
        private System.Windows.Forms.Button btdgvDelete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DateTimePicker textCreatedDate;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox rbMaker;
        private System.Windows.Forms.TextBox TextReport;
        private System.Windows.Forms.OpenFileDialog ofdImageOpen;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
    }
}

