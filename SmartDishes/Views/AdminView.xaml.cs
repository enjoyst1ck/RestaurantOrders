using SmartDishes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SmartDishes.Views
{
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
            LoadUsers();
            LoadDishes();
        }
        List<DishModel> listOfDishes = new List<DishModel>();
        List<UserModel> listOfUsers = new List<UserModel>();

        SqlConnection con = new SqlConnection("Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;");

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void LoadUsers()
        {
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("exec UserOperations '0',' ',' ',' ',' ','" + "Select" + "'", con);
            
            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];

                UserModel user = new UserModel();

                user.UserId = Convert.ToInt32(dr["UserID"]);
                user.Login = dr["Login"].ToString();
                user.Name = dr["Name"].ToString();
                user.Password = dr["Password"].ToString();
                user.Email = dr["Email"].ToString();

                listOfUsers.Add(user);
            }

            MembersPersonDataGrid.ItemsSource = listOfUsers;
            con.Close();
        }

        private void MenuRadioButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;

            if (button != null)
            {
                switch (button.Tag.ToString())
                {
                    case "Member":
                        MembersGrid.Visibility = Visibility.Visible;
                        AddMealGrid.Visibility = Visibility.Hidden;
                        break;
                    case "AddMeal":
                        MembersGrid.Visibility = Visibility.Hidden;
                        AddMealGrid.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void LoadDishes()
        {
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("select * from dishes", con);

            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];

                DishModel dish = new DishModel();

                dish.DishId = Convert.ToInt32(dr["DishId"]);
                dish.DishName = dr["DishName"].ToString();
                dish.DishCategoryName = dr["DishCategoryName"].ToString();
                dish.DishPrice = Convert.ToInt32(dr["DishPrice"]);
                dish.DishAmount = Convert.ToInt32(dr["DishAmount"]);

                listOfDishes.Add(dish);
            }

           DishesDataGrid.ItemsSource = listOfDishes;
           con.Close();
        }

        private void ButtonAddMemberClick(object sender, RoutedEventArgs e)
        {
            AdminAddView reg = new AdminAddView();
            UserModel user = new UserModel();
            reg.DataContext = user;
            reg.ShowDialog();
            if(reg.IsOkPressed)
            {
                user.UserId = listOfUsers.Count;
                listOfUsers.Add(user);
                MembersPersonDataGrid.Items.Refresh();
            }
        }

        private void ButtonPropertiesMemberClick(object sender, RoutedEventArgs e)
        {
            if (MembersPersonDataGrid.SelectedItem != null)
            {
                AdminChangeView okno = new AdminChangeView();
                UserModel user = new UserModel((UserModel)MembersPersonDataGrid.SelectedItem);
                okno.DataContext = user;
                int index = listOfUsers.IndexOf((UserModel)MembersPersonDataGrid.SelectedItem);
                user.UserId = index;
                okno.ShowDialog();
                if (okno.IsOkPressed)
                {
                    listOfUsers[index] = user;
                    MembersPersonDataGrid.Items.Refresh();
                }
                MembersPersonDataGrid.ItemsSource = listOfUsers;
            }
        }

        private void ButtonDeleteMemberClick(object sender, RoutedEventArgs e)
        {
            if (MembersPersonDataGrid.SelectedItem != null)
            {
                UserModel user = new UserModel((UserModel)MembersPersonDataGrid.SelectedItem);

                int index = listOfUsers.IndexOf((UserModel)MembersPersonDataGrid.SelectedItem);

                con.Open();
                MessageBox.Show(index.ToString());

                SqlCommand cd = new SqlCommand("exec UserOperations '" + index + "',' ',' ',' ',' ','" + "Delete" + "'", con);
                cd.ExecuteNonQuery();
                con.Close();

                listOfUsers.RemoveAt(index);
                MembersPersonDataGrid.Items.Refresh();
            }
        }

        private void ButtonAddDishClick(object sender, RoutedEventArgs e)
        {
            DishAddView dishview = new DishAddView();
            DishModel dish = new DishModel();
            dishview.DataContext = dish;
            dishview.ShowDialog();
            if (dishview.IsOkPressed)
            {
                listOfDishes.Add(dish);
                dish.DishId = listOfDishes.Count - 1;
                DishesDataGrid.Items.Refresh();
            }
        }

        private void ButtonPropertiesDishClick(object sender, RoutedEventArgs e)
        {
            if (DishesDataGrid.SelectedItem != null)
            {
                DishChangeView okno = new DishChangeView();
                DishModel dish = new DishModel((DishModel)DishesDataGrid.SelectedItem);
                okno.DataContext = dish;
                int index = listOfDishes.IndexOf((DishModel)DishesDataGrid.SelectedItem);
                dish.DishId = index;
                okno.ShowDialog();
                if (okno.IsOkPressed)
                {
                    listOfDishes[index] = dish;
                    DishesDataGrid.Items.Refresh();
                }
                DishesDataGrid.ItemsSource = listOfDishes;
            }
        }

        private void ButtonDeleteDishClick(object sender, RoutedEventArgs e)
        {
            if (DishesDataGrid.SelectedItem != null)
            {
                int index = listOfDishes.IndexOf((DishModel)DishesDataGrid.SelectedItem);

                con.Open();
                SqlCommand cmd = new SqlCommand("exec DishOperations '" + index + "',' ',' ',' ',' ','" + "Delete" + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                listOfDishes.RemoveAt(index);
                DishesDataGrid.Items.Refresh();
            }
        }
    }
}
