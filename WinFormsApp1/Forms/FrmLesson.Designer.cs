namespace WinFormsApp1.Forms
{
    partial class FrmLesson
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
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtCredit = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgLesson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 26);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(348, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 45);
            label1.TabIndex = 2;
            label1.Text = "Dersler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 128);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Kayıt No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 157);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Ders Kodu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 186);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Ders Adı";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 215);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Ders Kredisi";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(161, 23);
            txtId.TabIndex = 7;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(150, 155);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(161, 23);
            txtCode.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 23);
            txtName.TabIndex = 9;
            txtName.TextChanged += textBox3_TextChanged;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(150, 212);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(161, 23);
            txtCredit.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(62, 255);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 26);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(147, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 26);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ders Kredisi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ders Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ders Kodu";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kayıt No";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dgLesson
            // 
            dgLesson.AllowUserToAddRows = false;
            dgLesson.AllowUserToDeleteRows = false;
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column2, Column3 });
            dgLesson.Location = new Point(348, 77);
            dgLesson.Name = "dgLesson";
            dgLesson.ReadOnly = true;
            dgLesson.RowTemplate.Height = 25;
            dgLesson.Size = new Size(427, 344);
            dgLesson.TabIndex = 1;
            dgLesson.CellClick += dgLesson_CellClick;
            // 
            // FrmLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1173, 583);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtCredit);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgLesson);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLesson";
            Text = "FrmLesson";
            WindowState = FormWindowState.Maximized;
            Load += FrmLesson_Load;
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtCredit;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dgLesson;
    }
}