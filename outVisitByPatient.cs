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
using System.Xml;

namespace test_task_vita
{
    public partial class outVisitByPatient : Form
    {
        Db db;
        List<string[]> dataVisits;
        string sqlFromVisit;
        string sqlIdPatient;
        public outVisitByPatient()
        {
            InitializeComponent();
            db = new Db();
        }


        //при загрузве формы заполнение comboBox 
        private void outVisitByPatient_Load(object sender, EventArgs e)
        {
            outVisitComboBox.DataSource = db.getDataSet().Tables[0];
            outVisitComboBox.DisplayMember = "id";
            outVisitComboBox.ValueMember = "id";
            outVisitExportXml.Enabled = false;
        }


        //заполнение dataGrid визитами по пациенту
        private void fillGrid(string idPatient)
        {
            sqlFromVisit = $"select * from visit where id_patient = '{idPatient}'";
            dataGridView1.Rows.Clear();
            dataVisits = db.getDataVisit(sqlFromVisit);
            if (dataVisits.Count==0)
            {
                MessageBox.Show("У данного пациента нет посещений");
                outVisitExportXml.Enabled = false;
            }
            else
            {
                foreach (string[] s in dataVisits)
                    dataGridView1.Rows.Add(s);
                outVisitExportXml.Enabled = true;
            }         
        }


        //Кнопка для вызова fillGrid()
        private void outVisitViewing_Click(object sender, EventArgs e)
        {
            sqlIdPatient = outVisitComboBox.Text.ToString();
            fillGrid(sqlIdPatient);
        }


        //кнопка для вызова newXml()
        private void outVisitExportXml_Click(object sender, EventArgs e)
        {
            newXml(db.getDataPatient($"select * from patient where id = '{sqlIdPatient}'"));
        }


        //вывод данных в xml файл
        private void newXml(List<string[]> dataPatient)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement item = xDoc.CreateElement("item");
            //создание элемента patient
            XmlElement patientElem = xDoc.CreateElement("patient");
            XmlAttribute patientnameAttr = xDoc.CreateAttribute("id");

            //создание дочерних элементов patient
            XmlElement surnametElem = xDoc.CreateElement("surname");
            XmlElement nameElem = xDoc.CreateElement("name");
            XmlElement birthdayElem = xDoc.CreateElement("birthday");
            XmlElement phoneElem = xDoc.CreateElement("phone");
            XmlElement dadnameElem = xDoc.CreateElement("dadname");

            //создание текстовых элементов 
            XmlText idPatientText = xDoc.CreateTextNode(dataPatient[0][0]);
            XmlText surnameText = xDoc.CreateTextNode(dataPatient[0][1]);
            XmlText nameText = xDoc.CreateTextNode(dataPatient[0][2]);
            XmlText dadnameText = xDoc.CreateTextNode(dataPatient[0][3]);
            XmlText birthdayText = xDoc.CreateTextNode(dataPatient[0][4]);
            XmlText phoneText = xDoc.CreateTextNode(dataPatient[0][5]);

            //создание элемента visits 
            XmlElement visitsElem = xDoc.CreateElement("visits");

            //создание элемента visit дочернего от visits
            XmlElement visitElem;
            XmlAttribute visitsnameAttr;

            //создание дочерних элементов visit
            XmlElement date_visitElem;
            XmlElement diagnosisElem;
            XmlElement id_patientElem;

            //Создание текстовых элементов visit
            XmlText idVisitText;
            XmlText date_visitText;
            XmlText diagnosisText;
            XmlText id_patientText;

            //добавляем узлы для patient
            patientnameAttr.AppendChild(idPatientText);
            patientElem.Attributes.Append(patientnameAttr);

            surnametElem.AppendChild(surnameText);
            nameElem.AppendChild(nameText);
            birthdayElem.AppendChild(birthdayText);
            phoneElem.AppendChild(phoneText);
            dadnameElem.AppendChild(dadnameText);

            patientElem.AppendChild(surnametElem);
            patientElem.AppendChild(nameElem);
            patientElem.AppendChild(dadnameElem);
            patientElem.AppendChild(birthdayElem);
            patientElem.AppendChild(phoneElem);

            //добавляем узлы для visits
            //создание текстовых элементов 
            ///
            foreach (string[] s in dataVisits)
            {
                //создание текстовых перемнных visit
                idVisitText = xDoc.CreateTextNode(s[0]);
                date_visitText = xDoc.CreateTextNode(s[1]);
                diagnosisText = xDoc.CreateTextNode(s[2]);
                id_patientText = xDoc.CreateTextNode(s[3]);

                //создание visit
                visitElem = xDoc.CreateElement("visit");
                visitsnameAttr = xDoc.CreateAttribute("id");

                //создание дочерних элементов visit
                date_visitElem = xDoc.CreateElement("date__visit");
                diagnosisElem = xDoc.CreateElement("diagnosis");
                id_patientElem = xDoc.CreateElement("id__patient");

                //заполнение visit
                visitsnameAttr.AppendChild(idVisitText);
                visitElem.Attributes.Append(visitsnameAttr);

                date_visitElem.AppendChild(date_visitText);
                diagnosisElem.AppendChild(diagnosisText);
                id_patientElem.AppendChild(id_patientText);

                visitElem.AppendChild(date_visitElem);
                visitElem.AppendChild(diagnosisElem);
                visitElem.AppendChild(id_patientElem);

                //добавление visit
                visitsElem.AppendChild(visitElem);
            }

            //добавлениев корень инф.
            item.AppendChild(patientElem);
            item.AppendChild(visitsElem);
            xDoc.AppendChild(item);
            xDoc.Save("patient.xml");
        }
    }
}
