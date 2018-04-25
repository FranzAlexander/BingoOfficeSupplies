using bingoOfficeSupplies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author: Alex Balcombe.
/// Date: 27/10/2016.
/// Description: This is a program that allows the user to buy items from the store. This program reads from a text file, does all the discount and selects and product of the day.
/// It does the math of taking the stock amount down depending on the user input. It then writes the sale invoice into a text file an updates the text file with the products.
/// </summary>
namespace BingoOffficeSupplies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            readingProductTxt();
            displayingProducts();
            visibleFalse();
            panelVisFalse();
            btn_closeBus.Visible = false;
            pnl_panel2.Visible = false;
            btn_purchase.Visible = false;
            bln_spotPrizeAward = false;
            bln_disTF = false;
        }

        const int MAX_PRODUCTS = 20;
        const int MAX_SALES = 21;
        const int INT_MINPRICE = 20;
        const decimal DEC_DISCOUNT = 0.95M;
        const decimal DEC_MARKUP = 1.6M;
        const decimal DEC_SPOTDISCOUNT = 0.5M;

        Product[] arr_products = new Product[MAX_PRODUCTS];

        SaleInvoice[] arr_sales = new SaleInvoice[MAX_SALES];

        int int_finalQty = 0;
        decimal dec_finalSalesValue = 0;
        decimal dec_priceMarkUp;
        decimal dec_spotPrizeCost;
        string str_codeOfProduct;
        string str_productCode;
        string str_customerName;
        int int_customerPhone;
        int int_invoiceNum = 1;
        int int_updateCounter = 0;
        int int_userInput = 0;
        bool bln_disTF;
        bool bln_spotPrizeAward = false;
        int int_counter = 0;

        /// <summary>
        /// Reading the text file an putting the data into an object array.
        /// </summary>
        private void readingProductTxt()
        {
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("Products.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] arr_productInfo = line.Split(',');

                Product obj_productInfo = new Product
                (arr_productInfo[0],
                arr_productInfo[1],
                Convert.ToInt32(arr_productInfo[2]),
                Convert.ToDecimal(arr_productInfo[3]),
                arr_productInfo[4]);

                arr_products[int_counter] = obj_productInfo;
                int_counter++;
            }
            file.Close();
        }

        /// <summary>
        /// Displaying the product name into the list box.
        /// </summary>
        private void displayingProducts()
        {
            for (int i = 0; i < int_counter; i++)
            {
                lst_productList.Items.Add(arr_products[i].str_ProductName);
            }
        }

        /// <summary>
        /// EventHandler for when the user clicks on an item within the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productList_MouseClick(object sender, MouseEventArgs e)
        {
            pic_pictureLoc.ImageLocation = arr_products[lst_productList.SelectedIndex].str_ProductImage;
            lbl_nameLbl.Text = arr_products[lst_productList.SelectedIndex].str_ProductName;
            lbl_showPriceLbl.Text = arr_products[lst_productList.SelectedIndex].dec_ProductPrice.ToString("c");
            visibleTrue();
        }

        /// <summary>
        /// This is the code for the mark of 60% on top of the orignal price.
        /// </summary>
        /// <param name="dec_orignalPrice"></param>
        /// <returns></returns>
        private decimal markUp(decimal dec_orignalPrice)
        {
            decimal dec_markUpPrice;

            dec_markUpPrice = dec_orignalPrice * DEC_MARKUP;

            return Math.Round(dec_markUpPrice, 2);
        }

        /// <summary>
        /// Just a method for making elements on the UI visible.
        /// </summary>
        private void visibleTrue()
        {
            pic_pictureLoc.Visible = true;
            lbl_showPriceLbl.Visible = true;
            lbl_productName.Visible = true;
            lbl_nameLbl.Visible = true;
            btn_sellProduct.Visible = true;
            lbl_Price.Visible = true;
        }

        /// <summary>
        /// Just a method for making elements on the UI invisible.
        /// </summary>
        private void visibleFalse()
        {
            pic_pictureLoc.Visible = false;
            lbl_showPriceLbl.Visible = false;
            lbl_productName.Visible = false;
            lbl_nameLbl.Visible = false;
            btn_sellProduct.Visible = false;
            lbl_Price.Visible = false;
        }

        /// <summary>
        /// Just a method for making panel, cancel and confirm buttons on the UI visible.
        /// </summary>
        private void panelVisTrue()
        {
            pnl_panel1.Visible = true;
            btn_cancel.Visible = false;
            btn_confrim.Visible = false;
        }

        /// <summary>
        /// Just a method for making panel on the UI invisible.
        /// </summary>
        private void panelVisFalse()
        {
            pnl_panel1.Visible = false;
        }

        /// <summary>
        /// Click event for the button "Sell Product" which proceed with the sale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellProduct_Click(object sender, EventArgs e)
        {
            panelVisTrue();
            visibleFalse();
            panelReadOnly();

            pic_panel.ImageLocation = arr_products[lst_productList.SelectedIndex].str_ProductImage;
            txt_invNum.Text = int_invoiceNum.ToString();
            txt_panelPName.Text = arr_products[lst_productList.SelectedIndex].str_ProductName;
            txt_perOne.Text = markUp(arr_products[lst_productList.SelectedIndex].dec_ProductPrice).ToString("c");
        }

        /// <summary>
        /// Makes elements in the panel read only.
        /// </summary>
        private void panelReadOnly()
        {
            txt_enteredAmount.Focus();
            lst_productList.Enabled = false;
            totalCostTxt.ReadOnly = true;
            txt_invNum.ReadOnly = true;
            txt_panelPName.ReadOnly = true;
            txt_perOne.ReadOnly = true;

            txt_invNum.BackColor = Color.White;
            totalCostTxt.BackColor = Color.White;
            txt_panelPName.BackColor = Color.White;
            txt_perOne.BackColor = Color.White;
        }

        /// <summary>
        /// Checking if there is enough stock.
        /// </summary>
        private void checkingStock()
        {
            Int32.TryParse(txt_enteredAmount.Text, out int_userInput);
            dec_priceMarkUp = int_userInput * markUp(arr_products[lst_productList.SelectedIndex].dec_ProductPrice);

            if (arr_products[lst_productList.SelectedIndex].stockAvailable(int_userInput) == true)
            {
                totalCostTxt.Text = dec_priceMarkUp.ToString("c");
            }
            else
            {
                MessageBox.Show("The amount you have entered is not in stock!!!" + "\n" + "The amount in stock: " + arr_products[lst_productList.SelectedIndex].int_StockAmount);
                txt_enteredAmount.Clear();
                totalCostTxt.Clear();
                txt_enteredAmount.Focus();
            }

            btn_cancel.Visible = true;
            btn_purchase.Visible = true;
        }

        /// <summary>
        /// The TextBox Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enteredAmountTxt_TextChanged(object sender, EventArgs e)
        {
            checkingStock();
        }

        /// <summary>
        /// This is the button event that adds the data into the objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confrimBtn_Click(object sender, EventArgs e)
        {
            saleConfirm();
            if (MessageBox.Show("Would you like to make another purchase", "Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pnl_panel1.Visible = false;
                btn_closeBus.Visible = true;
            }
            else
            {
                btn_closeBus.Visible = true;
                pnl_panel1.Visible = false;
            }
        }

        /// <summary>
        /// This is the method that is called in the button event to add the data into the objects.
        /// </summary>
        private void saleConfirm()
        {
            str_customerName = userNameTxt.Text;
            Int32.TryParse(userPhoneTxt.Text, out int_customerPhone);

            /// <summary>
            /// Discount no spot prize 
            /// <summary>
            if (bln_disTF == true)
            {
                pnl_panel2.Visible = true;
                pnl_panel2.Enabled = true;

                //Int32.TryParse(userPhoneTxt.Text, out int_tempPhone);

                BigSpender bigSpender = new BigSpender
                (int_invoiceNum,
                arr_products[lst_productList.SelectedIndex].str_ProductName,
                markUp(arr_products[lst_productList.SelectedIndex].dec_ProductPrice),
                int_userInput,
                str_customerName,
                int_customerPhone);

                bigSpender.dec_ValueOfSale = bigSpender.costOfTotal();
                int_finalQty += bigSpender.int_SaleQuantity;
                dec_finalSalesValue += bigSpender.dec_ValueOfSale;
                arr_sales[int_updateCounter] = bigSpender;
                arr_products[lst_productList.SelectedIndex].makeSale(int_userInput);
                bln_disTF = false;
            }

            /// <summary>
            /// Discount with spot prize 
            /// <summary>
            else if (bln_spotPrizeAward == true)
            {
                SpotPrize spotPrize = new SpotPrize
                (int_invoiceNum,
                arr_products[lst_productList.SelectedIndex].str_ProductName,
                dec_spotPrizeCost,
                int_userInput,
                str_customerName,
                int_customerPhone,
                arr_products[5].str_ProductName);

                spotPrize.dec_ValueOfSale = spotPrize.costOfTotal();
                int_finalQty += spotPrize.int_SaleQuantity;
                dec_finalSalesValue += spotPrize.dec_ValueOfSale;
                arr_sales[int_updateCounter] = spotPrize;
                arr_products[lst_productList.SelectedIndex].makeSale(int_userInput);
                bln_spotPrizeAward = false;
            }

            /// <summary>
            /// Sale with no discount.
            /// <summary>
            else
            {
                arr_products[lst_productList.SelectedIndex].makeSale(int_userInput);

                SaleInvoice saleInvoice = new SaleInvoice
                (int_invoiceNum,
                arr_products[lst_productList.SelectedIndex].str_ProductName,
                markUp(arr_products[lst_productList.SelectedIndex].dec_ProductPrice),
                int_userInput);

                saleInvoice.dec_ValueOfSale = saleInvoice.costOfTotal();
                int_finalQty += saleInvoice.int_SaleQuantity;
                dec_finalSalesValue += saleInvoice.dec_ValueOfSale;
                arr_sales[int_updateCounter] = saleInvoice;

            }
            saleConfirmUI();
        }

        /// <summary>
        /// Method that sets ui elements. Also increments the counters.
        /// </summary>
        private void saleConfirmUI()
        {
            int_invoiceNum++;
            int_updateCounter++;
            txt_enteredAmount.Clear();
            totalCostTxt.Clear();
            userNameTxt.Clear();
            userPhoneTxt.Clear();
            discountTxt.Clear();
            btn_closeBus.Visible = true;
            lst_productList.Enabled = true;
            pnl_panel2.Visible = false;
        }

        /// <summary>
        /// This is the button method for when the person wants to finsh using the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBusBtn_Click(object sender, EventArgs e)
        {

            txt_enteredAmount.Clear();
            totalCostTxt.Clear();
            txt_enteredAmount.Focus();
            userNameTxt.Clear();
            userPhoneTxt.Clear();
            writingBackProducts();
            finishingSaleInvoice();
            lst_productList.Enabled = true;
        }

        /// <summary>
        /// The cancel button just put them at the start of the buying process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            lst_productList.Enabled = true;
            panelVisFalse();
            visibleTrue();
            txt_enteredAmount.Clear();
            totalCostTxt.Clear();
        }

        /// <summary>
        /// Writing the stock product information back to the products text file.
        /// </summary>
        private void writingBackProducts()
        {
            System.IO.StreamWriter productFile = new System.IO.StreamWriter("Products.txt");

            for (int count = 0; count < int_counter; count++)
            {
                productFile.Write(arr_products[count].str_ProductCode + ",");
                productFile.Write(arr_products[count].str_ProductName + ",");
                productFile.Write(arr_products[count].int_StockAmount.ToString() + ",");
                productFile.Write(arr_products[count].dec_ProductPrice.ToString() + ",");
                productFile.Write(arr_products[count].str_ProductImage + productFile.NewLine);
            }

            productFile.Close();
        }

        /// <summary>
        /// Writing the sale information to a text file with the COB.
        /// </summary>
        private void finishingSaleInvoice()
        {
            DateTime nowDate = DateTime.Now;

            SaleInvoice saleInvoice = new SaleInvoice();
            saleInvoice.int_SaleInvoiceNumber = 999;
            saleInvoice.str_InvoiceProductName = "Total Sales For:" + nowDate.ToString("yyyy/MM/dd");
            saleInvoice.dec_InvoiceSellingPrice = 0;
            saleInvoice.int_SaleQuantity = int_finalQty;
            saleInvoice.dec_ValueOfSale = dec_finalSalesValue;


            btn_closeBus.Visible = true;
            pnl_panel1.Enabled = true;
            pnl_panel1.Visible = false;

            System.IO.StreamWriter saleFile = new System.IO.StreamWriter("sales.txt");
            for (int count = 0; count < int_updateCounter; count++)
            {
                saleFile.Write(arr_sales[count].print() + saleFile.NewLine);
            }
            saleFile.Write(saleInvoice.int_SaleInvoiceNumber + "," +
                saleInvoice.str_InvoiceProductName + "," +
                saleInvoice.dec_InvoiceSellingPrice + "," +
                saleInvoice.int_SaleQuantity + "," +
                saleInvoice.dec_ValueOfSale.ToString("c") +
                saleFile.NewLine);

            saleFile.Write("From left to right:" + saleFile.NewLine);
            saleFile.Write("Invoice Number, Product Name, Cost of the product, Amount sold, and the Value of sale.");
            saleFile.Close();

        }

        /// <summary>
        /// Displaying the spot prize amount. Making sure the the text boxs arnt empty.
        /// </summary>
        private void displaySpotPrize()
        {
            if (!string.IsNullOrWhiteSpace(userNameTxt.Text) && !string.IsNullOrWhiteSpace(userPhoneTxt.Text) && bln_spotPrizeAward == false)
            {
                discountTxt.Text = (dec_priceMarkUp * DEC_DISCOUNT).ToString("c");
            }
        }

        /// <summary>
        /// Method for checking for the spot prize and discount meet requirements.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            str_productCode = arr_products[5].str_ProductCode;
            str_codeOfProduct = arr_products[lst_productList.SelectedIndex].str_ProductCode.ToString();

            if (dec_priceMarkUp >= INT_MINPRICE)
            {
                pnl_panel2.Visible = true;
                bln_disTF = true;

                discountTxt.Text = Math.Round(dec_priceMarkUp * DEC_DISCOUNT, 2).ToString("c");
            }
            if (dec_priceMarkUp >= INT_MINPRICE && str_codeOfProduct == str_productCode)
            {
                pnl_panel2.Visible = true;
                bln_disTF = false;
                spotPrizeDiscount();
            }
            btn_confrim.Visible = true;
        }

        /// <summary>
        /// Setting the product of the day and displaying the discount.
        /// </summary>
        private void spotPrizeDiscount()
        {
            dec_spotPrizeCost = (dec_priceMarkUp * DEC_DISCOUNT) - (markUp(arr_products[lst_productList.SelectedIndex].dec_ProductPrice * DEC_SPOTDISCOUNT));

            MessageBox.Show("BINGO you have select the product of the day", "BINGO");
            MessageBox.Show("The Price is now: " + dec_spotPrizeCost.ToString("c"), "Price");
            discountTxt.Text = dec_spotPrizeCost.ToString("c");
            bln_spotPrizeAward = true;
        }

        /// <summary>
        /// Method for the text change on the phone number text box and calling the spot prize discount method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPhoneTxt_TextChanged(object sender, EventArgs e)
        {
            displaySpotPrize();
        }

        /// <summary>
        /// Making it so that you can only enter numbers in to the phone number text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPhoneTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Making it so that you can only enter letters into the name of the person text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
