using CarWindowsApp.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWindowsApp
{
    public partial class frmcarshop : Form
    {
        Store store = new Store();
        public frmcarshop()
        {
            InitializeComponent();
        }

        private void frmcarshop_Load(object sender, EventArgs e)
        {

        }

        private void btnadacar_Click(object sender, EventArgs e)
        {
            if (txtbrand.Text == "")
            {
                MessageBox.Show("Du har ikke indtastet noget bilmærke!");
            }
            else if (txtmodel.Text == "")
            {
                MessageBox.Show("Du har ikke indtastet nogen bilmodel!");
            }
            else if (txtcolor.Text == "")
            {
                MessageBox.Show("Du har ikke indtastet nogen farve på bilen!");
            }
            else if (txtprice.Text == "")
            {
                MessageBox.Show("Du har ikke indtastet nogen pris!");
            }
            else
            {
                if (Int32.TryParse(txtprice.Text, out int numValue))
                {
                    Car c = new Car(txtbrand.Text, txtmodel.Text, txtcolor.Text, int.Parse(txtprice.Text));
                    store.stock.Add(c);
                    lstinventory.Items.Add("Specifikationer: " + c.brand + " " + c.model + " " + c.color + " " + c.price);
                }
                else
                {
                    MessageBox.Show("Du kan kun indtaste en nummerisk værdi i prisfeltet!");
                }
            }
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (lstinventory.Items.Count > 0)
            {
                if (lstinventory.SelectedIndex < 0)
                {
                    MessageBox.Show("Du har ikke markeret en bil fra lagerbeholdningen!");
                }
                else
                {
                    string selectedCar = lstinventory.SelectedItem.ToString();
                    lstshoppingcart.Items.Add(selectedCar);
                    store.kurv.Add(lstinventory.Items.IndexOf(lstinventory.SelectedItem));
                }
            }
            else
            {
                MessageBox.Show("Der er ingen biler i lagerbeholdningen!");
            }
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in store.kurv)
            {
                sum += store.stock[i].price;
            }
            lbltotalprice.Text = sum.ToString() + " kr.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
