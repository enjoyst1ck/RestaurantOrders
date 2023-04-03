using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace SmartDishes.Models
{
    public class DishModel
    {
        private DishModel selectedItem;

        public int DishId { get; set; }
        public string DishName { get; set; }
        public string DishCategoryName { get; set; }
        public float DishPrice { get; set; }
        public int DishAmount { get; set; }
        public int QuantityOrdered { get; set; }

        public DishModel()
        {

        }

        public DishModel(int DishId, string DishName, string DishCategoryName, float DishPrice, int DishAmount)
        {
            this.DishId = DishId;
            this.DishName = DishName;
            this.DishCategoryName = DishCategoryName;
            this.DishPrice = DishPrice;
            this.DishAmount = DishAmount;
        }

        public DishModel(DishModel selectedItem)
        {
            this.selectedItem = selectedItem;
        }
    }
}
