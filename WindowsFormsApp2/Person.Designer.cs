﻿namespace WindowsFormsApp2
{
    partial class Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person));
            this.button1 = new System.Windows.Forms.Button();
            this.persons1 = new System.Windows.Forms.PictureBox();
            this.persons2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.persons3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.persons4 = new System.Windows.Forms.PictureBox();
            this.persons5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.persons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Лань Линь Цзинь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // persons1
            // 
            this.persons1.Image = ((System.Drawing.Image)(resources.GetObject("persons1.Image")));
            this.persons1.Location = new System.Drawing.Point(17, 8);
            this.persons1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persons1.Name = "persons1";
            this.persons1.Size = new System.Drawing.Size(147, 157);
            this.persons1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.persons1.TabIndex = 1;
            this.persons1.TabStop = false;
            this.persons1.Tag = "Лань Линь Цзинь";
            this.persons1.Click += new System.EventHandler(this.persons1_Click);
            // 
            // persons2
            // 
            this.persons2.Image = ((System.Drawing.Image)(resources.GetObject("persons2.Image")));
            this.persons2.Location = new System.Drawing.Point(190, 102);
            this.persons2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persons2.Name = "persons2";
            this.persons2.Size = new System.Drawing.Size(147, 157);
            this.persons2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.persons2.TabIndex = 2;
            this.persons2.TabStop = false;
            this.persons2.Click += new System.EventHandler(this.persons2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Юн Мэн Цзян";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // persons3
            // 
            this.persons3.Image = ((System.Drawing.Image)(resources.GetObject("persons3.Image")));
            this.persons3.Location = new System.Drawing.Point(365, 11);
            this.persons3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persons3.Name = "persons3";
            this.persons3.Size = new System.Drawing.Size(147, 155);
            this.persons3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.persons3.TabIndex = 4;
            this.persons3.TabStop = false;
            this.persons3.Click += new System.EventHandler(this.persons3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(365, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 20);
            this.button3.TabIndex = 5;
            this.button3.Text = "Гу Су Лань";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 365);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 20);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ци Шань Вэнь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 365);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 20);
            this.button5.TabIndex = 7;
            this.button5.Text = "Цин Хэ Нэ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // persons4
            // 
            this.persons4.Image = ((System.Drawing.Image)(resources.GetObject("persons4.Image")));
            this.persons4.Location = new System.Drawing.Point(17, 197);
            this.persons4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persons4.Name = "persons4";
            this.persons4.Size = new System.Drawing.Size(147, 157);
            this.persons4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.persons4.TabIndex = 8;
            this.persons4.TabStop = false;
            this.persons4.Click += new System.EventHandler(this.persons4_Click);
            // 
            // persons5
            // 
            this.persons5.Image = ((System.Drawing.Image)(resources.GetObject("persons5.Image")));
            this.persons5.Location = new System.Drawing.Point(365, 199);
            this.persons5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persons5.Name = "persons5";
            this.persons5.Size = new System.Drawing.Size(147, 155);
            this.persons5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.persons5.TabIndex = 9;
            this.persons5.TabStop = false;
            this.persons5.Click += new System.EventHandler(this.persons5_Click);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 405);
            this.Controls.Add(this.persons5);
            this.Controls.Add(this.persons4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.persons3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.persons2);
            this.Controls.Add(this.persons1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Person";
            this.Text = "ВЫБЕРИ КЛАН ПЕРСОНАЖА";
            this.Load += new System.EventHandler(this.Person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.persons1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox persons1;
        private System.Windows.Forms.PictureBox persons2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox persons3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox persons4;
        private System.Windows.Forms.PictureBox persons5;
    }
}