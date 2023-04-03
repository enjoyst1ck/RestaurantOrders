using SmartDishes.Models;
using SmartDishes.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace SmartDishes.Views
{
    public partial class LoggedView : Window
    {
        public float AllCost { get; set; }
        List<DishModel> DishesList = new List<DishModel>();
        List<DishModel> BasketList = new List<DishModel>();
        List<OrderModel> OrderList = new List<OrderModel>();

        public LoggedView()
        {
            InitializeComponent();
            CreateMenu();
            UploadOrders();
        }

        //procedure hid-show grids
        #region hid-show grids
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MainRadioButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;

            if (button != null)
            {
                switch (button.Tag.ToString())
                {
                    case "Home":
                        HomeGrid.Visibility = Visibility.Visible;
                        MenuDishesGrid.Visibility = Visibility.Hidden;
                        BasketGrid.Visibility = Visibility.Hidden;
                        MyOrderGrid.Visibility = Visibility.Hidden;
                        break;
                    case "Menu":
                        HomeGrid.Visibility = Visibility.Hidden;
                        MenuDishesGrid.Visibility = Visibility.Visible;
                        BasketGrid.Visibility = Visibility.Hidden;
                        MyOrderGrid.Visibility = Visibility.Hidden;
                        break;
                    case "Basket":
                        HomeGrid.Visibility = Visibility.Hidden;
                        MenuDishesGrid.Visibility = Visibility.Hidden;
                        BasketGrid.Visibility = Visibility.Visible;
                        MyOrderGrid.Visibility = Visibility.Hidden;
                        break;
                    case "Order":
                        HomeGrid.Visibility = Visibility.Hidden;
                        MenuDishesGrid.Visibility = Visibility.Hidden;
                        BasketGrid.Visibility = Visibility.Hidden;
                        MyOrderGrid.Visibility = Visibility.Visible;
                        break;

                }
            }
        }
        #endregion

        private void CreateMenu()
        {
            BasketItemDataGrid.ItemsSource = BasketList;

            AllCost = 0;
            string _connectionString = @"Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;";

            SqlConnection con = new SqlConnection(_connectionString);
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

                DishModel item = new DishModel();

                item.DishId = Convert.ToInt32(dr["dishid"]);
                item.DishName = dr["DishName"].ToString();
                item.DishCategoryName = dr["DishCategoryName"].ToString();
                item.DishPrice = (float)Convert.ToDouble(dr["DishPrice"]);
                item.DishAmount = Convert.ToInt32(dr["DishAmount"]);
                item.QuantityOrdered = 0;
                DishesList.Add(item);

                StackPanel ItemStackPanel = new StackPanel();
                ItemStackPanel.Height = 200;
                ItemStackPanel.Width = 250;
                ItemStackPanel.Background = Brushes.Beige;
                TextBlock DishNameTextBlock = new TextBlock();
                DishNameTextBlock.FontSize = 24;
                DishNameTextBlock.MaxWidth = 160;
                DishNameTextBlock.TextWrapping = TextWrapping.Wrap;
                DishNameTextBlock.Margin = new Thickness(10, 0, 10, 0);
                DishNameTextBlock.Text = item.DishName + " (" + item.DishPrice + "$)";

                Button AddToCartButton = new Button();
                AddToCartButton.Content = "Add to cart";
                AddToCartButton.Margin = new Thickness(10, 10, 10, 0);
                AddToCartButton.Height = 30;
                AddToCartButton.Width = 87;
                AddToCartButton.Tag = item.DishId;
                AddToCartButton.Opacity = 1;


                ItemStackPanel.Children.Add(DishNameTextBlock);
                AddToCartButton.Click += AddToBasket;
                ItemStackPanel.Children.Add(AddToCartButton);

                switch (item.DishCategoryName)
                {
                    case "Appetizer                     ":
                        AppetizerStackPanel.Children.Add(ItemStackPanel);
                        break;
                    case "Soup                          ":
                        SoupStackPanel.Children.Add(ItemStackPanel);
                        break;
                    case "MainCourse                    ":
                        MainCourseStackPanel.Children.Add(ItemStackPanel);
                        break;
                    case "Dessert                       ":
                        DessertStackPanel.Children.Add(ItemStackPanel);
                        break;
                    case "Sides                         ":
                        SidesStackPanel.Children.Add(ItemStackPanel);
                        break;
                    case "Beverages                     ":
                        BeveragesStackPanel.Children.Add(ItemStackPanel);
                        break;
                }
            }
        }

        private void UploadOrders()
        {
            string _connectionString = @"Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;";

            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            var userRepository = new UserRepository();
            var user = userRepository.GetByLogin(Thread.CurrentPrincipal.Identity.Name);
            int index = user.UserId;
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            
            dataAdapter.SelectCommand = new SqlCommand($"select * from orders where userid = {index}", con);

            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            MyOrderDataGrid.ItemsSource = OrderList;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];

                OrderModel order = new OrderModel();
                order.OrderId = Convert.ToInt32(dr["orderid"]);
                order.UserId = Convert.ToInt32(dr["userid"]);
                order.Cost = dr["userid"].ToString();
                OrderList.Add(order);
            }
                MyOrderDataGrid.Items.Refresh();


        }

        private void AddToBasket(object sender, RoutedEventArgs e)
        {
            bool exist = false;
            var button = sender as Button;
            int idDish = (int)button.Tag;
            DishModel item = DishesList[idDish];

            for (int i = 0; i < BasketList.Count(); i++)
            {
                if (idDish == BasketList[i].DishId)
                {
                    BasketList[i].QuantityOrdered++;
                    exist = true;
                    AllCost += item.DishPrice;
                }
            }

            if (!exist)
            {
                item.QuantityOrdered++;
                BasketList.Add(item);
                AllCost += item.DishPrice;
            }
            CostTextBlock.Text = AllCost.ToString() + "$";
            BasketItemDataGrid.Items.Refresh();
        }

        private void DeleteFromBasket(object sender, RoutedEventArgs e)
        {
            if (BasketItemDataGrid.SelectedItem != null)
            {
                int index = BasketList.IndexOf((DishModel)BasketItemDataGrid.SelectedItem);
                
                if (index > -1 && BasketList.Count > index)
                {

                    AllCost -= BasketList[index].DishPrice;
                    CostTextBlock.Text = AllCost.ToString() + "$";

                    MessageBox.Show($"{BasketList[index].QuantityOrdered}");
                    if (BasketList[index].QuantityOrdered > 1)
                    {
                        BasketList[index].QuantityOrdered--;
                    }
                    else
                    {
                        BasketList.RemoveAt(index);
                    }

                    BasketItemDataGrid.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Proszę zaznaczyć właściwy index");
                }
            }
        }

        private void OrderButtonClick(object sender, RoutedEventArgs e)
        {
            string _connectionString = @"Data Source=B1-G1; Initial Catalog=SmartDishes; Integrated Security=SSPI; Encrypt=false;";

            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            var userRepository = new UserRepository();
            var user = userRepository.GetByLogin(Thread.CurrentPrincipal.Identity.Name);

            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("select orderid from orders", con);

            dataAdapter.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            DataRow dr = dt.NewRow();

            int id = dt.Rows.Count;

            if (user != null)
            {
                SqlCommand sc = new SqlCommand("exec InsertOrder '" + id + "','" + user.UserId + "','" + AllCost + "'", con);

                sc.ExecuteNonQuery();
            }

            for (int i = 0; i < BasketList.Count(); i++)
            {
                SqlCommand sc = new SqlCommand("exec InsertOrderDetails '" + id + "','" + BasketList[i].DishId + "','" + BasketList[i].DishPrice + "','" + BasketList[i].QuantityOrdered + "'", con);
                
                sc.ExecuteNonQuery();
            }

            for (int i = BasketList.Count() - 1; i >= 0; i--)
            {
                BasketList.RemoveAt(i);
                BasketItemDataGrid.Items.Refresh();
            }

            con.Close();
            MessageBox.Show("Zamówienie zostało złożone");
            AllCost = 0;
            CostTextBlock.Text = AllCost.ToString();
            MyOrderDataGrid.Items.Refresh();
        }
    } 
}