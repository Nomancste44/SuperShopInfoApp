using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopInfoApp
{
    class ShopInfo
    {
        public string  ShopName { get; set; }
        public string  Address { get; set; }
        public List<ProductInfo> Products { get; set; }

        public ShopInfo()
        {
           Products= new List<ProductInfo>();

        }

        public bool IstheProductAlreadyExist(string productId)
        {
            bool result = false;
            foreach (ProductInfo productItem in Products)
            {
                if (productItem.ProductId == productId)
                    result = true;
            }
            return result;
        }
    }
}
