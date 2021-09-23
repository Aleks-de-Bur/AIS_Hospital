using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Hosp
{
    struct Data
    {
        public string doctor;
        public string mon;
        public string tue;
        public string wed;
        public string thu;
        public string fri;
        public string ss;
        public string patient;
        public string age;
        public string diagnosis;
        public string chamber;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(tbDoc.Text, tbMon.Text, tbTues.Text, tbWen.Text, tbThur.Text, tbFr.Text, tbSun.Text);
        }

        private void BtnRedPat_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void BtnDelPat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.CreateXmlDeclaration("1.0", "windows-1251", "no");

            XmlElement xRoot = xDoc.CreateElement("Data");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                XmlElement data = xDoc.CreateElement("data");

                XmlElement doctor = xDoc.CreateElement("doctor");
                doctor.InnerText = row.Cells[0].Value.ToString();
                data.AppendChild(doctor);

                XmlElement mon = xDoc.CreateElement("mon");
                mon.InnerText = row.Cells[1].Value.ToString();
                data.AppendChild(mon);

                XmlElement tue = xDoc.CreateElement("tue");
                tue.InnerText = row.Cells[2].Value.ToString();
                data.AppendChild(tue);

                XmlElement wed = xDoc.CreateElement("wed");
                wed.InnerText = row.Cells[3].Value.ToString();
                data.AppendChild(wed);

                XmlElement thu = xDoc.CreateElement("thu");
                thu.InnerText = row.Cells[4].Value.ToString();
                data.AppendChild(thu);

                XmlElement fri = xDoc.CreateElement("fri");
                fri.InnerText = row.Cells[5].Value.ToString();
                data.AppendChild(fri);

                XmlElement ss = xDoc.CreateElement("ss");
                ss.InnerText = row.Cells[6].Value.ToString();
                data.AppendChild(ss);

                XmlElement patient = xDoc.CreateElement("patient");
                patient.InnerText = row.Cells[0].Value.ToString();
                data.AppendChild(patient);

                XmlElement age = xDoc.CreateElement("age");
                age.InnerText = row.Cells[1].Value.ToString();
                data.AppendChild(age);

                XmlElement diagnosis = xDoc.CreateElement("diagnosis");
                diagnosis.InnerText = row.Cells[2].Value.ToString();
                data.AppendChild(diagnosis);

                XmlElement chamber = xDoc.CreateElement("chamber");
                chamber.InnerText = row.Cells[3].Value.ToString();
                data.AppendChild(chamber);

                xRoot.AppendChild(data);
            }

            xDoc.AppendChild(xRoot);
            xDoc.Save(Directory.GetCurrentDirectory() + @"/data.xml");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(tbPatient.Text, tbAge.Text, tbDiag.Text, tbNumb.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
