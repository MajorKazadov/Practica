﻿namespace gibddd
{
    partial class CreateDriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.family = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registrationCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registrationStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lifeStreet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lifeCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.jobname = new System.Windows.Forms.TextBox();
            this.mobileNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.addDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить фото";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идентификатор (GUID)";
            // 
            // GUID
            // 
            this.GUID.Location = new System.Drawing.Point(12, 25);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(207, 20);
            this.GUID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(12, 64);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(207, 20);
            this.family.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(207, 20);
            this.name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // fatherName
            // 
            this.fatherName.Location = new System.Drawing.Point(12, 142);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(207, 20);
            this.fatherName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Паспорт (серия и номер)";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(294, 25);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(207, 20);
            this.pasport.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Адрес регистрации";
            // 
            // registrationCity
            // 
            this.registrationCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.registrationCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.registrationCity.Location = new System.Drawing.Point(294, 103);
            this.registrationCity.Name = "registrationCity";
            this.registrationCity.Size = new System.Drawing.Size(207, 20);
            this.registrationCity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Город";
            // 
            // registrationStreet
            // 
            this.registrationStreet.Location = new System.Drawing.Point(507, 103);
            this.registrationStreet.Name = "registrationStreet";
            this.registrationStreet.Size = new System.Drawing.Size(207, 20);
            this.registrationStreet.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Улица, дом, квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Улица, дом, квартира";
            // 
            // lifeStreet
            // 
            this.lifeStreet.Location = new System.Drawing.Point(507, 181);
            this.lifeStreet.Name = "lifeStreet";
            this.lifeStreet.Size = new System.Drawing.Size(207, 20);
            this.lifeStreet.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Город";
            // 
            // lifeCity
            // 
            this.lifeCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lifeCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.lifeCity.Location = new System.Drawing.Point(294, 181);
            this.lifeCity.Name = "lifeCity";
            this.lifeCity.Size = new System.Drawing.Size(207, 20);
            this.lifeCity.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Адрес проживания";
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(12, 181);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(207, 20);
            this.job.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Место работы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Должность";
            // 
            // jobname
            // 
            this.jobname.Location = new System.Drawing.Point(12, 220);
            this.jobname.Name = "jobname";
            this.jobname.Size = new System.Drawing.Size(207, 20);
            this.jobname.TabIndex = 24;
            // 
            // mobileNumber
            // 
            this.mobileNumber.Location = new System.Drawing.Point(12, 259);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(207, 20);
            this.mobileNumber.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Мобильный телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 298);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(207, 20);
            this.email.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Замечания";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 337);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(207, 20);
            this.description.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(294, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Images (*.BMP;*.JPG;*.GIF;*.JPEG)|*.BMP;*.JPG;*.GIF;*.JPEG\"";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(497, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "label17";
            // 
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(546, 334);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(140, 23);
            this.addDriver.TabIndex = 33;
            this.addDriver.Text = "Добавить пользователя";
            this.addDriver.UseVisualStyleBackColor = true;
            // 
            // CreateDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 365);
            this.Controls.Add(this.addDriver);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.jobname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lifeStreet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lifeCity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.registrationStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registrationCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.family);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CreateDriverForm";
            this.Text = "CreateDriverForm";
            this.Load += new System.EventHandler(this.CreateDriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registrationCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox registrationStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lifeStreet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lifeCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox jobname;
        private System.Windows.Forms.TextBox mobileNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addDriver;
    }
}