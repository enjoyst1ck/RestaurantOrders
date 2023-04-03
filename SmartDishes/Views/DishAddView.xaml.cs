using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using Microsoft.Win32;

namespace SmartDishes.Views
{
    public partial class DishAddView : Window
    {
        public bool IsOkPressed { get; set; }
        public DishAddView()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;");

            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("exec DishOperations '',' ',' ',' ',' ','" + "Select" + "'", con);

            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            Image img = DishImage;

            con.Open();
            SqlCommand cmd = new SqlCommand("exec DishOperations '" + dt.Rows.Count + "','" + DishNameTextBox.Text + "','" + DishCategoryNameTextBox.Text + "','" + DishPriceTextBox.Text + "','" + DishAmountTextBox.Text + "','" + "Insert" + "'", con);
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

        private void ButtonUploadImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.png";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == true)
            {
                DishImage.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
