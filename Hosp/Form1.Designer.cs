namespace Hosp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSun = new System.Windows.Forms.TextBox();
            this.tbFr = new System.Windows.Forms.TextBox();
            this.tbThur = new System.Windows.Forms.TextBox();
            this.tbWen = new System.Windows.Forms.TextBox();
            this.tbTues = new System.Windows.Forms.TextBox();
            this.tbMon = new System.Windows.Forms.TextBox();
            this.tbDoc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnRedPat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDelPat = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNumb = new System.Windows.Forms.TextBox();
            this.tbDiag = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPatient = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRed);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание врачей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(782, 396);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(172, 49);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Редактировать";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSun);
            this.panel1.Controls.Add(this.tbFr);
            this.panel1.Controls.Add(this.tbThur);
            this.panel1.Controls.Add(this.tbWen);
            this.panel1.Controls.Add(this.tbTues);
            this.panel1.Controls.Add(this.tbMon);
            this.panel1.Controls.Add(this.tbDoc);
            this.panel1.Location = new System.Drawing.Point(781, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 383);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 49);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(172, 49);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "Принять изменения";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Сб-Вс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пятница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Четверг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Среда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вторник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Понедельник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО врача";
            // 
            // tbSun
            // 
            this.tbSun.Location = new System.Drawing.Point(3, 159);
            this.tbSun.Name = "tbSun";
            this.tbSun.Size = new System.Drawing.Size(170, 20);
            this.tbSun.TabIndex = 6;
            // 
            // tbFr
            // 
            this.tbFr.Location = new System.Drawing.Point(3, 133);
            this.tbFr.Name = "tbFr";
            this.tbFr.Size = new System.Drawing.Size(170, 20);
            this.tbFr.TabIndex = 5;
            // 
            // tbThur
            // 
            this.tbThur.Location = new System.Drawing.Point(3, 107);
            this.tbThur.Name = "tbThur";
            this.tbThur.Size = new System.Drawing.Size(170, 20);
            this.tbThur.TabIndex = 4;
            // 
            // tbWen
            // 
            this.tbWen.Location = new System.Drawing.Point(3, 81);
            this.tbWen.Name = "tbWen";
            this.tbWen.Size = new System.Drawing.Size(170, 20);
            this.tbWen.TabIndex = 3;
            // 
            // tbTues
            // 
            this.tbTues.Location = new System.Drawing.Point(3, 55);
            this.tbTues.Name = "tbTues";
            this.tbTues.Size = new System.Drawing.Size(170, 20);
            this.tbTues.TabIndex = 2;
            // 
            // tbMon
            // 
            this.tbMon.Location = new System.Drawing.Point(3, 29);
            this.tbMon.Name = "tbMon";
            this.tbMon.Size = new System.Drawing.Size(170, 20);
            this.tbMon.TabIndex = 1;
            // 
            // tbDoc
            // 
            this.tbDoc.Location = new System.Drawing.Point(3, 3);
            this.tbDoc.Name = "tbDoc";
            this.tbDoc.Size = new System.Drawing.Size(170, 20);
            this.tbDoc.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctors,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // doctors
            // 
            this.doctors.HeaderText = "Врач";
            this.doctors.Name = "doctors";
            this.doctors.ReadOnly = true;
            // 
            // monday
            // 
            this.monday.HeaderText = "Понедельник";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Вторник";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "Среда";
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Четверг";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            // 
            // friday
            // 
            this.friday.HeaderText = "Пятница";
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            // 
            // saturday
            // 
            this.saturday.HeaderText = "Сб-Вс";
            this.saturday.Name = "saturday";
            this.saturday.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnRedPat);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Больные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnRedPat
            // 
            this.BtnRedPat.Location = new System.Drawing.Point(781, 395);
            this.BtnRedPat.Name = "BtnRedPat";
            this.BtnRedPat.Size = new System.Drawing.Size(172, 49);
            this.BtnRedPat.TabIndex = 3;
            this.BtnRedPat.Text = "Редактировать";
            this.BtnRedPat.UseVisualStyleBackColor = true;
            this.BtnRedPat.Click += new System.EventHandler(this.BtnRedPat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnDelPat);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbNumb);
            this.panel2.Controls.Add(this.tbDiag);
            this.panel2.Controls.Add(this.tbAge);
            this.panel2.Controls.Add(this.tbPatient);
            this.panel2.Location = new System.Drawing.Point(781, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 383);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // BtnDelPat
            // 
            this.BtnDelPat.Location = new System.Drawing.Point(3, 331);
            this.BtnDelPat.Name = "BtnDelPat";
            this.BtnDelPat.Size = new System.Drawing.Size(172, 49);
            this.BtnDelPat.TabIndex = 15;
            this.BtnDelPat.Text = "Удалить";
            this.BtnDelPat.UseVisualStyleBackColor = true;
            this.BtnDelPat.Click += new System.EventHandler(this.BtnDelPat_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(181, 331);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(172, 49);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Принять изменения";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Номер палаты";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Диагноз";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Возраст";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Пациент";
            // 
            // tbNumb
            // 
            this.tbNumb.Location = new System.Drawing.Point(3, 81);
            this.tbNumb.Name = "tbNumb";
            this.tbNumb.Size = new System.Drawing.Size(170, 20);
            this.tbNumb.TabIndex = 3;
            // 
            // tbDiag
            // 
            this.tbDiag.Location = new System.Drawing.Point(3, 55);
            this.tbDiag.Name = "tbDiag";
            this.tbDiag.Size = new System.Drawing.Size(170, 20);
            this.tbDiag.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(3, 29);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(170, 20);
            this.tbAge.TabIndex = 1;
            // 
            // tbPatient
            // 
            this.tbPatient.Location = new System.Drawing.Point(3, 3);
            this.tbPatient.Name = "tbPatient";
            this.tbPatient.Size = new System.Drawing.Size(170, 20);
            this.tbPatient.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient,
            this.age,
            this.diagnosis,
            this.numPal});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(769, 540);
            this.dataGridView2.TabIndex = 1;
            // 
            // patient
            // 
            this.patient.HeaderText = "Пациент";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // diagnosis
            // 
            this.diagnosis.HeaderText = "Диагноз";
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ReadOnly = true;
            // 
            // numPal
            // 
            this.numPal.HeaderText = "Номер палаты";
            this.numPal.Name = "numPal";
            this.numPal.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Больница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSun;
        private System.Windows.Forms.TextBox tbFr;
        private System.Windows.Forms.TextBox tbThur;
        private System.Windows.Forms.TextBox tbWen;
        private System.Windows.Forms.TextBox tbTues;
        private System.Windows.Forms.TextBox tbMon;
        private System.Windows.Forms.TextBox tbDoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDelPat;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNumb;
        private System.Windows.Forms.TextBox tbDiag;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPal;
        private System.Windows.Forms.Button BtnRedPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
    }
}

