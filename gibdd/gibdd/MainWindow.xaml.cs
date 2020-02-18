using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace gibdd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        SqlConnection sqlConnection = new SqlConnection("Data source=303-1\\NEW_MSSQLSERVER; Initial Catalog=gibdd; Integrated Security=true;");

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
            if (Properties.Settings.Default.timeoutGlobal > DateTime.UtcNow)
                enterButton.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT login FROM dbo.[user] WHERE login = '{login.Text}' AND password = '{password.Text}'", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                Properties.Settings.Default.checkAttemptGlobal = 0;
                check.Content = "true";
            }
            else
            {
                Properties.Settings.Default.checkAttemptGlobal++;
                if (Properties.Settings.Default.checkAttemptGlobal > 2)
                {
                    Properties.Settings.Default.timeoutGlobal = DateTime.UtcNow.AddMinutes(1);
                    enterButton.IsEnabled = false;
                }
                check.Content = "false";
            }
            Properties.Settings.Default.Save();
            sqlConnection.Close();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (enterButton.IsEnabled == false)
                if (Properties.Settings.Default.timeoutGlobal <= DateTime.UtcNow)
                {
                    Properties.Settings.Default.checkAttemptGlobal = 0;
                    enterButton.IsEnabled = true;
                }
        }
    }
}
