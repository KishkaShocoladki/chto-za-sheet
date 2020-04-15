namespace WindowsFormsApp2
{
    partial class Filters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sostBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.неСмотриСюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "ИСКАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // nameBox1
            // 
            this.nameBox1.FormattingEnabled = true;
            this.nameBox1.Items.AddRange(new object[] {
            "Цзинь Гуанъяо",
            "Цзинь Гуань Шань",
            "Цзян Фэн Мянь",
            "Цзян Чэн",
            "Вей Усянь",
            "Лань Ван Цзы",
            "Вэнь Жо Хань",
            "Не Хуай Сан",
            "Не Мин Цзюэ",
            "Лань Сичень"});
            this.nameBox1.Location = new System.Drawing.Point(73, 31);
            this.nameBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(161, 21);
            this.nameBox1.TabIndex = 4;
            this.nameBox1.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Состояние";
            // 
            // sostBox2
            // 
            this.sostBox2.FormattingEnabled = true;
            this.sostBox2.Items.AddRange(new object[] {
            "Жив",
            "Мертв"});
            this.sostBox2.Location = new System.Drawing.Point(73, 65);
            this.sostBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sostBox2.Name = "sostBox2";
            this.sostBox2.Size = new System.Drawing.Size(161, 21);
            this.sostBox2.TabIndex = 6;
            this.sostBox2.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // ageBox3
            // 
            this.ageBox3.FormattingEnabled = true;
            this.ageBox3.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.ageBox3.Location = new System.Drawing.Point(73, 98);
            this.ageBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageBox3.Name = "ageBox3";
            this.ageBox3.Size = new System.Drawing.Size(161, 21);
            this.ageBox3.TabIndex = 8;
            this.ageBox3.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ДЖОТАРО, ТЫ ЛЮБИШЬ КАБАЧЬКИ?";
            this.label5.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.неСмотриСюдаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 26);
            // 
            // неСмотриСюдаToolStripMenuItem
            // 
            this.неСмотриСюдаToolStripMenuItem.Name = "неСмотриСюдаToolStripMenuItem";
            this.неСмотриСюдаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.неСмотриСюдаToolStripMenuItem.Text = "НЕ ЛЕЗЬ пожалуйста";
            this.неСмотриСюдаToolStripMenuItem.Click += new System.EventHandler(this.неСмотриСюдаToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(422, 499);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ageBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sostBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Filters";
            this.Text = "Поиск персонажа";
            this.Load += new System.EventHandler(this.Filters_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nameBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sostBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ageBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem неСмотриСюдаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}