using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_Manager_Software
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {

            // Load report data into the DataGridView when the form loads.


            // Add 60 rows to the DataGridView dGridView1.
            for (int i = 0; i < 60; i++) { dGridView1.Rows.Add(); }


            // Add 60 rows to the DataGridView dGridView2.
            for (int i = 0; i < 60; i++) { dGridView2.Rows.Add(); }



            // Add 60 rows to the DataGridView dGridView3.
            for (int i = 0; i < 60; i++) { dGridView3.Rows.Add(); }





            // Fill the first column of dGridView1 with numbers 1 to 60. the index of Instant Cards.
            for (int i = 0; i < 60; i++) { dGridView1.Rows[i].Cells[0].Value = i + 1; }



            // Fill the first column of dGridView1 with numbers 1 to 60. the index of Instant Cards.
            for (int i = 0; i < 60; i++) { dGridView2.Rows[i].Cells[0].Value = i + 1; }


            // Fill the first column of dGridView1 with numbers 1 to 60. the index of Instant Cards.
            for (int i = 0; i < 60; i++) { dGridView3.Rows[i].Cells[0].Value = i + 1; }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            FrmMainMenu frmMainMenu = new FrmMainMenu(); // creating a form object.

            frmMainMenu.Show(); // showing the main menu form.

            this.Close();


        }
    }
}
