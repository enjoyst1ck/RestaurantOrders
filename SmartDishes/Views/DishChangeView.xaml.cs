using System;
using System.Collections.Generic;
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
    public partial class DishChangeView : Window
    {
        public bool IsOkPressed { get; set; }
        public DishChangeView()
        {
            InitializeComponent();
        }

        private void ButtonConfirmClick(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;");

            con.Open();
            SqlCommand cmd = new SqlCommand("exec DishOperations '" + DishId.Text + "','" + DishName.Text + "','" + DishCategoryName.Text + "','" + DishPrice.Text + "','" + DishAmount.Text + "','" + "Update" + "'", con);
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
