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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGaisya = new System.Windows.Forms.RadioButton();
            this.rbSonota = new System.Windows.Forms.RadioButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.rbMaker = new System.Windows.Forms.GroupBox();
            this.TextReport = new System.Windows.Forms.TextBox();
            this.ofdImageOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.btOpenDate = new System.Windows.Forms.Button();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearchCarDateTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.tbSearchCarMaker = new System.Windows.Forms.TextBox();
            this.tbSearchCarAuthor = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictueDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cerReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202001DataSet = new CarReportSystem.infosys202001DataSet();
            this.cerReportTableAdapter = new CarReportSystem.infosys202001DataSetTableAdapters.CerReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202001DataSetTableAdapters.TableAdapterManager();
            this.rbAND = new System.Windows.Forms.RadioButton();
            this.rbOR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.rbMaker.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202001DataSet)).BeginInit();
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
            // btSaveDate
            // 
            this.btSaveDate.Location = new System.Drawing.Point(10, 342);
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
            // 
            // pbbtDelete
            // 
            this.pbbtDelete.Location = new System.Drawing.Point(623, 9);
            this.pbbtDelete.Name = "pbbtDelete";
            this.pbbtDelete.Size = new System.Drawing.Size(75, 23);
            this.pbbtDelete.TabIndex = 10;
            this.pbbtDelete.Text = "削除";
            this.pbbtDelete.UseVisualStyleBackColor = true;
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
            this.Exit.Location = new System.Drawing.Point(742, 437);
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
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.pictueDataGridViewImageColumn});
            this.dgvList.DataSource = this.cerReportBindingSource;
            this.dgvList.Location = new System.Drawing.Point(74, 258);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(743, 146);
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
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 13);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 19;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(54, 13);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 20;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(107, 13);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 21;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(162, 13);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 22;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbGaisya
            // 
            this.rbGaisya.AutoSize = true;
            this.rbGaisya.Location = new System.Drawing.Point(220, 13);
            this.rbGaisya.Name = "rbGaisya";
            this.rbGaisya.Size = new System.Drawing.Size(47, 16);
            this.rbGaisya.TabIndex = 23;
            this.rbGaisya.TabStop = true;
            this.rbGaisya.Text = "外車";
            this.rbGaisya.UseVisualStyleBackColor = true;
            // 
            // rbSonota
            // 
            this.rbSonota.AutoSize = true;
            this.rbSonota.Location = new System.Drawing.Point(268, 13);
            this.rbSonota.Name = "rbSonota";
            this.rbSonota.Size = new System.Drawing.Size(54, 16);
            this.rbSonota.TabIndex = 24;
            this.rbSonota.TabStop = true;
            this.rbSonota.Text = "その他";
            this.rbSonota.UseVisualStyleBackColor = true;
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
            this.rbMaker.Controls.Add(this.rbGaisya);
            this.rbMaker.Controls.Add(this.rbSubaru);
            this.rbMaker.Controls.Add(this.rbHonda);
            this.rbMaker.Controls.Add(this.rbSonota);
            this.rbMaker.Controls.Add(this.rbNissan);
            this.rbMaker.Controls.Add(this.rbToyota);
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
            // btOpenDate
            // 
            this.btOpenDate.Location = new System.Drawing.Point(10, 277);
            this.btOpenDate.Name = "btOpenDate";
            this.btOpenDate.Size = new System.Drawing.Size(57, 43);
            this.btOpenDate.TabIndex = 7;
            this.btOpenDate.Text = "接続";
            this.btOpenDate.UseVisualStyleBackColor = true;
            this.btOpenDate.Click += new System.EventHandler(this.btOpenDate_Click_1);
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(39, 12);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(220, 19);
            this.tbSearchCarName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "車名";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbOR);
            this.groupBox1.Controls.Add(this.rbAND);
            this.groupBox1.Controls.Add(this.tbSearchCarAuthor);
            this.groupBox1.Controls.Add(this.tbSearchCarMaker);
            this.groupBox1.Controls.Add(this.tbSearchCarDateTime);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btSearchExe);
            this.groupBox1.Controls.Add(this.tbSearchCarName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(719, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 232);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // tbSearchCarDateTime
            // 
            this.tbSearchCarDateTime.Location = new System.Drawing.Point(39, 71);
            this.tbSearchCarDateTime.Name = "tbSearchCarDateTime";
            this.tbSearchCarDateTime.Size = new System.Drawing.Size(220, 19);
            this.tbSearchCarDateTime.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "記録者";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "メーカー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "日付";
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(182, 180);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 33;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // tbSearchCarMaker
            // 
            this.tbSearchCarMaker.Location = new System.Drawing.Point(47, 38);
            this.tbSearchCarMaker.Name = "tbSearchCarMaker";
            this.tbSearchCarMaker.Size = new System.Drawing.Size(211, 19);
            this.tbSearchCarMaker.TabIndex = 39;
            // 
            // tbSearchCarAuthor
            // 
            this.tbSearchCarAuthor.Location = new System.Drawing.Point(48, 103);
            this.tbSearchCarAuthor.Name = "tbSearchCarAuthor";
            this.tbSearchCarAuthor.Size = new System.Drawing.Size(209, 19);
            this.tbSearchCarAuthor.TabIndex = 40;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            // 
            // pictueDataGridViewImageColumn
            // 
            this.pictueDataGridViewImageColumn.DataPropertyName = "Pictue";
            this.pictueDataGridViewImageColumn.HeaderText = "Pictue";
            this.pictueDataGridViewImageColumn.Name = "pictueDataGridViewImageColumn";
            // 
            // cerReportBindingSource
            // 
            this.cerReportBindingSource.DataMember = "CerReport";
            this.cerReportBindingSource.DataSource = this.infosys202001DataSet;
            // 
            // infosys202001DataSet
            // 
            this.infosys202001DataSet.DataSetName = "infosys202001DataSet";
            this.infosys202001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cerReportTableAdapter
            // 
            this.cerReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CerReportTableAdapter = this.cerReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rbAND
            // 
            this.rbAND.AutoSize = true;
            this.rbAND.Checked = true;
            this.rbAND.Location = new System.Drawing.Point(51, 145);
            this.rbAND.Name = "rbAND";
            this.rbAND.Size = new System.Drawing.Size(47, 16);
            this.rbAND.TabIndex = 41;
            this.rbAND.TabStop = true;
            this.rbAND.Text = "AND";
            this.rbAND.UseVisualStyleBackColor = true;
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Location = new System.Drawing.Point(157, 145);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(39, 16);
            this.rbOR.TabIndex = 42;
            this.rbOR.TabStop = true;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 550);
            this.Controls.Add(this.groupBox1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.rbMaker.ResumeLayout(false);
            this.rbMaker.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202001DataSet)).EndInit();
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
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGaisya;
        private System.Windows.Forms.RadioButton rbSonota;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox rbMaker;
        private System.Windows.Forms.TextBox TextReport;
        private System.Windows.Forms.OpenFileDialog ofdImageOpen;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private infosys202001DataSet infosys202001DataSet;
        private System.Windows.Forms.BindingSource cerReportBindingSource;
        private infosys202001DataSetTableAdapters.CerReportTableAdapter cerReportTableAdapter;
        private infosys202001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictueDataGridViewImageColumn;
        private System.Windows.Forms.Button btOpenDate;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tbSearchCarDateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearchCarAuthor;
        private System.Windows.Forms.TextBox tbSearchCarMaker;
        private System.Windows.Forms.RadioButton rbOR;
        private System.Windows.Forms.RadioButton rbAND;
    }
}

