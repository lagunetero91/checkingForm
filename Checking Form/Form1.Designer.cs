﻿namespace Checking_Form
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxDocumentTipe = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname1 = new System.Windows.Forms.TextBox();
            this.textBoxSurname2 = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpedition = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Imprimir y Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Documento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha de expedición:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha de entrada:";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Mujer",
            "Hombre"});
            this.comboBoxSex.Location = new System.Drawing.Point(67, 94);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 11;
            this.comboBoxSex.SelectedIndex = 0;
            // 
            // comboBoxDocumentTipe
            // 
            this.comboBoxDocumentTipe.FormattingEnabled = true;
            this.comboBoxDocumentTipe.Items.AddRange(new object[] {
            "Documento nacional de Identidad (DNI)",
            "Documento de identidad",
            "Pasaporte",
            "Carnet de conducir"});
            this.comboBoxDocumentTipe.Location = new System.Drawing.Point(130, 57);
            this.comboBoxDocumentTipe.Name = "comboBoxDocumentTipe";
            this.comboBoxDocumentTipe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDocumentTipe.TabIndex = 12;
            this.comboBoxDocumentTipe.SelectedIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(81, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(111, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxSurname1
            // 
            this.textBoxSurname1.Location = new System.Drawing.Point(283, 25);
            this.textBoxSurname1.Name = "textBoxSurname1";
            this.textBoxSurname1.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname1.TabIndex = 14;
            // 
            // textBoxSurname2
            // 
            this.textBoxSurname2.Location = new System.Drawing.Point(489, 25);
            this.textBoxSurname2.Name = "textBoxSurname2";
            this.textBoxSurname2.Size = new System.Drawing.Size(117, 20);
            this.textBoxSurname2.TabIndex = 15;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(257, 57);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(126, 20);
            this.textBoxNumber.TabIndex = 16;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(236, 95);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(147, 20);
            this.textBoxCountry.TabIndex = 17;
            // 
            // dateTimePickerExpedition
            // 
            this.dateTimePickerExpedition.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerExpedition.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExpedition.Location = new System.Drawing.Point(505, 57);
            this.dateTimePickerExpedition.Name = "dateTimePickerExpedition";
            this.dateTimePickerExpedition.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerExpedition.TabIndex = 18;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(143, 135);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerBirth.TabIndex = 19;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIn.Location = new System.Drawing.Point(367, 135);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerIn.TabIndex = 20;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10});
            this.dataGridInfo.Location = new System.Drawing.Point(-1, 248);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.Size = new System.Drawing.Size(642, 150);
            this.dataGridInfo.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Primer Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Segundo Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Fech. Nacimiento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "T. Documento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Documento";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Fecha Exp.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "País";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Fech. Entrada";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 396);
            this.Controls.Add(this.dataGridInfo);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.dateTimePickerExpedition);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSurname2);
            this.Controls.Add(this.textBoxSurname1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxDocumentTipe);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Checking Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxDocumentTipe;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname1;
        private System.Windows.Forms.TextBox textBoxSurname2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpedition;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

