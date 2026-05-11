using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Lotto_Manager_Software
{
    public partial class FrmSettings : Form
    {

        FrmMainMenu frmMainMenu = new FrmMainMenu();  // creating a form object as a global Variable or Field. so it can be used in all methods in this class.
        public FrmSettings(decimal[] price_InstantCard, int[] Quantity_InstantCard)
        {
            InitializeComponent();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // REVISE THIS PART TO LOOP THROUGH SELECTED ITEMS INSTEAD OF JUST ONE ITEM.
            foreach (var item in listCards.SelectedItems)
            {
                string card = item.ToString(); // e.g., "Card #2"

                // Extract the card number from the string
                int cardNumber = int.Parse(card.Replace("Card #", ""));

                // Update price and quantity
                frmMainMenu.Price_InstantCard[cardNumber] = Convert.ToDecimal(txtCardPrice.Text);
                frmMainMenu.Quantity_InstantCard[cardNumber] = Convert.ToInt32(txtQuantityOfCards.Text);

            }

     MessageBox.Show("  Your settings have been updated successfully.\n  Click OK to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // creating a form object.

            frmMainMenu.Show(); // showing the main menu form.

            this.Close();

        }

        private void btnClearCardInfo_Click(object sender, EventArgs e)
        {
            // clear Every Field.

            txtQuantityOfCards.Text = Convert.ToString(0);
            txtBarcode.Text = Convert.ToString(0);
            txtCardPrice.Text = Convert.ToString(0);
            listCards.ClearSelected();  // clear selection in the list box.

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {


            for (int i = 1; i <= 60; i++)
            {
                listCards.Items.Add("Card #" + i.ToString());
            }

            listCards.Text = "";
            listCards.SelectedItem = "No Card Selected";


        }
       
    }
}
