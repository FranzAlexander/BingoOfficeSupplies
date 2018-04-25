namespace BingoOffficeSupplies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_productList = new System.Windows.Forms.ListBox();
            this.pic_pictureLoc = new System.Windows.Forms.PictureBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_nameLbl = new System.Windows.Forms.Label();
            this.lbl_showPriceLbl = new System.Windows.Forms.Label();
            this.btn_sellProduct = new System.Windows.Forms.Button();
            this.pnl_panel1 = new System.Windows.Forms.Panel();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.pnl_panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userPhoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCostTxt = new System.Windows.Forms.TextBox();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.txt_panelPName = new System.Windows.Forms.TextBox();
            this.btn_confrim = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_invNum = new System.Windows.Forms.TextBox();
            this.invNumLbl = new System.Windows.Forms.Label();
            this.txt_enteredAmount = new System.Windows.Forms.TextBox();
            this.enterAmountLbl = new System.Windows.Forms.Label();
            this.txt_perOne = new System.Windows.Forms.TextBox();
            this.costPerOneLbl = new System.Windows.Forms.Label();
            this.pic_panel = new System.Windows.Forms.PictureBox();
            this.panelNameLbl = new System.Windows.Forms.Label();
            this.btn_closeBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pictureLoc)).BeginInit();
            this.pnl_panel1.SuspendLayout();
            this.pnl_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_productList
            // 
            this.lst_productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_productList.FormattingEnabled = true;
            this.lst_productList.ItemHeight = 20;
            this.lst_productList.Location = new System.Drawing.Point(12, 12);
            this.lst_productList.Name = "lst_productList";
            this.lst_productList.Size = new System.Drawing.Size(160, 204);
            this.lst_productList.TabIndex = 0;
            this.lst_productList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productList_MouseClick);
            // 
            // pic_pictureLoc
            // 
            this.pic_pictureLoc.Location = new System.Drawing.Point(12, 222);
            this.pic_pictureLoc.Name = "pic_pictureLoc";
            this.pic_pictureLoc.Size = new System.Drawing.Size(160, 130);
            this.pic_pictureLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pictureLoc.TabIndex = 1;
            this.pic_pictureLoc.TabStop = false;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(12, 355);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(48, 16);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "Name:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(130, 355);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(42, 16);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_nameLbl
            // 
            this.lbl_nameLbl.AutoSize = true;
            this.lbl_nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameLbl.Location = new System.Drawing.Point(12, 371);
            this.lbl_nameLbl.Name = "lbl_nameLbl";
            this.lbl_nameLbl.Size = new System.Drawing.Size(13, 16);
            this.lbl_nameLbl.TabIndex = 4;
            this.lbl_nameLbl.Text = "*";
            // 
            // lbl_showPriceLbl
            // 
            this.lbl_showPriceLbl.AutoSize = true;
            this.lbl_showPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showPriceLbl.Location = new System.Drawing.Point(130, 371);
            this.lbl_showPriceLbl.Name = "lbl_showPriceLbl";
            this.lbl_showPriceLbl.Size = new System.Drawing.Size(13, 16);
            this.lbl_showPriceLbl.TabIndex = 5;
            this.lbl_showPriceLbl.Text = "*";
            // 
            // btn_sellProduct
            // 
            this.btn_sellProduct.Location = new System.Drawing.Point(12, 417);
            this.btn_sellProduct.Name = "btn_sellProduct";
            this.btn_sellProduct.Size = new System.Drawing.Size(160, 46);
            this.btn_sellProduct.TabIndex = 6;
            this.btn_sellProduct.Text = "Sell Product";
            this.btn_sellProduct.UseVisualStyleBackColor = true;
            this.btn_sellProduct.Click += new System.EventHandler(this.sellProduct_Click);
            // 
            // pnl_panel1
            // 
            this.pnl_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_panel1.Controls.Add(this.btn_purchase);
            this.pnl_panel1.Controls.Add(this.pnl_panel2);
            this.pnl_panel1.Controls.Add(this.totalCostTxt);
            this.pnl_panel1.Controls.Add(this.totalCostLbl);
            this.pnl_panel1.Controls.Add(this.txt_panelPName);
            this.pnl_panel1.Controls.Add(this.btn_confrim);
            this.pnl_panel1.Controls.Add(this.btn_cancel);
            this.pnl_panel1.Controls.Add(this.txt_invNum);
            this.pnl_panel1.Controls.Add(this.invNumLbl);
            this.pnl_panel1.Controls.Add(this.txt_enteredAmount);
            this.pnl_panel1.Controls.Add(this.enterAmountLbl);
            this.pnl_panel1.Controls.Add(this.txt_perOne);
            this.pnl_panel1.Controls.Add(this.costPerOneLbl);
            this.pnl_panel1.Controls.Add(this.pic_panel);
            this.pnl_panel1.Controls.Add(this.panelNameLbl);
            this.pnl_panel1.Location = new System.Drawing.Point(178, 12);
            this.pnl_panel1.Name = "pnl_panel1";
            this.pnl_panel1.Size = new System.Drawing.Size(354, 375);
            this.pnl_panel1.TabIndex = 7;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(15, 165);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(302, 35);
            this.btn_purchase.TabIndex = 26;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // pnl_panel2
            // 
            this.pnl_panel2.Controls.Add(this.label1);
            this.pnl_panel2.Controls.Add(this.userPhoneTxt);
            this.pnl_panel2.Controls.Add(this.label4);
            this.pnl_panel2.Controls.Add(this.label3);
            this.pnl_panel2.Controls.Add(this.discountTxt);
            this.pnl_panel2.Controls.Add(this.userNameTxt);
            this.pnl_panel2.Controls.Add(this.label2);
            this.pnl_panel2.Location = new System.Drawing.Point(3, 201);
            this.pnl_panel2.Name = "pnl_panel2";
            this.pnl_panel2.Size = new System.Drawing.Size(346, 100);
            this.pnl_panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "You have earned a 5% discount";
            // 
            // userPhoneTxt
            // 
            this.userPhoneTxt.Location = new System.Drawing.Point(175, 27);
            this.userPhoneTxt.Name = "userPhoneTxt";
            this.userPhoneTxt.Size = new System.Drawing.Size(133, 20);
            this.userPhoneTxt.TabIndex = 23;
            this.userPhoneTxt.TextChanged += new System.EventHandler(this.userPhoneTxt_TextChanged);
            this.userPhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userPhoneTXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Update Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter Phone Number:";
            // 
            // discountTxt
            // 
            this.discountTxt.Location = new System.Drawing.Point(206, 77);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(100, 20);
            this.discountTxt.TabIndex = 24;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(6, 27);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(133, 20);
            this.userNameTxt.TabIndex = 21;
            this.userNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Name:";
            // 
            // totalCostTxt
            // 
            this.totalCostTxt.Location = new System.Drawing.Point(215, 139);
            this.totalCostTxt.Name = "totalCostTxt";
            this.totalCostTxt.Size = new System.Drawing.Size(102, 20);
            this.totalCostTxt.TabIndex = 20;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLbl.Location = new System.Drawing.Point(212, 120);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(72, 16);
            this.totalCostLbl.TabIndex = 19;
            this.totalCostLbl.Text = "Total Cost:";
            // 
            // txt_panelPName
            // 
            this.txt_panelPName.Location = new System.Drawing.Point(256, 6);
            this.txt_panelPName.Name = "txt_panelPName";
            this.txt_panelPName.Size = new System.Drawing.Size(95, 20);
            this.txt_panelPName.TabIndex = 18;
            // 
            // btn_confrim
            // 
            this.btn_confrim.Location = new System.Drawing.Point(213, 324);
            this.btn_confrim.Name = "btn_confrim";
            this.btn_confrim.Size = new System.Drawing.Size(136, 46);
            this.btn_confrim.TabIndex = 17;
            this.btn_confrim.Text = "Confirm Sale";
            this.btn_confrim.UseVisualStyleBackColor = true;
            this.btn_confrim.Click += new System.EventHandler(this.confrimBtn_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(3, 324);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 46);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel Sale";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // txt_invNum
            // 
            this.txt_invNum.Location = new System.Drawing.Point(256, 51);
            this.txt_invNum.Name = "txt_invNum";
            this.txt_invNum.Size = new System.Drawing.Size(95, 20);
            this.txt_invNum.TabIndex = 15;
            // 
            // invNumLbl
            // 
            this.invNumLbl.AutoSize = true;
            this.invNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invNumLbl.Location = new System.Drawing.Point(145, 52);
            this.invNumLbl.Name = "invNumLbl";
            this.invNumLbl.Size = new System.Drawing.Size(105, 16);
            this.invNumLbl.TabIndex = 14;
            this.invNumLbl.Text = "Invoice Number:";
            // 
            // txt_enteredAmount
            // 
            this.txt_enteredAmount.Location = new System.Drawing.Point(15, 139);
            this.txt_enteredAmount.Name = "txt_enteredAmount";
            this.txt_enteredAmount.Size = new System.Drawing.Size(194, 20);
            this.txt_enteredAmount.TabIndex = 13;
            this.txt_enteredAmount.TextChanged += new System.EventHandler(this.enteredAmountTxt_TextChanged);
            // 
            // enterAmountLbl
            // 
            this.enterAmountLbl.AutoSize = true;
            this.enterAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAmountLbl.Location = new System.Drawing.Point(6, 120);
            this.enterAmountLbl.Name = "enterAmountLbl";
            this.enterAmountLbl.Size = new System.Drawing.Size(200, 16);
            this.enterAmountLbl.TabIndex = 10;
            this.enterAmountLbl.Text = "Enter amount that you would like:";
            // 
            // txt_perOne
            // 
            this.txt_perOne.Location = new System.Drawing.Point(256, 29);
            this.txt_perOne.Name = "txt_perOne";
            this.txt_perOne.Size = new System.Drawing.Size(95, 20);
            this.txt_perOne.TabIndex = 12;
            // 
            // costPerOneLbl
            // 
            this.costPerOneLbl.AutoSize = true;
            this.costPerOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerOneLbl.Location = new System.Drawing.Point(145, 30);
            this.costPerOneLbl.Name = "costPerOneLbl";
            this.costPerOneLbl.Size = new System.Drawing.Size(90, 16);
            this.costPerOneLbl.TabIndex = 10;
            this.costPerOneLbl.Text = "Cost Per One:";
            // 
            // pic_panel
            // 
            this.pic_panel.Location = new System.Drawing.Point(3, 3);
            this.pic_panel.Name = "pic_panel";
            this.pic_panel.Size = new System.Drawing.Size(136, 100);
            this.pic_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_panel.TabIndex = 0;
            this.pic_panel.TabStop = false;
            // 
            // panelNameLbl
            // 
            this.panelNameLbl.AutoSize = true;
            this.panelNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNameLbl.Location = new System.Drawing.Point(145, 7);
            this.panelNameLbl.Name = "panelNameLbl";
            this.panelNameLbl.Size = new System.Drawing.Size(48, 16);
            this.panelNameLbl.TabIndex = 9;
            this.panelNameLbl.Text = "Name:";
            // 
            // btn_closeBus
            // 
            this.btn_closeBus.Location = new System.Drawing.Point(178, 417);
            this.btn_closeBus.Name = "btn_closeBus";
            this.btn_closeBus.Size = new System.Drawing.Size(354, 46);
            this.btn_closeBus.TabIndex = 8;
            this.btn_closeBus.Text = "Close of Business";
            this.btn_closeBus.UseVisualStyleBackColor = true;
            this.btn_closeBus.Click += new System.EventHandler(this.closeBusBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 475);
            this.Controls.Add(this.btn_closeBus);
            this.Controls.Add(this.pnl_panel1);
            this.Controls.Add(this.btn_sellProduct);
            this.Controls.Add(this.lbl_showPriceLbl);
            this.Controls.Add(this.lbl_nameLbl);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.pic_pictureLoc);
            this.Controls.Add(this.lst_productList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_pictureLoc)).EndInit();
            this.pnl_panel1.ResumeLayout(false);
            this.pnl_panel1.PerformLayout();
            this.pnl_panel2.ResumeLayout(false);
            this.pnl_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_productList;
        private System.Windows.Forms.PictureBox pic_pictureLoc;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_nameLbl;
        private System.Windows.Forms.Label lbl_showPriceLbl;
        private System.Windows.Forms.Button btn_sellProduct;
        private System.Windows.Forms.Panel pnl_panel1;
        private System.Windows.Forms.Button btn_closeBus;
        private System.Windows.Forms.PictureBox pic_panel;
        private System.Windows.Forms.TextBox txt_perOne;
        private System.Windows.Forms.Label costPerOneLbl;
        private System.Windows.Forms.Label panelNameLbl;
        private System.Windows.Forms.TextBox txt_invNum;
        private System.Windows.Forms.Label invNumLbl;
        private System.Windows.Forms.Label enterAmountLbl;
        private System.Windows.Forms.Button btn_confrim;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_enteredAmount;
        private System.Windows.Forms.TextBox txt_panelPName;
        private System.Windows.Forms.TextBox totalCostTxt;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userPhoneTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_panel2;
        private System.Windows.Forms.Button btn_purchase;
    }
}

