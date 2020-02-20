using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gibddd
{
    public partial class CreateDriverForm : Form
    {
        public CreateDriverForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var myImage = Image.FromFile(openFileDialog1.FileName);
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                if ((((float)myImage.Width / (float)myImage.Height) == 0.75f) && (fileInfo.Length <= 2097152))
                {
                    pictureBox1.Image = myImage;
                }
                else
                {
                    MessageBox.Show("некорректное фото");
                }
            }
        }

        private void CreateDriverForm_Load(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
            {
                "Москва",
                "Абаза",
                "Грязи",
                "Уфа",
                "Сочи",
                "Тюмень",
                "Санкт-Петербург",
                "Казань",
                "Новосибирск",
                "Воронеж",
                "Владивосток",
                "Красноярск"
            });
            registrationCity.AutoCompleteCustomSource = source;
            lifeCity.AutoCompleteCustomSource = source;
        }
    }
}
