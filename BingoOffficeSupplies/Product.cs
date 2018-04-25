using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoOffficeSupplies
{
    class Product
    {
        string str_productCode;
        string str_productName;
        int int_stockAmount;
        decimal dec_productPrice;
        string str_productImage;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="str_productCode"></param>
        /// <param name="str_productName"></param>
        /// <param name="int_stockAmount"></param>
        /// <param name="dec_productPrice"></param>
        /// <param name="str_productImage"></param>
        public Product(string str_productCode, string str_productName, int int_stockAmount, decimal dec_productPrice, string str_productImage)
        {
            this.str_productCode = str_productCode;
            this.str_productName = str_productName;
            this.int_stockAmount = int_stockAmount;
            this.dec_productPrice = dec_productPrice;
            this.str_productImage = str_productImage;
        }

        /// <summary>
        /// Null Constructor.
        /// </summary>
        public Product()
        {

        }

        public string str_ProductCode
        {
            get
            {
                return str_productCode;
            }
            set
            {
                str_productCode = value;
            }
        }
        public string str_ProductName
        {
            get
            {
                return str_productName;
            }
            set
            {
                str_productName = value;
            }
        }
        public int int_StockAmount
        {
            get
            {
                return int_stockAmount;
            }
            set
            {
                int_stockAmount = value;
            }
        }
        public decimal dec_ProductPrice
        {
            get
            {
                return dec_productPrice;
            }
            set
            {
                dec_productPrice= value;
            }
        }
        public string str_ProductImage
        {
            get
            {
                return str_productImage;
            }
        }

        /// <summary>
        /// This checks if the user has put in more the the stock amount allows.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public Boolean stockAvailable(int userInput)
        {
            if (userInput > int_stockAmount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This is the method for taking what the user has entered from the stock amount.
        /// </summary>
        /// <param name="userInput"></param>
        public void makeSale(int userInput)
        {
            int_stockAmount -= userInput;
        }
    }
}
