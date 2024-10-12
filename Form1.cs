using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUnosNovogStudenta
{
    public partial class Form1 : Form
    {
        private Student student1;

        public FormUnosNovogStudenta()
        {
            InitializeComponent();
            comboBoxSmjer.Items.Add("Programer");
            comboBoxSmjer.Items.Add("Sistem administrator");
            comboBoxSmjer.Items.Add("Mrežni administrator");
        }

        // Property za pristup atributu student1
        public Student Student1
        {
            get { return student1; }
            set { student1 = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student
            {
                Ime = textBoxIme.Text,
                Prezime = textBoxPrezime.Text,
                BrojIndeksa = textBoxBrojIndeksa.Text,
                Smjer = comboBoxSmjer.SelectedItem.ToString(),
                DatumRodjenja = dateTimePickerDatumRodjenja.Value
            };

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
