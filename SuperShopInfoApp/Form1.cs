using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopInfoApp
{
    public partial class SuperShopForm : Form
    {
        public SuperShopForm()
        {
            InitializeComponent();
        }
        ShopInfo aShop = new ShopInfo();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop.ShopName = shopNameTextBox.Text;
            aShop.Address = shopAddressTextBox.Text;
        }

        private void itemAddButton_Click(object sender, EventArgs e)
        {
            ProductInfo aPrdouct = new ProductInfo();
            string itemId = itemIdTextBox.Text;
            int itemQuantity = Convert.ToInt32(itemQuantiyTextBox.Text);
            if(aShop.IstheProductAlreadyExist(itemId))
            {
                foreach (ProductInfo products in aShop.Products)
                {
                    if (products.ProductId == itemId)
                    {
                        itemQuantity += products.ProductQuantity;
                        products.ProductQuantity = itemQuantity;
                    }
                }
            }
            else
            {
                aPrdouct.ProductId = itemId;
                aPrdouct.ProductQuantity = itemQuantity;
                aShop.Products.Add(aPrdouct);
            }
           
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            StringBuilder shopDetails = new StringBuilder();
            shopDetails.Append(aShop.ShopName);
            shopDetails.Append(Environment.NewLine);
            shopDetails.Append(aShop.Address);
            shopDetails.Append(Environment.NewLine);
            foreach (ProductInfo aProductInfo in aShop.Products)
            {
                shopDetails.Append(aProductInfo.ProductId + " " + aProductInfo.ProductQuantity);
                shopDetails.Append(Environment.NewLine);
            }
            MessageBox.Show(shopDetails.ToString());
        }
    }
}
