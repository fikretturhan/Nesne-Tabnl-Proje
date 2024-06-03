namespace WinFormsApp1.Forms
{
    partial class FrmStudent
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
            btnSave = new Button();
            txtId = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtNumber = new TextBox();
            txtPhoneNumber = new TextBox();
            dgStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(14, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 25);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 101);
            txtId.Name = "txtId";
            txtId.Size = new Size(151, 23);
            txtId.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 312);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 25);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(192, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 25);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(100, 142);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(151, 23);
            txtNumber.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(100, 258);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(151, 23);
            txtPhoneNumber.TabIndex = 9;
            // 
            // dgStudent
            // 
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgStudent.Location = new Point(281, 44);
            dgStudent.Name = "dgStudent";
            dgStudent.RowTemplate.Height = 25;
            dgStudent.Size = new Size(446, 381);
            dgStudent.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "ÖğrNo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ad Soyad";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "E-Posta";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 109);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 11;
            label1.Text = "Kayıt No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 150);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 12;
            label2.Text = "Öğrenci No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 188);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Ad Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 227);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 14;
            label4.Text = "E-Posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 266);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 44);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 16;
            label6.Text = "Öğrenciler";
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1052, 603);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgStudent);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudent";
            Text = "FrmStudent";
            WindowState = FormWindowState.Maximized;
            Load += FrmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtId;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtNumber;
        private TextBox txtPhoneNumber;
        private DataGridView dgStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}