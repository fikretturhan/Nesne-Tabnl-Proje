using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        AppDbContext1 db = new AppDbContext1();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Students.Count(c => c.Number == txtNumber.Text) > 0)
            {
                MessageBox.Show("Girilen Öğrenci Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var student = new Student();
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhoneNumber.Text;
            student.Number = txtNumber.Text;
            student.Created = DateTime.Now;
            student.Updated = DateTime.Now;
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();

        }
        void GetStudentList()
        {
            var students = db.Students.ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var student = db.Students.Where(s => s.Id == id).SingleOrDefault();
            if (student == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhoneNumber.Text;
            student.Number = txtNumber.Text;
            student.Updated = DateTime.Now;
            db.Students.Update(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var student = db.Students.Where(s => s.Id == id).SingleOrDefault();
            if (student == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Students.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            GetStudentList();
        }
    }
}
