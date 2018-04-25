using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bingoOfficeSupplies
{
    class SaleInvoice
    {

        //saleInvoiceNumber = The sale invoice number of that customer
        //invoiceProductName = The name of that product
        //invoiceSellingPrice = the price at what we sell the product
        //saleQuantity = The amount in stock
        //valuseOfSale = The total cost of the sale and how much was sold
        //Sale Invoice Attributes
        protected int int_saleInvoiceNumber;
        protected string str_invoiceProductName;
        protected decimal dec_invoiceSellingPrice;
        protected int int_saleQuantity;
        protected decimal dec_valueOfSale;

        //Constuctor
        public SaleInvoice(int int_saleInvoiceNumber, string str_invoiceProductName, decimal dec_invoiceSellingPrice, int int_saleQuantity)
        {
            this.int_saleInvoiceNumber = int_saleInvoiceNumber;
            this.str_invoiceProductName = str_invoiceProductName;
            this.dec_invoiceSellingPrice = dec_invoiceSellingPrice;
            this.int_saleQuantity = int_saleQuantity;
            this.dec_valueOfSale = costOfTotal();
        }



        //Null Construtor
        public SaleInvoice()
        {

        }

        public virtual string print()
        {
            return int_SaleInvoiceNumber + "," +
                str_InvoiceProductName + "," +
                dec_InvoiceSellingPrice.ToString("c") + "," +
                int_SaleQuantity + "," +
                dec_ValueOfSale.ToString("c");
        }

        //Start of the gets and sets
        public int int_SaleInvoiceNumber
        {
            get
            {
                return int_saleInvoiceNumber;
            }
            set
            {
                int_saleInvoiceNumber = value;
            }
        }

        public string str_InvoiceProductName
        {
            get
            {
                return str_invoiceProductName;
            }
            set
            {
                str_invoiceProductName = value;
            }
        }

        public decimal dec_InvoiceSellingPrice
        {
            get
            {
                return dec_invoiceSellingPrice;
            }
            set
            {
                dec_invoiceSellingPrice = value;
            }
        }

        public int int_SaleQuantity
        {
            get
            {
                return int_saleQuantity;
            }
            set
            {
                int_saleQuantity = value;
            }
        }

        public decimal dec_ValueOfSale
        {
            get
            {
                return dec_valueOfSale;
            }
            set
            {
                dec_valueOfSale = value;
            }

        }
        //End of the gets and sets

        //Method for the calculation for the final cost.
        public virtual decimal costOfTotal()
        {
            return dec_invoiceSellingPrice * int_SaleQuantity;
        }
    }
}

