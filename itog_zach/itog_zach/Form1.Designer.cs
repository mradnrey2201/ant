namespace itog_zach
{
    partial class frm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_kolvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gruzopod = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.dgv_coord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_kolvovar = new System.Windows.Forms.Label();
            this.dgv_killog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rasstoyanie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_tochki = new System.Windows.Forms.Button();
            this.btn_simple = new System.Windows.Forms.Button();
            this.lbl_simple = new System.Windows.Forms.Label();
            this.btn_ant = new System.Windows.Forms.Button();
            this.lbl_hard = new System.Windows.Forms.Label();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.picturebox1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_killog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rasstoyanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kolvo
            // 
            this.txt_kolvo.Location = new System.Drawing.Point(12, 23);
            this.txt_kolvo.Name = "txt_kolvo";
            this.txt_kolvo.Size = new System.Drawing.Size(100, 20);
            this.txt_kolvo.TabIndex = 0;
            this.txt_kolvo.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во точек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Грузоподъемность";
            // 
            // txt_gruzopod
            // 
            this.txt_gruzopod.Location = new System.Drawing.Point(11, 67);
            this.txt_gruzopod.Name = "txt_gruzopod";
            this.txt_gruzopod.Size = new System.Drawing.Size(100, 20);
            this.txt_gruzopod.TabIndex = 4;
            this.txt_gruzopod.Text = "25";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0,5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(36, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(28, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во иттераций";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alpha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Beta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "----------------------------------------";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(3, 285);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(86, 23);
            this.btn_enter.TabIndex = 17;
            this.btn_enter.Text = "Ввод данных";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // dgv_coord
            // 
            this.dgv_coord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_coord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_coord.Location = new System.Drawing.Point(145, 23);
            this.dgv_coord.Name = "dgv_coord";
            this.dgv_coord.Size = new System.Drawing.Size(134, 136);
            this.dgv_coord.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "y";
            this.Column2.Name = "Column2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Кол-во вариантов маршрута:";
            // 
            // lbl_kolvovar
            // 
            this.lbl_kolvovar.AutoSize = true;
            this.lbl_kolvovar.Location = new System.Drawing.Point(156, 355);
            this.lbl_kolvovar.Name = "lbl_kolvovar";
            this.lbl_kolvovar.Size = new System.Drawing.Size(0, 13);
            this.lbl_kolvovar.TabIndex = 20;
            // 
            // dgv_killog
            // 
            this.dgv_killog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_killog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_killog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgv_killog.Location = new System.Drawing.Point(285, 23);
            this.dgv_killog.Name = "dgv_killog";
            this.dgv_killog.Size = new System.Drawing.Size(104, 136);
            this.dgv_killog.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "kg";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgv_rasstoyanie
            // 
            this.dgv_rasstoyanie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rasstoyanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rasstoyanie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgv_rasstoyanie.Location = new System.Drawing.Point(145, 165);
            this.dgv_rasstoyanie.Name = "dgv_rasstoyanie";
            this.dgv_rasstoyanie.Size = new System.Drawing.Size(379, 150);
            this.dgv_rasstoyanie.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "a";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btn_tochki
            // 
            this.btn_tochki.Location = new System.Drawing.Point(2, 314);
            this.btn_tochki.Name = "btn_tochki";
            this.btn_tochki.Size = new System.Drawing.Size(97, 22);
            this.btn_tochki.TabIndex = 26;
            this.btn_tochki.Text = "Показать точки";
            this.btn_tochki.UseVisualStyleBackColor = true;
            this.btn_tochki.Click += new System.EventHandler(this.btn_tochki_Click);
            // 
            // btn_simple
            // 
            this.btn_simple.Location = new System.Drawing.Point(416, 326);
            this.btn_simple.Name = "btn_simple";
            this.btn_simple.Size = new System.Drawing.Size(108, 23);
            this.btn_simple.TabIndex = 27;
            this.btn_simple.Text = "Простое решение";
            this.btn_simple.UseVisualStyleBackColor = true;
            this.btn_simple.Click += new System.EventHandler(this.btn_simple_Click);
            // 
            // lbl_simple
            // 
            this.lbl_simple.AutoSize = true;
            this.lbl_simple.Location = new System.Drawing.Point(60, 401);
            this.lbl_simple.Name = "lbl_simple";
            this.lbl_simple.Size = new System.Drawing.Size(70, 13);
            this.lbl_simple.TabIndex = 28;
            this.lbl_simple.Text = "Счет руками";
            // 
            // btn_ant
            // 
            this.btn_ant.Location = new System.Drawing.Point(395, 355);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(129, 23);
            this.btn_ant.TabIndex = 29;
            this.btn_ant.Text = "Не простое решение";
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // lbl_hard
            // 
            this.lbl_hard.AutoSize = true;
            this.lbl_hard.Location = new System.Drawing.Point(61, 441);
            this.lbl_hard.Name = "lbl_hard";
            this.lbl_hard.Size = new System.Drawing.Size(95, 13);
            this.lbl_hard.TabIndex = 30;
            this.lbl_hard.Text = "Счет алгоритмом";
            // 
            // pic_home
            // 
            this.pic_home.BackColor = System.Drawing.Color.Transparent;
            this.pic_home.BackgroundImage = global::itog_zach.Properties.Resources.point;
            this.pic_home.Image = global::itog_zach.Properties.Resources._70166;
            this.pic_home.Location = new System.Drawing.Point(487, 4);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(70, 50);
            this.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_home.TabIndex = 24;
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // picturebox1
            // 
            this.picturebox1.BackgroundImage = global::itog_zach.Properties.Resources.rgarwgawegwa;
            this.picturebox1.Location = new System.Drawing.Point(530, 12);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(1072, 479);
            this.picturebox1.TabIndex = 32;
            this.picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picturebox1_Paint);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 739);
            this.Controls.Add(this.pic_home);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.lbl_hard);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.lbl_simple);
            this.Controls.Add(this.btn_simple);
            this.Controls.Add(this.btn_tochki);
            this.Controls.Add(this.dgv_rasstoyanie);
            this.Controls.Add(this.dgv_killog);
            this.Controls.Add(this.lbl_kolvovar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_coord);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_gruzopod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kolvo);
            this.Name = "frm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_killog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rasstoyanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kolvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gruzopod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.DataGridView dgv_coord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_kolvovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgv_killog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgv_rasstoyanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Button btn_tochki;
        private System.Windows.Forms.Button btn_simple;
        private System.Windows.Forms.Label lbl_simple;
        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Label lbl_hard;
        private System.Windows.Forms.Panel picturebox1;
    }
}

