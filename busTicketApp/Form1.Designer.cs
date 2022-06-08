namespace busTicketApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_nereden = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_nereye = new System.Windows.Forms.Label();
            this.btn_seferGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_nereye = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_nereden = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gB_guzergah = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGuzergahDurak = new System.Windows.Forms.TextBox();
            this.cbGuzergahNereden = new System.Windows.Forms.ComboBox();
            this.cbGuzergahNereye = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuzergahKayit = new System.Windows.Forms.Button();
            this.btnGuzergah = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gB_guzergah.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(864, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(920, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "SATIN AL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(814, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 18);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "off";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_nereden
            // 
            this.lbl_nereden.AutoSize = true;
            this.lbl_nereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_nereden.Location = new System.Drawing.Point(12, 41);
            this.lbl_nereden.Name = "lbl_nereden";
            this.lbl_nereden.Size = new System.Drawing.Size(75, 16);
            this.lbl_nereden.TabIndex = 17;
            this.lbl_nereden.Text = "Nereden :";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_nereye
            // 
            this.lbl_nereye.AutoSize = true;
            this.lbl_nereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_nereye.Location = new System.Drawing.Point(12, 77);
            this.lbl_nereye.Name = "lbl_nereye";
            this.lbl_nereye.Size = new System.Drawing.Size(74, 16);
            this.lbl_nereye.TabIndex = 18;
            this.lbl_nereye.Text = "Nereye   :";
            // 
            // btn_seferGetir
            // 
            this.btn_seferGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seferGetir.Location = new System.Drawing.Point(15, 135);
            this.btn_seferGetir.Name = "btn_seferGetir";
            this.btn_seferGetir.Size = new System.Drawing.Size(278, 37);
            this.btn_seferGetir.TabIndex = 28;
            this.btn_seferGetir.Text = "Seferleri Getir";
            this.btn_seferGetir.UseVisualStyleBackColor = true;
            this.btn_seferGetir.Click += new System.EventHandler(this.btn_seferGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(864, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 532);
            this.dataGridView1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(-1, -6);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(864, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "                                  1453\'den beri sizlerle ...                  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_nereye
            // 
            this.cb_nereye.DisplayMember = "ilAdi";
            this.cb_nereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nereye.FormattingEnabled = true;
            this.cb_nereye.Location = new System.Drawing.Point(94, 77);
            this.cb_nereye.Name = "cb_nereye";
            this.cb_nereye.Size = new System.Drawing.Size(199, 21);
            this.cb_nereye.TabIndex = 21;
            this.cb_nereye.ValueMember = "ilPlakaNo";
            this.cb_nereye.SelectedIndexChanged += new System.EventHandler(this.cb_nereye_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(930, 598);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(825, 37);
            this.textBox1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1680, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cb_nereden
            // 
            this.cb_nereden.DisplayMember = "ilAdi";
            this.cb_nereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nereden.FormattingEnabled = true;
            this.cb_nereden.Location = new System.Drawing.Point(94, 41);
            this.cb_nereden.Name = "cb_nereden";
            this.cb_nereden.Size = new System.Drawing.Size(199, 21);
            this.cb_nereden.TabIndex = 20;
            this.cb_nereden.ValueMember = "ilPlakaNo";
            this.cb_nereden.SelectedIndexChanged += new System.EventHandler(this.cb_nereden_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tarih       :";
            // 
            // gB_guzergah
            // 
            this.gB_guzergah.Controls.Add(this.label10);
            this.gB_guzergah.Controls.Add(this.label9);
            this.gB_guzergah.Controls.Add(this.tbGuzergahDurak);
            this.gB_guzergah.Controls.Add(this.cbGuzergahNereden);
            this.gB_guzergah.Controls.Add(this.cbGuzergahNereye);
            this.gB_guzergah.Controls.Add(this.label6);
            this.gB_guzergah.Controls.Add(this.label5);
            this.gB_guzergah.Controls.Add(this.label4);
            this.gB_guzergah.Controls.Add(this.label1);
            this.gB_guzergah.Controls.Add(this.btnGuzergahKayit);
            this.gB_guzergah.Location = new System.Drawing.Point(12, 285);
            this.gB_guzergah.Name = "gB_guzergah";
            this.gB_guzergah.Size = new System.Drawing.Size(488, 156);
            this.gB_guzergah.TabIndex = 38;
            this.gB_guzergah.TabStop = false;
            this.gB_guzergah.Text = "Güzergah Ekleme";
            this.gB_guzergah.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "label9";
            // 
            // tbGuzergahDurak
            // 
            this.tbGuzergahDurak.Location = new System.Drawing.Point(173, 87);
            this.tbGuzergahDurak.Name = "tbGuzergahDurak";
            this.tbGuzergahDurak.Size = new System.Drawing.Size(309, 20);
            this.tbGuzergahDurak.TabIndex = 25;
            this.tbGuzergahDurak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGuzergahDurak_KeyPress);
            // 
            // cbGuzergahNereden
            // 
            this.cbGuzergahNereden.DisplayMember = "ilAdi";
            this.cbGuzergahNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuzergahNereden.FormattingEnabled = true;
            this.cbGuzergahNereden.Location = new System.Drawing.Point(175, 25);
            this.cbGuzergahNereden.Name = "cbGuzergahNereden";
            this.cbGuzergahNereden.Size = new System.Drawing.Size(199, 21);
            this.cbGuzergahNereden.TabIndex = 23;
            this.cbGuzergahNereden.ValueMember = "ilPlakaNo";
            this.cbGuzergahNereden.SelectedIndexChanged += new System.EventHandler(this.cbGuzergahNereden_SelectedIndexChanged);
            // 
            // cbGuzergahNereye
            // 
            this.cbGuzergahNereye.DisplayMember = "ilAdi";
            this.cbGuzergahNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuzergahNereye.FormattingEnabled = true;
            this.cbGuzergahNereye.Location = new System.Drawing.Point(175, 56);
            this.cbGuzergahNereye.Name = "cbGuzergahNereye";
            this.cbGuzergahNereye.Size = new System.Drawing.Size(199, 21);
            this.cbGuzergahNereye.TabIndex = 24;
            this.cbGuzergahNereye.ValueMember = "ilPlakaNo";
            this.cbGuzergahNereye.SelectedIndexChanged += new System.EventHandler(this.cbGuzergahNereye_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Plaka numaraları tire(-) ile koyulmalıdır. 50-38-41";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duraklar(Plaka Numaraları) ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nereye                                ->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden                              ->";
            // 
            // btnGuzergahKayit
            // 
            this.btnGuzergahKayit.Location = new System.Drawing.Point(407, 130);
            this.btnGuzergahKayit.Name = "btnGuzergahKayit";
            this.btnGuzergahKayit.Size = new System.Drawing.Size(75, 23);
            this.btnGuzergahKayit.TabIndex = 0;
            this.btnGuzergahKayit.Text = "Kaydet";
            this.btnGuzergahKayit.UseVisualStyleBackColor = true;
            this.btnGuzergahKayit.Click += new System.EventHandler(this.btnGuzergahKayit_Click);
            // 
            // btnGuzergah
            // 
            this.btnGuzergah.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuzergah.BackColor = System.Drawing.Color.Transparent;
            this.btnGuzergah.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnGuzergah.FlatAppearance.BorderSize = 0;
            this.btnGuzergah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuzergah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuzergah.ForeColor = System.Drawing.Color.Silver;
            this.btnGuzergah.Location = new System.Drawing.Point(0, 285);
            this.btnGuzergah.Name = "btnGuzergah";
            this.btnGuzergah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGuzergah.Size = new System.Drawing.Size(14, 156);
            this.btnGuzergah.TabIndex = 39;
            this.btnGuzergah.Text = "Güzergah";
            this.btnGuzergah.UseVisualStyleBackColor = false;
            this.btnGuzergah.VisibleChanged += new System.EventHandler(this.btnGuzergah_VisibleChanged);
            this.btnGuzergah.Click += new System.EventHandler(this.btnGuzergah_Click);
            this.btnGuzergah.MouseLeave += new System.EventHandler(this.btnGuzergah_MouseLeave);
            this.btnGuzergah.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuzergah_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "label11";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 782);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuzergah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_nereden);
            this.Controls.Add(this.lbl_nereye);
            this.Controls.Add(this.btn_seferGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_nereden);
            this.Controls.Add(this.cb_nereye);
            this.Controls.Add(this.gB_guzergah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ahiret Turizm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gB_guzergah.ResumeLayout(false);
            this.gB_guzergah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_nereden;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_nereye;
        private System.Windows.Forms.Button btn_seferGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_nereye;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_nereden;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gB_guzergah;
        private System.Windows.Forms.Button btnGuzergah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuzergahKayit;
        private System.Windows.Forms.TextBox tbGuzergahDurak;
        private System.Windows.Forms.ComboBox cbGuzergahNereden;
        private System.Windows.Forms.ComboBox cbGuzergahNereye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
    }
}

