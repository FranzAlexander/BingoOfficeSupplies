using bingoOfficeSupplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoOffficeSupplies
{
    class BigSpender : SaleInvoice
    {
        string str_customerName;
        int int_customerPhone;
        private const decimal DEC_DISCOUNTVALUE = 0.05M;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="int_saleInvoiceNumber"></param>
        /// <param name="str_invoiceProductName"></param>
        /// <param name="dec_invoiceSellingPrice"></param>
        /// <param name="int_saleQuantity"></param>
        /// <param name="str_customerName"></param>
        /// <param name="int_customerPhone"></param>
        public BigSpender(int int_saleInvoiceNumber, string str_invoiceProductName, decimal dec_invoiceSellingPrice, int int_saleQuantity, string str_customerName, int int_customerPhone) :
            base(int_saleInvoiceNumber, str_invoiceProductName, dec_invoiceSellingPrice, int_saleQuantity)
        {
            this.str_customerName = str_customerName;
            this.int_customerPhone = int_customerPhone;
            this.dec_valueOfSale = costOfTotal();
        }

        /// <summary>
        /// Null Constructor
        /// </summary>
        public BigSpender()
        {

        }

        public override string print()
        {
            return base.print() + "," +
                str_CustomerName + "," +
                int_customerPhone;
        }

        public string str_CustomerName
        {
            get
            {
                return str_customerName;
            }
            set
            {
                str_customerName = value;
            }
        }

        public int int_CustomerPhone
        {
            get
            {
                return int_customerPhone;
            }
            set
            {
                int_customerPhone = value;
            }
        }
        
        /// <summary>
        /// The overide method for the value of the sale which now includes the discount amount.
        /// </summary>
        /// <returns></returns>
        public override decimal costOfTotal()
        {
            return Math.Round(dec_invoiceSellingPrice * int_saleQuantity * (1 - DEC_DISCOUNTVALUE), 2);
        }
    }
}
