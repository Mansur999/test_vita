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
    public partial class Patient_input : Form
    {
        Db db;
        public Patient_input()
        {
            InitializeComponent();
            db = new Db();
        }


        //добавление записи в бд в таблицу patient
        private void patient_inputAdd_Click(object sender, EventArgs e)
        {
            clearColor();
            if (checkTextBox())
            {
                
                DateTime date = DateTime.Parse(patient_inputData.Text);
                SqlCommand command = new SqlCommand($"INSERT INTO patient (id,surname,name,dad_name,birthday,phone) " +
                    $"VALUES (@id,@surname,@name,@dad_name,@birthday,@phone)", db.getConnection());
                command.Parameters.AddWithValue("id", patient_inputID.Text);
                command.Parameters.AddWithValue("surname", patient_inputSurname.Text);
                command.Parameters.AddWithValue("name", patient_inputName.Text);
                command.Parameters.AddWithValue("dad_name", patient_inputDadname.Text);
                command.Parameters.AddWithValue("birthday", $"{date.Year}-{date.Month}-{date.Day}");
                command.Parameters.AddWithValue("phone", patient_inputPhone.Text);
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
            if(patient_inputID.Text == "") { 
                MessageBox.Show("Поле ID не заполнено");
                label1.ForeColor = Color.Red;
                return false;
            }
            if (patient_inputSurname.Text == "")
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                label2.ForeColor = Color.Red;
                return false;
            }
            if (patient_inputName.Text == "")
            {
                MessageBox.Show("Поле Имя не заполнено");
                label3.ForeColor = Color.Red;
                return false;
            }
            if (patient_inputDadname.Text == "")
            {
                MessageBox.Show("Поле Отчество не заполнено");
                label4.ForeColor = Color.Red;
                return false;
            }
            if (patient_inputPhone.Text == "")
            {
                MessageBox.Show("Поле Телефон не заполнено");
                label6.ForeColor = Color.Red;
                return false;
            }
            return true;
        }


        //очистка полей
        private void clearTextBox()
        {
            patient_inputID.Text = "";
            patient_inputSurname.Text = "";
            patient_inputName.Text = "";
            patient_inputDadname.Text = "";
            patient_inputPhone.Text = "";
        }


        //изменение цвета полей обратно в черный
        private void clearColor()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
        }


        //закрытие формы
        private void patient_inputBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
