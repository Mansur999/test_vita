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
    public partial class outPatient : Form
    {
        Db db;
        string sql;
        SqlCommand command;
        SqlDataReader reader;
        List<string[]> data;
        public outPatient()
        {
            InitializeComponent();
            db = new Db();
        }


        //заполнение dataGrid данными о пациентах
        private void outPatient_Load(object sender, EventArgs e)
        {
            sql = "select * from patient";
            fillGrid(sql);
        }


        // закрытие формы
        private void outPatientBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        //функция получение сортированных данных в dataGrid
        private void outPatientSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            switch (outPatientComboBox.SelectedIndex)
            {
                case 0:
                    sql = "select * from patient order by id";
                    break;
                case 1:
                    sql = "select * from patient order by surname";
                    break;
                case 2:
                    sql = "select * from patient order by name";
                    break;
                case 3:
                    sql = "select * from patient order by dadname";
                    break;
                case 4:
                    sql = "select * from patient order by birthday";
                    break;
                case 5:
                    sql = "select * from patient order by phone";
                    break;
            }
            fillGrid(sql);
        }


        //функция заполнение dataGrid
        private void fillGrid(string sql)
        {
            List<string[]> data = db.getDataPatient(sql);
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
