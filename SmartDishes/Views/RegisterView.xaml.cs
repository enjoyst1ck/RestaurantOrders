using SmartDishes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace SmartDishes.Views
{

    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {

            if (Password.Password == ConfirmPassword.Password && Password.Password.Length > 5 &&
               Name.Text.Length > 2 && !string.IsNullOrWhiteSpace(Name.Text) &&
               Login.Text.Length > 2 && !string.IsNullOrWhiteSpace(Login.Text) &&
               Email.Text.Length > 2 && !string.IsNullOrWhiteSpace(Email.Text) && Email.Text.Contains('@')
               )
            {
                string _connectionString = @"Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;";
                bool check = true;

                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand("select login, email from users", con);

                dataAdapter.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                DataRow dr = dt.NewRow();

                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    if (dr["login"].ToString() == Login.Text || dr["email"].ToString() == Email.Text)
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {

                    SqlCommand cmd = new SqlCommand("exec UserOperations '" + i + "','" + Login.Text + "','" + Password.Password + "','" + Name.Text + "','" + Email.Text + "','" + "Insert" + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoginView loginView = new LoginView();
                    loginView.Show();
                    this.Visibility = Visibility.Hidden;

                }
                else
                {
                    MessageBox.Show("Login lub Email jest już w użyciu");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Podane dane są nieprawidłowe!");
            }
        }
    }
}
