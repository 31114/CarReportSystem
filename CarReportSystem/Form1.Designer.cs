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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btListDelete = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.rbSony = new System.Windows.Forms.RadioButton();
            this.rbToshiba = new System.Windows.Forms.RadioButton();
            this.rbEpic = new System.Windows.Forms.RadioButton();
            this.rbCasablanca = new System.Windows.Forms.RadioButton();
            this.rbIsland = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btObama = new System.Windows.Forms.Button();
            this.btListAdd = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btListOpen = new System.Windows.Forms.Button();
            this.btListSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "発売日";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(92, 282);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(707, 154);
            this.dgvList.TabIndex = 3;
            this.dgvList.Click += new System.EventHandler(this.dgvList_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(605, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(194, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btListDelete
            // 
            this.btListDelete.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListDelete.Location = new System.Drawing.Point(739, 247);
            this.btListDelete.Name = "btListDelete";
            this.btListDelete.Size = new System.Drawing.Size(60, 28);
            this.btListDelete.TabIndex = 0;
            this.btListDelete.Text = "削除";
            this.btListDelete.UseVisualStyleBackColor = true;
            this.btListDelete.Click += new System.EventHandler(this.btListDelete_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(92, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(216, 27);
            this.dtpDate.TabIndex = 5;
            // 
            // cbTitle
            // 
            this.cbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTitle.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(92, 54);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(216, 28);
            this.cbTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "歌手";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "レーベル";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "題名";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(92, 97);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(216, 28);
            this.cbAuthor.TabIndex = 1;
            // 
            // rbSony
            // 
            this.rbSony.AutoSize = true;
            this.rbSony.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbSony.ForeColor = System.Drawing.SystemColors.Control;
            this.rbSony.Location = new System.Drawing.Point(6, 12);
            this.rbSony.Name = "rbSony";
            this.rbSony.Size = new System.Drawing.Size(82, 24);
            this.rbSony.TabIndex = 1;
            this.rbSony.TabStop = true;
            this.rbSony.Text = "SONY";
            this.rbSony.UseVisualStyleBackColor = true;
            // 
            // rbToshiba
            // 
            this.rbToshiba.AutoSize = true;
            this.rbToshiba.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbToshiba.ForeColor = System.Drawing.SystemColors.Control;
            this.rbToshiba.Location = new System.Drawing.Point(94, 12);
            this.rbToshiba.Name = "rbToshiba";
            this.rbToshiba.Size = new System.Drawing.Size(69, 24);
            this.rbToshiba.TabIndex = 2;
            this.rbToshiba.TabStop = true;
            this.rbToshiba.Text = "東芝";
            this.rbToshiba.UseVisualStyleBackColor = true;
            // 
            // rbEpic
            // 
            this.rbEpic.AutoSize = true;
            this.rbEpic.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEpic.ForeColor = System.Drawing.SystemColors.Control;
            this.rbEpic.Location = new System.Drawing.Point(154, 12);
            this.rbEpic.Name = "rbEpic";
            this.rbEpic.Size = new System.Drawing.Size(72, 24);
            this.rbEpic.TabIndex = 3;
            this.rbEpic.TabStop = true;
            this.rbEpic.Text = "EPIC";
            this.rbEpic.UseVisualStyleBackColor = true;
            // 
            // rbCasablanca
            // 
            this.rbCasablanca.AutoSize = true;
            this.rbCasablanca.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbCasablanca.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCasablanca.Location = new System.Drawing.Point(222, 11);
            this.rbCasablanca.Name = "rbCasablanca";
            this.rbCasablanca.Size = new System.Drawing.Size(133, 24);
            this.rbCasablanca.TabIndex = 4;
            this.rbCasablanca.TabStop = true;
            this.rbCasablanca.Text = "Casablanca";
            this.rbCasablanca.UseVisualStyleBackColor = true;
            // 
            // rbIsland
            // 
            this.rbIsland.AutoSize = true;
            this.rbIsland.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbIsland.ForeColor = System.Drawing.SystemColors.Control;
            this.rbIsland.Location = new System.Drawing.Point(346, 12);
            this.rbIsland.Name = "rbIsland";
            this.rbIsland.Size = new System.Drawing.Size(81, 24);
            this.rbIsland.TabIndex = 5;
            this.rbIsland.TabStop = true;
            this.rbIsland.Text = "Island";
            this.rbIsland.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbOther.ForeColor = System.Drawing.SystemColors.Control;
            this.rbOther.Location = new System.Drawing.Point(420, 12);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(81, 24);
            this.rbOther.TabIndex = 6;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "リスト";
            // 
            // btObama
            // 
            this.btObama.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btObama.Location = new System.Drawing.Point(674, 247);
            this.btObama.Name = "btObama";
            this.btObama.Size = new System.Drawing.Size(61, 28);
            this.btObama.TabIndex = 0;
            this.btObama.Text = "変更";
            this.btObama.UseVisualStyleBackColor = true;
            this.btObama.Click += new System.EventHandler(this.btObama_Click);
            // 
            // btListAdd
            // 
            this.btListAdd.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListAdd.Location = new System.Drawing.Point(605, 247);
            this.btListAdd.Name = "btListAdd";
            this.btListAdd.Size = new System.Drawing.Size(66, 28);
            this.btListAdd.TabIndex = 0;
            this.btListAdd.Text = "追加";
            this.btListAdd.UseVisualStyleBackColor = true;
            this.btListAdd.Click += new System.EventHandler(this.btListAdd_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageDelete.Location = new System.Drawing.Point(739, 7);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(60, 28);
            this.btImageDelete.TabIndex = 0;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btImageOpen
            // 
            this.btImageOpen.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageOpen.Location = new System.Drawing.Point(674, 7);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(58, 28);
            this.btImageOpen.TabIndex = 0;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // rtbReport
            // 
            this.rtbReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReport.Location = new System.Drawing.Point(92, 179);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(507, 96);
            this.rtbReport.TabIndex = 7;
            this.rtbReport.Text = "";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btExit.Location = new System.Drawing.Point(719, 442);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(80, 28);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "一覧";
            // 
            // btListOpen
            // 
            this.btListOpen.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListOpen.Location = new System.Drawing.Point(5, 323);
            this.btListOpen.Name = "btListOpen";
            this.btListOpen.Size = new System.Drawing.Size(75, 41);
            this.btListOpen.TabIndex = 0;
            this.btListOpen.Text = "開く";
            this.btListOpen.UseVisualStyleBackColor = true;
            this.btListOpen.Click += new System.EventHandler(this.btListOpen_Click);
            // 
            // btListSave
            // 
            this.btListSave.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btListSave.Location = new System.Drawing.Point(5, 383);
            this.btListSave.Name = "btListSave";
            this.btListSave.Size = new System.Drawing.Size(75, 41);
            this.btListSave.TabIndex = 0;
            this.btListSave.Text = "保存";
            this.btListSave.UseVisualStyleBackColor = true;
            this.btListSave.Click += new System.EventHandler(this.btListSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(601, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "画像";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbSony);
            this.groupBox1.Controls.Add(this.rbEpic);
            this.groupBox1.Controls.Add(this.rbIsland);
            this.groupBox1.Controls.Add(this.rbToshiba);
            this.groupBox1.Controls.Add(this.rbCasablanca);
            this.groupBox1.Location = new System.Drawing.Point(92, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 42);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(811, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btListSave);
            this.Controls.Add(this.btListOpen);
            this.Controls.Add(this.btListAdd);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btObama);
            this.Controls.Add(this.btListDelete);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btListDelete;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.RadioButton rbSony;
        private System.Windows.Forms.RadioButton rbToshiba;
        private System.Windows.Forms.RadioButton rbEpic;
        private System.Windows.Forms.RadioButton rbCasablanca;
        private System.Windows.Forms.RadioButton rbIsland;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btObama;
        private System.Windows.Forms.Button btListAdd;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btListOpen;
        private System.Windows.Forms.Button btListSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

