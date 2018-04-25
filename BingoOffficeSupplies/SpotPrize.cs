using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoOffficeSupplies
{
    class SpotPrize : BigSpender
    {
        private string str_spotProduct;
        private const decimal DEC_DISCOUNTVALUE = 0.05M;
        private const decimal DEC_POD_DISCOUNT = 0.5M ;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="int_saleInvoiceNumber"></param>
        /// <param name="str_invoiceProductName"></param>
        /// <param name="dec_invoiceSellingPrice"></param>
        /// <param name="int_saleQuantity"></param>
        /// <param name="str_customerName"></param>
        /// <param name="int_customerPhone"></param>
        /// <param name="str_spotProduct"></param>
        public SpotPrize(int int_saleInvoiceNumber, string str_invoiceProductName, decimal dec_invoiceSellingPrice, int int_saleQuantity,  string str_customerName, int int_customerPhone, string str_spotProduct) :
            base(int_saleInvoiceNumber, str_invoiceProductName, dec_invoiceSellingPrice, int_saleQuantity,  str_customerName, int_customerPhone)
        {
            this.str_spotProduct = str_spotProduct;
            this.dec_valueOfSale = costOfTotal();
        }

        /// <summary>
        /// Null Constructor
        /// </summary>
        public SpotPrize()
        {

        }

        public override string print()
        {
            return base.print() + "," + str_spotProduct;
        }

        public string str_SpotProduct
        {
            get
            {
                return str_spotProduct;
            }
            set
            {
                str_spotProduct = value;
            }
        }

        /// <summary>
        /// The override method for the value of sale which now includes the spot prize discount. 
        /// </summary>
        /// <returns></returns>
        public override decimal costOfTotal()
        {
            return Math.Round(dec_invoiceSellingPrice * int_saleQuantity * (1-DEC_DISCOUNTVALUE) - dec_invoiceSellingPrice * DEC_POD_DISCOUNT, 2);
        }
    }
}
