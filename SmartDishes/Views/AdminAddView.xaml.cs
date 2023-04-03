using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
    public partial class AdminAddView : Window
    {
        public bool IsOkPressed { get; set; }
        public AdminAddView()
        {
            InitializeComponent();
        }
        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            string _connectionString = @"Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;";

            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("exec UserOperations '',' ',' ',' ',' ','" + "Select" + "'", con);
            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            int id = dt.Rows.Count;

            SqlCommand cmd = new SqlCommand("exec UserOperations '" + dt.Rows.Count + "','" + Login.Text + "','" + Password.Text + "','" + Name.Text + "','" + Email.Text + "','" + "Insert" + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            IsOkPressed = true;
            this.Close();
        }

        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
            IsOkPressed = false;
            this.Close();
        }
    }
}
