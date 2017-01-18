using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checking_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string country= textBoxCountry.Text;
            string name = textBoxName.Text;
            string surname1 = textBoxSurname1.Text;
            string surname2 = textBoxSurname2.Text;
            string id = textBoxNumber.Text;
            string sex = comboBoxSex.Text;
            string documentTipe = comboBoxDocumentTipe.Text;
            string fechIn = dateTimePickerIn.Value.ToString("YYYY/mm/dd");
            string birth = dateTimePickerBirth.Value.ToString("YYYY/mm/dd");
            string fechExp = dateTimePickerExpedition.Value.ToString("YYYY/mm/dd");
            string formatString = "2||" + id + "|" + documentTipe + "|" + fechExp +"|"+ surname1 + "|" + surname2 + "|" + name + "|" +
                "|" + sex + "|" + birth + "|" + country.ToUpper() + "|" + fechIn + "|\n";
            //Save string in TXT
            System.IO.File.AppendAllText(@"C:\Users\david\Desktop\register.txt", formatString);
            
        }
    }

}
