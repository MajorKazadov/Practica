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

namespace gibddd
{
    public partial class Form1 : Form
    {
        CreateDriverForm createDriverForm = new CreateDriverForm();
        SqlConnection sqlConnection = new SqlConnection("Data source=303-1\\NEW_MSSQLSERVER; Initial Catalog=gibdd; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.timeoutGlobal > DateTime.UtcNow)
                enterButton.Enabled = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT login FROM dbo.[user] WHERE login = '{login.Text}' AND password = '{password.Text}'", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                Properties.Settings.Default.checkAttemptGlobal = 0;
                createDriverForm.Show();
            }
            else
            {
                MessageBox.Show("Некорректные логин или пароль");
                Properties.Settings.Default.checkAttemptGlobal++;
                if (Properties.Settings.Default.checkAttemptGlobal > 2)
                {
                    Properties.Settings.Default.timeoutGlobal = DateTime.UtcNow.AddMinutes(1);
                    enterButton.Enabled = false;
                }
            }
            Properties.Settings.Default.Save();
            sqlConnection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((Properties.Settings.Default.timeoutGlobal <= DateTime.UtcNow) && (enterButton.Enabled == false))
            {
                Properties.Settings.Default.checkAttemptGlobal = 0;
                enterButton.Enabled = true;
            }
        }
    }
}
