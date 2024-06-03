namespace WinFormsApp1.Forms
{
    partial class Frmmain
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
            panel1 = new Panel();
            btnRegister = new Button();
            btnExit = new Button();
            btnLesson = new Button();
            btnStudent = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLesson);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 711);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(39, 296);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(127, 33);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Kayıt";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(39, 374);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLesson
            // 
            btnLesson.Location = new Point(39, 257);
            btnLesson.Name = "btnLesson";
            btnLesson.Size = new Size(127, 33);
            btnLesson.TabIndex = 3;
            btnLesson.Text = "Dersler";
            btnLesson.UseVisualStyleBackColor = true;
            btnLesson.Click += btnLesson_Click;
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(39, 218);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(127, 33);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Öğrenciler";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(261, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 147);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(202, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 578);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 255, 128);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(202, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1131, 133);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 61);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ TAKİP PROGRAMI";
            // 
            // Frmmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 711);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmmain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmmain";
            WindowState = FormWindowState.Maximized;
            Load += Frmmain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLesson;
        private Button btnStudent;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button btnRegister;
    }
}