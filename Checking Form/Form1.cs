﻿using System;
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
    using Excel = Microsoft.Office.Interop.Excel;
    public partial class Form1 : Form
    {
        Excel.Application objApp;
        Excel._Workbook objBook;
        public Form1()
        {
            InitializeComponent();
        }
        

        //Boton de Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            //Save string in TXT
            addToRegister(readValues());

        }

        //Boton de Imprimir y guardar
        private void button2_Click(object sender, EventArgs e)
        {
            //Save string in TXT
            addToRegister(readValues());
            //Print
            printDocument1.Print();
        }

        // Función encargada de leer los datos del formulario y devolverlos como una cadena.
        public string readValues()
        {
            string country = textBoxCountry.Text;
            string name = textBoxName.Text;
            string surname1 = textBoxSurname1.Text;
            string surname2 = textBoxSurname2.Text;
            string id = textBoxNumber.Text;
            string sex = comboBoxSex.Text;
            string documentTipe = comboBoxDocumentTipe.Text;
            string fechIn = dateTimePickerIn.Value.ToString("YYYY/mm/dd");
            string birth = dateTimePickerBirth.Value.ToString("YYYY/mm/dd");
            string fechExp = dateTimePickerExpedition.Value.ToString("YYYY/mm/dd");
            dataGridInfo.Rows.Add(name, surname1, surname2, birth, sex, documentTipe, id, fechExp, country, fechIn);
            return "2||" + id + "|" + documentTipe + "|" + fechExp + "|" + surname1 + "|" + surname2 + "|" + name + "|" +
                "|" + sex + "|" + birth + "|" + country.ToUpper() + "|" + fechIn + "|"+Environment.NewLine;
        }

        // Función encargada de guardar en el registro (fichero TXT) una cadena.
        public void addToRegister(string reg)
        {
            System.IO.File.AppendAllText(@"C:\Users\david\Desktop\register.txt", reg);
        }
      
        // Función encargada de guardar los parámetros del formulario en un Excel.
       /* public void addToExcel()
        {
            Excel.Workbooks objBooks;
            Excel.Sheets objSheets;
            Excel.Worksheet objSheet;
            Excel.Range range;
            try
            {
                // Iniciar excel y empezar un nuevo libro de trabajo.
                objApp = new Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add();
                objSheets = objBook.Worksheets;

            }
            catch { }
        }*/

        
       
    }

}
