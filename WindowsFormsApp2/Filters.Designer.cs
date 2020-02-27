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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sostBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "ИСКАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
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
            this.nameBox1.Location = new System.Drawing.Point(97, 38);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(213, 24);
            this.nameBox1.TabIndex = 4;
            this.nameBox1.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Состояние";
            // 
            // sostBox2
            // 
            this.sostBox2.FormattingEnabled = true;
            this.sostBox2.Items.AddRange(new object[] {
            "Жив",
            "Мертв"});
            this.sostBox2.Location = new System.Drawing.Point(97, 80);
            this.sostBox2.Name = "sostBox2";
            this.sostBox2.Size = new System.Drawing.Size(213, 24);
            this.sostBox2.TabIndex = 6;
            this.sostBox2.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
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
            this.ageBox3.Location = new System.Drawing.Point(97, 120);
            this.ageBox3.Name = "ageBox3";
            this.ageBox3.Size = new System.Drawing.Size(213, 24);
            this.ageBox3.TabIndex = 8;
            this.ageBox3.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 614);
            this.Controls.Add(this.ageBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sostBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Filters";
            this.Text = "Поиск персонажа";
            this.Load += new System.EventHandler(this.Filters_Load);
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
    }
}