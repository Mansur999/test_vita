using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_task_vita
{
    public partial class visitFormInput : Form
    {
        Db db;
        public visitFormInput()
        {
            InitializeComponent();
            db = new Db();
        }

        private void visitFormMkbInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://normativ.kontur.ru/document?moduleId=1&documentId=71591#h2976");
        }


        //закрытие формы
        private void visitFormBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        //добавление записи в бд в таблицу visit
        private void visitFormAdd_Click(object sender, EventArgs e)
        {
            clearColor();
            if (checkTextBox())
            {
                DateTime date = DateTime.Parse(visitFormDate.Text);

                SqlCommand command = new SqlCommand(
                    $"INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES (@id,@date_visit,@diagnosis,@id_patient);", db.getConnection());
                command.Parameters.AddWithValue("id", visitFormId.Text);
                command.Parameters.AddWithValue("date_visit", $"{date.Year}-{date.Month}-{date.Day}");
                command.Parameters.AddWithValue("diagnosis", visitFormMkb.Text);
                command.Parameters.AddWithValue("id_patient", visitFormId_patient.Text);
                db.openConnection();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись добавилась");
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при добавлении");
                }
                clearTextBox();
            }
        }


        //проверка на null полей
        private bool checkTextBox()
        {
            if (visitFormId.Text == "")
            {
                MessageBox.Show("Поле ID не заполнено");
                label1.ForeColor = Color.Red;
                return false;
            }
            if (visitFormMkb.Text == "")
            {
                MessageBox.Show("Поле Диагноз не заполнено");
                label1.ForeColor = Color.Red;
                return false;
            }
            if (visitFormId_patient.Text == "")
            {
                MessageBox.Show("Поле ID пациента не заполнено");
                label1.ForeColor = Color.Red;
                return false;
            }
            return true;
        }


        //очистка полей
        private void clearTextBox()
        {
            visitFormId.Text = "";
            visitFormMkb.Text = "";
            visitFormId_patient.Text = "";
        }


        //изменение цвета полей обратно в черный
        private void clearColor()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }


        //заполнения combobox данными о пациентах
        private void visitFormInput_Load(object sender, EventArgs e)
        {        
            visitFormId_patient.DataSource = db.getDataSet().Tables[0];
            visitFormId_patient.DisplayMember = "id";
            visitFormId_patient.ValueMember = "id";
        }


        //открытие формы с данными о пациентах
        private void visitFormIdPacient_Click(object sender, EventArgs e)
        {
            Patient_input form = new Patient_input();
            form.Show();
        }
    }
}
