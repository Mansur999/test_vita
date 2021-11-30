using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_task_vita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visitFormInput form1 = new visitFormInput();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_input form = new Patient_input();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outPatient form2 = new outPatient();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outVisitByPatient form3 = new outVisitByPatient();
            form3.Show();
        }
    }
}
