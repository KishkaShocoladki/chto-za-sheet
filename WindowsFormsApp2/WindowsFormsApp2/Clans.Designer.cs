namespace WindowsFormsApp2
{
    partial class Clans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clans));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clan1 = new System.Windows.Forms.PictureBox();
            this.clan3 = new System.Windows.Forms.PictureBox();
            this.clan2 = new System.Windows.Forms.PictureBox();
            this.clan5 = new System.Windows.Forms.PictureBox();
            this.clan4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Лань Линь Цзинь";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Гу Су Лань";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(465, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "Цин Хэ Нэ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Юн Мэн Цзян";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ци Шань Вэнь";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // clan1
            // 
            this.clan1.Image = ((System.Drawing.Image)(resources.GetObject("clan1.Image")));
            this.clan1.Location = new System.Drawing.Point(22, 12);
            this.clan1.Name = "clan1";
            this.clan1.Size = new System.Drawing.Size(159, 158);
            this.clan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clan1.TabIndex = 5;
            this.clan1.TabStop = false;
            this.clan1.Click += new System.EventHandler(this.clan1_Click);
            // 
            // clan3
            // 
            this.clan3.Image = ((System.Drawing.Image)(resources.GetObject("clan3.Image")));
            this.clan3.Location = new System.Drawing.Point(618, 12);
            this.clan3.Name = "clan3";
            this.clan3.Size = new System.Drawing.Size(159, 158);
            this.clan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clan3.TabIndex = 6;
            this.clan3.TabStop = false;
            // 
            // clan2
            // 
            this.clan2.Image = ((System.Drawing.Image)(resources.GetObject("clan2.Image")));
            this.clan2.Location = new System.Drawing.Point(314, 12);
            this.clan2.Name = "clan2";
            this.clan2.Size = new System.Drawing.Size(159, 158);
            this.clan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clan2.TabIndex = 7;
            this.clan2.TabStop = false;
            // 
            // clan5
            // 
            this.clan5.Image = ((System.Drawing.Image)(resources.GetObject("clan5.Image")));
            this.clan5.Location = new System.Drawing.Point(465, 236);
            this.clan5.Name = "clan5";
            this.clan5.Size = new System.Drawing.Size(159, 158);
            this.clan5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clan5.TabIndex = 8;
            this.clan5.TabStop = false;
            // 
            // clan4
            // 
            this.clan4.Image = ((System.Drawing.Image)(resources.GetObject("clan4.Image")));
            this.clan4.Location = new System.Drawing.Point(170, 236);
            this.clan4.Name = "clan4";
            this.clan4.Size = new System.Drawing.Size(159, 158);
            this.clan4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clan4.TabIndex = 9;
            this.clan4.TabStop = false;
            // 
            // Clans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clan4);
            this.Controls.Add(this.clan5);
            this.Controls.Add(this.clan2);
            this.Controls.Add(this.clan3);
            this.Controls.Add(this.clan1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Clans";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.clan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox clan1;
        private System.Windows.Forms.PictureBox clan3;
        private System.Windows.Forms.PictureBox clan2;
        private System.Windows.Forms.PictureBox clan5;
        private System.Windows.Forms.PictureBox clan4;
    }
}