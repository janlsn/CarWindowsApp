
namespace CarWindowsApp
{
    partial class frmcarshop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.btnadacar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstinventory = new System.Windows.Forms.ListBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncheckout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.lstshoppingcart = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtcolor);
            this.groupBox1.Controls.Add(this.txtmodel);
            this.groupBox1.Controls.Add(this.txtbrand);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.lblcolor);
            this.groupBox1.Controls.Add(this.lblmodel);
            this.groupBox1.Controls.Add(this.lblbrand);
            this.groupBox1.Controls.Add(this.btnadacar);
            this.groupBox1.Location = new System.Drawing.Point(25, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tilføj en bil";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(64, 145);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 10;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(64, 107);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 20);
            this.txtcolor.TabIndex = 9;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(64, 65);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(100, 20);
            this.txtmodel.TabIndex = 8;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(64, 28);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(100, 20);
            this.txtbrand.TabIndex = 7;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(6, 148);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(27, 13);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "Pris:";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(6, 110);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(37, 13);
            this.lblcolor.TabIndex = 5;
            this.lblcolor.Text = "Farve:";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(6, 68);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(39, 13);
            this.lblmodel.TabIndex = 4;
            this.lblmodel.Text = "Model:";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(6, 31);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(44, 13);
            this.lblbrand.TabIndex = 3;
            this.lblbrand.Text = "Mærke:";
            // 
            // btnadacar
            // 
            this.btnadacar.Location = new System.Drawing.Point(64, 220);
            this.btnadacar.Name = "btnadacar";
            this.btnadacar.Size = new System.Drawing.Size(75, 23);
            this.btnadacar.TabIndex = 2;
            this.btnadacar.Text = "Tilføj";
            this.btnadacar.UseVisualStyleBackColor = true;
            this.btnadacar.Click += new System.EventHandler(this.btnadacar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstinventory);
            this.groupBox2.Location = new System.Drawing.Point(278, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lagerbeholdning";
            // 
            // lstinventory
            // 
            this.lstinventory.FormattingEnabled = true;
            this.lstinventory.Location = new System.Drawing.Point(6, 19);
            this.lstinventory.Name = "lstinventory";
            this.lstinventory.Size = new System.Drawing.Size(208, 394);
            this.lstinventory.TabIndex = 0;
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.Location = new System.Drawing.Point(505, 191);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(139, 23);
            this.btnaddtocart.TabIndex = 2;
            this.btnaddtocart.Text = "Læg i indkøbskurv -->";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncheckout);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbltotalprice);
            this.groupBox3.Controls.Add(this.lstshoppingcart);
            this.groupBox3.Location = new System.Drawing.Point(650, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 423);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indkøbskurv";
            // 
            // btncheckout
            // 
            this.btncheckout.Location = new System.Drawing.Point(68, 355);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(84, 23);
            this.btncheckout.TabIndex = 6;
            this.btncheckout.Text = "Gå til kassen";
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Samlet pris:";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(65, 399);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(28, 13);
            this.lbltotalprice.TabIndex = 5;
            this.lbltotalprice.Text = "0 kr.";
            // 
            // lstshoppingcart
            // 
            this.lstshoppingcart.FormattingEnabled = true;
            this.lstshoppingcart.Location = new System.Drawing.Point(6, 19);
            this.lstshoppingcart.Name = "lstshoppingcart";
            this.lstshoppingcart.Size = new System.Drawing.Size(197, 316);
            this.lstshoppingcart.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afslut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmcarshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcarshop";
            this.Text = "CarShop";
            this.Load += new System.EventHandler(this.frmcarshop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Button btnadacar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstinventory;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.ListBox lstshoppingcart;
        private System.Windows.Forms.Button button1;
    }
}

