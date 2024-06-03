namespace WinFormsApp1.Forms
{
    partial class FrmRegister
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
            dgStudentLesson = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dgLessonStudent = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtSearchStudent = new TextBox();
            label3 = new Label();
            txtSearchLesson = new TextBox();
            dgStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dgLesson = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // dgStudentLesson
            // 
            dgStudentLesson.AllowUserToAddRows = false;
            dgStudentLesson.AllowUserToDeleteRows = false;
            dgStudentLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudentLesson.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dgStudentLesson.Location = new Point(691, 332);
            dgStudentLesson.Name = "dgStudentLesson";
            dgStudentLesson.ReadOnly = true;
            dgStudentLesson.RowHeadersWidth = 62;
            dgStudentLesson.RowTemplate.Height = 33;
            dgStudentLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudentLesson.Size = new Size(551, 213);
            dgStudentLesson.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Id";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Ders Kodu";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Ders Adı";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Kredi";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dgLessonStudent
            // 
            dgLessonStudent.AllowUserToAddRows = false;
            dgLessonStudent.AllowUserToDeleteRows = false;
            dgLessonStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLessonStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgLessonStudent.Location = new Point(5, 332);
            dgLessonStudent.Name = "dgLessonStudent";
            dgLessonStudent.ReadOnly = true;
            dgLessonStudent.RowHeadersWidth = 62;
            dgLessonStudent.RowTemplate.Height = 33;
            dgLessonStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLessonStudent.Size = new Size(667, 213);
            dgLessonStudent.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Öğr.No";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Telefon";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1017, 74);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 63;
            label4.Text = "Arama";
            label4.Click += label4_Click;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(1065, 69);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(176, 23);
            txtSearchStudent.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 72);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 61;
            label3.Text = "Arama";
            // 
            // txtSearchLesson
            // 
            txtSearchLesson.Location = new Point(367, 66);
            txtSearchLesson.Name = "txtSearchLesson";
            txtSearchLesson.Size = new Size(176, 23);
            txtSearchLesson.TabIndex = 60;
            // 
            // dgStudent
            // 
            dgStudent.AllowUserToAddRows = false;
            dgStudent.AllowUserToDeleteRows = false;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgStudent.Location = new Point(573, 98);
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            dgStudent.RowHeadersWidth = 62;
            dgStudent.RowTemplate.Height = 33;
            dgStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudent.Size = new Size(669, 215);
            dgStudent.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Öğr.No";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(573, 54);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 58;
            label1.Text = "Öğrenciler";
            label1.Click += label1_Click;
            // 
            // dgLesson
            // 
            dgLesson.AllowUserToAddRows = false;
            dgLesson.AllowUserToDeleteRows = false;
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgLesson.Location = new Point(5, 98);
            dgLesson.Name = "dgLesson";
            dgLesson.ReadOnly = true;
            dgLesson.RowHeadersWidth = 62;
            dgLesson.RowTemplate.Height = 33;
            dgLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLesson.Size = new Size(538, 215);
            dgLesson.TabIndex = 57;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ders Kodu";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ders Adı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kredi";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 54);
            label2.Name = "label2";
            label2.Size = new Size(109, 37);
            label2.TabIndex = 56;
            label2.Text = "Dersler";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(5, 551);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 32);
            btnRegister.TabIndex = 66;
            btnRegister.Text = "Ders Kaydı Yap";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1245, 585);
            Controls.Add(btnRegister);
            Controls.Add(dgStudentLesson);
            Controls.Add(dgLessonStudent);
            Controls.Add(label4);
            Controls.Add(txtSearchStudent);
            Controls.Add(label3);
            Controls.Add(txtSearchLesson);
            Controls.Add(dgStudent);
            Controls.Add(label1);
            Controls.Add(dgLesson);
            Controls.Add(label2);
            Name = "FrmRegister";
            Text = "FrmRegister";
            WindowState = FormWindowState.Maximized;
            Load += FrmRegister_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgStudentLesson;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridView dgLessonStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Label label4;
        private TextBox txtSearchStudent;
        private Label label3;
        private TextBox txtSearchLesson;
        private DataGridView dgStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private DataGridView dgLesson;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private Button btnRegister;
    }
}