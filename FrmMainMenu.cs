using Lotto_Manager_Software.Properties;
using System.Drawing.Design;
using System.Linq.Expressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lotto_Manager_Software
{
    // Developed by: Ayoub Shinab
    // Developer's Alias : Ayoub The Eastern 
    // Start-Date: 2025-09-21
    // Description: This is the main menu form of the Lotto Manager Software application to manage Scratch-off or instant Cards at a gas station or any other store.
    // The EAST is GREAT.

    public partial class FrmMainMenu : Form
    {
        // Class Scope Variables and also known as Fields, when declared in a class but outside any method.

        // Instant Cards' arrays already been declared here.

        // the InstantCard's Characteristics.....
        public string[] BarCode_InstantCard = new string[61];
        public Image?[] Image_InstantCard = new Image?[61];
        public decimal[] Price_InstantCard = new decimal[61];


        public decimal[] TotalSold_InstantCard = new decimal[61]; // the Amount of Money of each Sold Instant Card $$$
        public int[] CardsForSale_InstantCard = new int[61]; // The number of cards that are ready to be sold.


        // These Arrays are used for calculating how many InstantCards are left & Which number that is the last available InstantCard on 
        public int[] Quantity_InstantCard = new int[61];
        public int[] Remaining_InstantCard = new int[61];
        public int[] Order_InstantCard = new int[61]; // Which number that the instant-card on.



        // GrandTotal Variable to Store the Grand Total Amount "Value" of InstantCards Sold..... $$$MONEY
        public decimal GrandTotalSold_InstantCards;


        // Constructor() "Special Method()" initializes the form and its components. 
        public FrmMainMenu()
        {
            InitializeComponent();
            txtTotalAmount.Text = 0.ToString("c");

        }

        // The ----  BUTTONS  ---  are ----   being -------- set ------- up-------- and -------------  coded ------- here. 

        // Editing and updating The instant Cards Information.....
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //  InstantCardSettingUp.InstantCardSettingsUp(); // Not Used Anymore.

            // here we are passing the Price_InstantCard Array to the FrmSettings Form Class Constructor.
            FrmSettings frmSettings = new FrmSettings(Price_InstantCard, Quantity_InstantCard); // instantiating a Form Object from the FrmSettings Form Class.

            this.Hide();

            frmSettings.Show();

        }


        //  AboutUs Form is run by clicking this button.
        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            // creating an object from the about us form in order to use one of the AboutUs form class's methods.
            FrmAboutUs frmAbouUs = new FrmAboutUs();

            frmAbouUs.Show();

            this.Hide();

        }

        // The Clear Button is used to clear the GrandTotal_InstantCard Variable and CardsForSale_instantCard Array Elements.
        private void btnClear_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= 60; i++)
            {

                CardsForSale_InstantCard[i] = 0; // This statement will be repeated 61 times to reset the values of the elements of the CardForSale array.
                TotalSold_InstantCard[i] = 0;
            }

            // each value of each txtCard.Text property will be reset and assigned a value of ZERO "0".
            txtCard1.Text = 0.ToString();
            txtCard2.Text = 0.ToString(); txtCard3.Text = 0.ToString(); txtCard4.Text = 0.ToString();
            txtCard5.Text = 0.ToString(); txtCard6.Text = 0.ToString(); txtCard7.Text = 0.ToString();
            txtCard8.Text = 0.ToString(); txtCard9.Text = 0.ToString(); txtCard10.Text = 0.ToString();
            txtCard11.Text = 0.ToString(); txtCard12.Text = 0.ToString(); txtCard13.Text = 0.ToString();
            txtCard14.Text = 0.ToString(); txtCard15.Text = 0.ToString(); txtCard16.Text = 0.ToString();
            txtCard17.Text = 0.ToString(); txtCard18.Text = 0.ToString(); txtCard19.Text = 0.ToString();
            txtCard20.Text = 0.ToString(); txtCard21.Text = 0.ToString(); txtCard22.Text = 0.ToString();
            txtCard23.Text = 0.ToString(); txtCard24.Text = 0.ToString(); txtCard25.Text = 0.ToString();
            txtCard26.Text = 0.ToString(); txtCard27.Text = 0.ToString(); txtCard28.Text = 0.ToString();
            txtCard29.Text = 0.ToString(); txtCard30.Text = 0.ToString(); txtCard31.Text = 0.ToString();
            txtCard32.Text = 0.ToString(); txtCard33.Text = 0.ToString(); txtCard34.Text = 0.ToString();
            txtCard35.Text = 0.ToString(); txtCard36.Text = 0.ToString(); txtCard37.Text = 0.ToString();
            txtCard38.Text = 0.ToString(); txtCard39.Text = 0.ToString(); txtCard40.Text = 0.ToString();
            txtCard41.Text = 0.ToString(); txtCard42.Text = 0.ToString(); txtCard43.Text = 0.ToString();
            txtCard44.Text = 0.ToString(); txtCard45.Text = 0.ToString(); txtCard46.Text = 0.ToString();
            txtCard47.Text = 0.ToString(); txtCard48.Text = 0.ToString(); txtCard49.Text = 0.ToString();
            txtCard50.Text = 0.ToString(); txtCard51.Text = 0.ToString(); txtCard52.Text = 0.ToString();
            txtCard53.Text = 0.ToString(); txtCard54.Text = 0.ToString(); txtCard55.Text = 0.ToString();
            txtCard56.Text = 0.ToString(); txtCard57.Text = 0.ToString(); txtCard58.Text = 0.ToString();
            txtCard58.Text = 0.ToString(); txtCard59.Text = 0.ToString(); txtCard60.Text = 0.ToString();


            GrandTotalSold_InstantCards = 0;

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }

        // The Reports Button may/should contain the SQL Code that creates the Database that stores the data and displays it in a GridView.
        private void btnReports_Click(object sender, EventArgs e)
        {

            FrmReports frmReports = new FrmReports();
            this.Hide();
            frmReports.Show();

        }

        // The Submit Button is used to submit or send the data "CardsSold, GrandTotalOfSales and so on to the database to be stored there.
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // Increase Event handlers() "Special Methods()"
        private void btnIncreaseCard1_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[1]++;


            txtCard1.Text = CardsForSale_InstantCard[1].ToString();

            //  Price_InstantCard[1] = 10;


            // Calculating the number of InstantCards Remaining and which number the last InstantCard is on.
            /* Quantity_InstantCard[1]--;
             Order_InstantCard[1] = Quantity_InstantCard[1];
             Remaining_InstantCard[1] = Quantity_InstantCard[1] - CardsForSale_InstantCard[1];

             */

            TotalSold_InstantCard[1] = Price_InstantCard[1] * CardsForSale_InstantCard[1];

            // Grand Total Amount of Cards Sold...................................
            /*  GrandTotalSold_InstantCards = TotalSold_InstantCard[1] + TotalSold_InstantCard[2] + TotalSold_InstantCard[3] + TotalSold_InstantCard[4] + TotalSold_InstantCard[5] +
                    TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                    TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                    TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                    TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                    TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                    TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                    TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                    TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                    TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                    TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                    TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60];

              */

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }
        private void btnIncreaseCard2_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[2]++;
            txtCard2.Text = CardsForSale_InstantCard[2].ToString();


            // Price_InstantCard[2] = 20; // the price of the InstantCard for each piece.


            Remaining_InstantCard[2] = Quantity_InstantCard[2] - CardsForSale_InstantCard[2];

            TotalSold_InstantCard[2] = Price_InstantCard[2] * CardsForSale_InstantCard[2];


            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();


            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard3_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[3]++;

            txtCard3.Text = CardsForSale_InstantCard[3].ToString();

            //  Price_InstantCard[3] = 30; // the price of the InstantCard for each piece.  this value should be set in the Settings Form.


            TotalSold_InstantCard[3] = Price_InstantCard[3] * CardsForSale_InstantCard[3];

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }
        private void btnIncreaseCard4_Click(object sender, EventArgs e)
        {

            CardsForSale_InstantCard[4]++;

            txtCard4.Text = CardsForSale_InstantCard[4].ToString();

            TotalSold_InstantCard[4] = Price_InstantCard[4] * CardsForSale_InstantCard[4];

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }
        private void btnIncreaseCard5_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[5]++;

            txtCard5.Text = CardsForSale_InstantCard[5].ToString();

            TotalSold_InstantCard[5] = Price_InstantCard[5] * CardsForSale_InstantCard[5];

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard6_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[6]++;

            txtCard6.Text = CardsForSale_InstantCard[6].ToString();

            TotalSold_InstantCard[6] = Price_InstantCard[6] * CardsForSale_InstantCard[6];

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }
        private void btnIncreaseCard7_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[7]++;

            txtCard7.Text = CardsForSale_InstantCard[7].ToString();

            TotalSold_InstantCard[7] = Price_InstantCard[7] * CardsForSale_InstantCard[7];

            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard8_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[8]++;
            txtCard8.Text = CardsForSale_InstantCard[8].ToString();
            TotalSold_InstantCard[8] = Price_InstantCard[8] * CardsForSale_InstantCard[8];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard9_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[9]++;
            txtCard9.Text = CardsForSale_InstantCard[9].ToString();
            TotalSold_InstantCard[9] = Price_InstantCard[9] * CardsForSale_InstantCard[9];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard10_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[10]++;
            txtCard10.Text = CardsForSale_InstantCard[10].ToString();
            TotalSold_InstantCard[10] = Price_InstantCard[10] * CardsForSale_InstantCard[10];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard11_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[11]++;
            txtCard11.Text = CardsForSale_InstantCard[11].ToString();
            TotalSold_InstantCard[11] = Price_InstantCard[11] * CardsForSale_InstantCard[11];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard12_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[12]++;
            txtCard12.Text = CardsForSale_InstantCard[12].ToString();
            TotalSold_InstantCard[12] = Price_InstantCard[12] * CardsForSale_InstantCard[12];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard13_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[13]++;
            txtCard13.Text = CardsForSale_InstantCard[13].ToString();
            TotalSold_InstantCard[13] = Price_InstantCard[13] * CardsForSale_InstantCard[13];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard14_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[14]++;
            txtCard14.Text = CardsForSale_InstantCard[14].ToString();
            TotalSold_InstantCard[14] = Price_InstantCard[14] * CardsForSale_InstantCard[14];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard15_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[15]++;
            txtCard15.Text = CardsForSale_InstantCard[15].ToString();
            TotalSold_InstantCard[15] = Price_InstantCard[15] * CardsForSale_InstantCard[15];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard16_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[16]++;
            txtCard16.Text = CardsForSale_InstantCard[16].ToString();
            TotalSold_InstantCard[16] = Price_InstantCard[16] * CardsForSale_InstantCard[16];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard17_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[17]++;
            txtCard17.Text = CardsForSale_InstantCard[17].ToString();
            TotalSold_InstantCard[17] = Price_InstantCard[17] * CardsForSale_InstantCard[17];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard18_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[18]++;
            txtCard18.Text = CardsForSale_InstantCard[18].ToString();
            TotalSold_InstantCard[18] = Price_InstantCard[18] * CardsForSale_InstantCard[18];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard19_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[19]++;
            txtCard19.Text = CardsForSale_InstantCard[19].ToString();
            TotalSold_InstantCard[19] = Price_InstantCard[19] * CardsForSale_InstantCard[19];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard20_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[20]++;
            txtCard20.Text = CardsForSale_InstantCard[20].ToString();
            TotalSold_InstantCard[20] = Price_InstantCard[20] * CardsForSale_InstantCard[20];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard21_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[21]++;
            txtCard21.Text = CardsForSale_InstantCard[21].ToString();
            TotalSold_InstantCard[21] = Price_InstantCard[21] * CardsForSale_InstantCard[21];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard22_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[22]++;
            txtCard22.Text = CardsForSale_InstantCard[22].ToString();
            TotalSold_InstantCard[22] = Price_InstantCard[22] * CardsForSale_InstantCard[22];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard23_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[23]++;
            txtCard23.Text = CardsForSale_InstantCard[23].ToString();
            TotalSold_InstantCard[23] = Price_InstantCard[23] * CardsForSale_InstantCard[23];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard24_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[24]++;
            txtCard24.Text = CardsForSale_InstantCard[24].ToString();
            TotalSold_InstantCard[24] = Price_InstantCard[24] * CardsForSale_InstantCard[24];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard25_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[25]++;
            txtCard25.Text = CardsForSale_InstantCard[25].ToString();
            TotalSold_InstantCard[25] = Price_InstantCard[25] * CardsForSale_InstantCard[25];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard26_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[26]++;
            txtCard26.Text = CardsForSale_InstantCard[26].ToString();
            TotalSold_InstantCard[26] = Price_InstantCard[26] * CardsForSale_InstantCard[26];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard27_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[27]++;
            txtCard27.Text = CardsForSale_InstantCard[27].ToString();
            TotalSold_InstantCard[27] = Price_InstantCard[27] * CardsForSale_InstantCard[27];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard28_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[28]++;
            txtCard28.Text = CardsForSale_InstantCard[28].ToString();
            TotalSold_InstantCard[28] = Price_InstantCard[28] * CardsForSale_InstantCard[28];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard29_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[29]++;
            txtCard29.Text = CardsForSale_InstantCard[29].ToString();
            TotalSold_InstantCard[29] = Price_InstantCard[29] * CardsForSale_InstantCard[29];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard30_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[30]++;
            txtCard30.Text = CardsForSale_InstantCard[30].ToString();
            TotalSold_InstantCard[30] = Price_InstantCard[30] * CardsForSale_InstantCard[30];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard31_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[31]++;
            txtCard31.Text = CardsForSale_InstantCard[31].ToString();
            TotalSold_InstantCard[31] = Price_InstantCard[31] * CardsForSale_InstantCard[31];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard32_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[32]++;
            txtCard32.Text = CardsForSale_InstantCard[32].ToString();
            TotalSold_InstantCard[32] = Price_InstantCard[32] * CardsForSale_InstantCard[32];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard33_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[33]++;
            txtCard33.Text = CardsForSale_InstantCard[33].ToString();
            TotalSold_InstantCard[33] = Price_InstantCard[33] * CardsForSale_InstantCard[33];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard34_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[34]++;
            txtCard34.Text = CardsForSale_InstantCard[34].ToString();
            TotalSold_InstantCard[34] = Price_InstantCard[34] * CardsForSale_InstantCard[34];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard35_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[35]++;
            txtCard35.Text = CardsForSale_InstantCard[35].ToString();
            TotalSold_InstantCard[35] = Price_InstantCard[35] * CardsForSale_InstantCard[35];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard36_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[36]++;
            txtCard36.Text = CardsForSale_InstantCard[36].ToString();
            TotalSold_InstantCard[36] = Price_InstantCard[36] * CardsForSale_InstantCard[36];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard37_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[37]++;
            txtCard37.Text = CardsForSale_InstantCard[37].ToString();
            TotalSold_InstantCard[37] = Price_InstantCard[37] * CardsForSale_InstantCard[37];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard38_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[38]++;
            txtCard38.Text = CardsForSale_InstantCard[38].ToString();
            TotalSold_InstantCard[38] = Price_InstantCard[38] * CardsForSale_InstantCard[38];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard39_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[39]++;
            txtCard39.Text = CardsForSale_InstantCard[39].ToString();
            TotalSold_InstantCard[39] = Price_InstantCard[39] * CardsForSale_InstantCard[39];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard40_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[40]++;
            txtCard40.Text = CardsForSale_InstantCard[40].ToString();
            TotalSold_InstantCard[40] = Price_InstantCard[40] * CardsForSale_InstantCard[40];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard41_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[41]++;
            txtCard41.Text = CardsForSale_InstantCard[41].ToString();
            TotalSold_InstantCard[41] = Price_InstantCard[41] * CardsForSale_InstantCard[41];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard42_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[42]++;
            txtCard42.Text = CardsForSale_InstantCard[42].ToString();
            TotalSold_InstantCard[42] = Price_InstantCard[42] * CardsForSale_InstantCard[42];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard43_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[43]++;
            txtCard43.Text = CardsForSale_InstantCard[43].ToString();
            TotalSold_InstantCard[43] = Price_InstantCard[43] * CardsForSale_InstantCard[43];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard44_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[44]++;
            txtCard44.Text = CardsForSale_InstantCard[44].ToString();
            TotalSold_InstantCard[44] = Price_InstantCard[44] * CardsForSale_InstantCard[44];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard45_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[45]++;
            txtCard45.Text = CardsForSale_InstantCard[45].ToString();
            TotalSold_InstantCard[45] = Price_InstantCard[45] * CardsForSale_InstantCard[45];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard46_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[46]++;
            txtCard46.Text = CardsForSale_InstantCard[46].ToString();
            TotalSold_InstantCard[46] = Price_InstantCard[46] * CardsForSale_InstantCard[46];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard47_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[47]++;
            txtCard47.Text = CardsForSale_InstantCard[47].ToString();
            TotalSold_InstantCard[47] = Price_InstantCard[47] * CardsForSale_InstantCard[47];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard48_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[48]++;
            txtCard48.Text = CardsForSale_InstantCard[48].ToString();
            TotalSold_InstantCard[48] = Price_InstantCard[48] * CardsForSale_InstantCard[48];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard49_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[49]++;
            txtCard49.Text = CardsForSale_InstantCard[49].ToString();
            TotalSold_InstantCard[49] = Price_InstantCard[49] * CardsForSale_InstantCard[49];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard50_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[50]++;
            txtCard50.Text = CardsForSale_InstantCard[50].ToString();
            TotalSold_InstantCard[50] = Price_InstantCard[50] * CardsForSale_InstantCard[50];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard51_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[51]++;
            txtCard51.Text = CardsForSale_InstantCard[51].ToString();
            TotalSold_InstantCard[51] = Price_InstantCard[51] * CardsForSale_InstantCard[51];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard52_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[52]++;
            txtCard52.Text = CardsForSale_InstantCard[52].ToString();
            TotalSold_InstantCard[52] = Price_InstantCard[52] * CardsForSale_InstantCard[52];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard53_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[53]++;
            txtCard53.Text = CardsForSale_InstantCard[53].ToString();
            TotalSold_InstantCard[53] = Price_InstantCard[53] * CardsForSale_InstantCard[53];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard54_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[54]++;
            txtCard54.Text = CardsForSale_InstantCard[54].ToString();
            TotalSold_InstantCard[54] = Price_InstantCard[54] * CardsForSale_InstantCard[54];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard55_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[55]++;
            txtCard55.Text = CardsForSale_InstantCard[55].ToString();
            TotalSold_InstantCard[55] = Price_InstantCard[55] * CardsForSale_InstantCard[55];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard56_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[56]++;
            txtCard56.Text = CardsForSale_InstantCard[56].ToString();
            TotalSold_InstantCard[56] = Price_InstantCard[56] * CardsForSale_InstantCard[56];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard57_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[57]++;
            txtCard57.Text = CardsForSale_InstantCard[57].ToString();
            TotalSold_InstantCard[57] = Price_InstantCard[57] * CardsForSale_InstantCard[57];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard58_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[58]++;
            txtCard58.Text = CardsForSale_InstantCard[58].ToString();
            TotalSold_InstantCard[58] = Price_InstantCard[58] * CardsForSale_InstantCard[58];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnIncreaseCard59_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[59]++;
            txtCard59.Text = CardsForSale_InstantCard[59].ToString();
            TotalSold_InstantCard[59] = Price_InstantCard[59] * CardsForSale_InstantCard[59];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnIncreaseCard60_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[60]++;
            txtCard60.Text = CardsForSale_InstantCard[60].ToString();
            TotalSold_InstantCard[60] = Price_InstantCard[60] * CardsForSale_InstantCard[60];
            GrandTotalSold_InstantCards = TotalSold_InstantCard.Sum();
            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }




        /*
         * 
         * 
         * ----------------------------------------------------------------------------------------------------
         * 
         * 
         * 
         */

        // Decrease  Event handlers() or Special Methods()
        // boolean Expression is an expression that give a true or false value at the runtime and needs a relational "comparison" operator
        private void btnDecreaseCard1_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[1]--;

            if (CardsForSale_InstantCard[1] < 0)
            {
                CardsForSale_InstantCard[1] = 0; // the value of this array element will be assigned To 0.


            }


            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches
            if (CardsForSale_InstantCard[1] >= 0)
            {

                // The Greatness in this line of code is unlimited :) Ayoub is making FUN HAHAHA:)
                // Decrement Assignment Operator is used here.
                TotalSold_InstantCard[1] -= CardsForSale_InstantCard[1] * Price_InstantCard[1];


            }

            if (GrandTotalSold_InstantCards <= 0)
            {
                GrandTotalSold_InstantCards = 0;
            }



            TotalSold_InstantCard[1] = CardsForSale_InstantCard[1] * Price_InstantCard[1];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[1] * Price_InstantCard[1] + (TotalSold_InstantCard[2] + TotalSold_InstantCard[3] + TotalSold_InstantCard[4] + TotalSold_InstantCard[5] +
                  TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);
            ;

            txtCard1.Text = CardsForSale_InstantCard[1].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");


        }


        private void btnDecreaseCard2_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[2]--;


            if (CardsForSale_InstantCard[2] < 0)
            {
                CardsForSale_InstantCard[2] = 0;


            }


            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches
            if (CardsForSale_InstantCard[2] >= 0)
            {

                // The Greatness in this line of code is unlimited :) Ayoub is making FUN HAHAHA:)
                // Decrement Assignment Operator is used here.
                TotalSold_InstantCard[2] -= Price_InstantCard[2];

            }


            if (GrandTotalSold_InstantCards < 0)
            {
                GrandTotalSold_InstantCards = 0;
            }


            TotalSold_InstantCard[2] = CardsForSale_InstantCard[2] * Price_InstantCard[2];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[2] * Price_InstantCard[2] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[3] + TotalSold_InstantCard[4] + TotalSold_InstantCard[5] +
                  TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard2.Text = CardsForSale_InstantCard[2].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard3_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[3]--;

            if (CardsForSale_InstantCard[3] < 0) { CardsForSale_InstantCard[3] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[3] >= 0) { TotalSold_InstantCard[3] -= Price_InstantCard[3]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[3] = CardsForSale_InstantCard[3] * Price_InstantCard[3];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[3] * Price_InstantCard[3] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[4] + TotalSold_InstantCard[5] +
                  TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard3.Text = CardsForSale_InstantCard[3].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard4_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[4]--;

            if (CardsForSale_InstantCard[4] < 0) { CardsForSale_InstantCard[4] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[4] >= 0) { TotalSold_InstantCard[4] -= Price_InstantCard[4]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[4] = CardsForSale_InstantCard[4] * Price_InstantCard[4];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[4] * Price_InstantCard[4] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[5] +
                  TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard4.Text = CardsForSale_InstantCard[4].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard5_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[5]--;

            if (CardsForSale_InstantCard[5] < 0) { CardsForSale_InstantCard[5] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[5] >= 0) { TotalSold_InstantCard[5] -= Price_InstantCard[5]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[5] = CardsForSale_InstantCard[5] * Price_InstantCard[5];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[5] * Price_InstantCard[5] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard5.Text = CardsForSale_InstantCard[5].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard6_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[6]--;

            if (CardsForSale_InstantCard[6] < 0) { CardsForSale_InstantCard[6] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[6] >= 0) { TotalSold_InstantCard[6] -= Price_InstantCard[6]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[6] = CardsForSale_InstantCard[6] * Price_InstantCard[6];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[6] * Price_InstantCard[6] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard6.Text = CardsForSale_InstantCard[6].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard7_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[7]--;

            if (CardsForSale_InstantCard[7] < 0) { CardsForSale_InstantCard[7] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[7] >= 0) { TotalSold_InstantCard[7] -= Price_InstantCard[7]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[7] = CardsForSale_InstantCard[7] * Price_InstantCard[7];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[7] * Price_InstantCard[7] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard7.Text = CardsForSale_InstantCard[7].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard8_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[8]--;

            if (CardsForSale_InstantCard[8] < 0) { CardsForSale_InstantCard[8] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[8] >= 0) { TotalSold_InstantCard[8] -= Price_InstantCard[8]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[8] = CardsForSale_InstantCard[8] * Price_InstantCard[8];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[8] * Price_InstantCard[8] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[9] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard8.Text = CardsForSale_InstantCard[8].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard9_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[9]--;

            if (CardsForSale_InstantCard[9] < 0) { CardsForSale_InstantCard[9] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[9] >= 0) { TotalSold_InstantCard[9] -= Price_InstantCard[9]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[9] = CardsForSale_InstantCard[9] * Price_InstantCard[9];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[9] * Price_InstantCard[9] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[10] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard9.Text = CardsForSale_InstantCard[9].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard10_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[10]--;

            if (CardsForSale_InstantCard[10] < 0) { CardsForSale_InstantCard[10] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[10] >= 0) { TotalSold_InstantCard[10] -= Price_InstantCard[10]; } // -= is subtraction assignment operator.

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[10] = CardsForSale_InstantCard[10] * Price_InstantCard[10];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[10] * Price_InstantCard[10] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard10.Text = CardsForSale_InstantCard[10].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard11_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[11]--;

            if (CardsForSale_InstantCard[11] < 0) { CardsForSale_InstantCard[11] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[11] >= 0) { TotalSold_InstantCard[11] -= Price_InstantCard[11]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[11] = CardsForSale_InstantCard[11] * Price_InstantCard[11];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[11] * Price_InstantCard[11] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard11.Text = CardsForSale_InstantCard[11].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard12_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[12]--;

            if (CardsForSale_InstantCard[12] < 0) { CardsForSale_InstantCard[12] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[12] >= 0) { TotalSold_InstantCard[12] -= Price_InstantCard[12]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[12] = CardsForSale_InstantCard[12] * Price_InstantCard[12];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[12] * Price_InstantCard[12] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard12.Text = CardsForSale_InstantCard[12].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard13_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[13]--;

            if (CardsForSale_InstantCard[13] < 0) { CardsForSale_InstantCard[13] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[13] >= 0) { TotalSold_InstantCard[13] -= Price_InstantCard[13]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[13] = CardsForSale_InstantCard[13] * Price_InstantCard[13];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[13] * Price_InstantCard[13] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[14] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard13.Text = CardsForSale_InstantCard[13].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard14_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[14]--;

            if (CardsForSale_InstantCard[14] < 0) { CardsForSale_InstantCard[14] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[14] >= 0) { TotalSold_InstantCard[14] -= Price_InstantCard[14]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[14] = CardsForSale_InstantCard[14] * Price_InstantCard[14];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[14] * Price_InstantCard[14] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[15] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard14.Text = CardsForSale_InstantCard[14].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard15_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[15]--;

            if (CardsForSale_InstantCard[15] < 0) { CardsForSale_InstantCard[15] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[15] >= 0) { TotalSold_InstantCard[15] -= Price_InstantCard[15]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[15] = CardsForSale_InstantCard[15] * Price_InstantCard[15];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[15] * Price_InstantCard[15] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard15.Text = CardsForSale_InstantCard[15].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard16_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[16]--;

            if (CardsForSale_InstantCard[16] < 0) { CardsForSale_InstantCard[16] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[16] >= 0) { TotalSold_InstantCard[16] -= Price_InstantCard[16]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[16] = CardsForSale_InstantCard[16] * Price_InstantCard[16];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[16] * Price_InstantCard[16] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard16.Text = CardsForSale_InstantCard[16].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard17_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[17]--;

            if (CardsForSale_InstantCard[17] < 0) { CardsForSale_InstantCard[17] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[17] >= 0) { TotalSold_InstantCard[17] -= Price_InstantCard[17]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[17] = CardsForSale_InstantCard[17] * Price_InstantCard[17];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[17] * Price_InstantCard[17] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard17.Text = CardsForSale_InstantCard[17].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard18_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[18]--;

            if (CardsForSale_InstantCard[18] < 0) { CardsForSale_InstantCard[18] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[18] >= 0) { TotalSold_InstantCard[18] -= Price_InstantCard[18]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[18] = CardsForSale_InstantCard[18] * Price_InstantCard[18];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[18] * Price_InstantCard[18] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[19] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard18.Text = CardsForSale_InstantCard[18].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard19_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[19]--;

            if (CardsForSale_InstantCard[19] < 0) { CardsForSale_InstantCard[19] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[19] >= 0) { TotalSold_InstantCard[19] -= Price_InstantCard[19]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[19] = CardsForSale_InstantCard[19] * Price_InstantCard[19];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[19] * Price_InstantCard[19] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[20] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard19.Text = CardsForSale_InstantCard[19].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard20_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[20]--;

            if (CardsForSale_InstantCard[20] < 0) { CardsForSale_InstantCard[20] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[20] >= 0) { TotalSold_InstantCard[20] -= Price_InstantCard[20]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[20] = CardsForSale_InstantCard[20] * Price_InstantCard[20];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[20] * Price_InstantCard[20] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard20.Text = CardsForSale_InstantCard[20].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard21_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[21]--;

            if (CardsForSale_InstantCard[21] < 0) { CardsForSale_InstantCard[21] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[21] >= 0) { TotalSold_InstantCard[21] -= Price_InstantCard[21]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[21] = CardsForSale_InstantCard[21] * Price_InstantCard[21];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[21] * Price_InstantCard[21] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard21.Text = CardsForSale_InstantCard[21].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard22_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[22]--;

            if (CardsForSale_InstantCard[22] < 0) { CardsForSale_InstantCard[22] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[22] >= 0) { TotalSold_InstantCard[22] -= Price_InstantCard[22]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[22] = CardsForSale_InstantCard[22] * Price_InstantCard[22];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[22] * Price_InstantCard[22] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard22.Text = CardsForSale_InstantCard[22].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard23_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[23]--;

            if (CardsForSale_InstantCard[23] < 0) { CardsForSale_InstantCard[23] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[23] >= 0) { TotalSold_InstantCard[23] -= Price_InstantCard[23]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[23] = CardsForSale_InstantCard[23] * Price_InstantCard[23];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[23] * Price_InstantCard[23] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[24] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard23.Text = CardsForSale_InstantCard[23].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard24_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[24]--;

            if (CardsForSale_InstantCard[24] < 0) { CardsForSale_InstantCard[24] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[24] >= 0) { TotalSold_InstantCard[24] -= Price_InstantCard[24]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[24] = CardsForSale_InstantCard[24] * Price_InstantCard[24];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[24] * Price_InstantCard[24] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[25] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard24.Text = CardsForSale_InstantCard[24].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard25_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[25]--;

            if (CardsForSale_InstantCard[25] < 0) { CardsForSale_InstantCard[25] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[25] >= 0) { TotalSold_InstantCard[25] -= Price_InstantCard[25]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[25] = CardsForSale_InstantCard[25] * Price_InstantCard[25];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[25] * Price_InstantCard[25] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard25.Text = CardsForSale_InstantCard[25].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard26_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[26]--;

            if (CardsForSale_InstantCard[26] < 0) { CardsForSale_InstantCard[26] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[26] >= 0) { TotalSold_InstantCard[26] -= Price_InstantCard[26]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[26] = CardsForSale_InstantCard[26] * Price_InstantCard[26];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[26] * Price_InstantCard[26] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard26.Text = CardsForSale_InstantCard[26].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard27_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[27]--;

            if (CardsForSale_InstantCard[27] < 0) { CardsForSale_InstantCard[27] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[27] >= 0) { TotalSold_InstantCard[27] -= Price_InstantCard[27]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[27] = CardsForSale_InstantCard[27] * Price_InstantCard[27];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[27] * Price_InstantCard[27] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard27.Text = CardsForSale_InstantCard[27].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard28_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[28]--;

            if (CardsForSale_InstantCard[28] < 0) { CardsForSale_InstantCard[28] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[28] >= 0) { TotalSold_InstantCard[28] -= Price_InstantCard[28]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[28] = CardsForSale_InstantCard[28] * Price_InstantCard[28];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[28] * Price_InstantCard[28] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[29] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard28.Text = CardsForSale_InstantCard[28].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard29_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[29]--;

            if (CardsForSale_InstantCard[29] < 0) { CardsForSale_InstantCard[29] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[29] >= 0) { TotalSold_InstantCard[29] -= Price_InstantCard[29]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[29] = CardsForSale_InstantCard[29] * Price_InstantCard[29];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[29] * Price_InstantCard[29] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[30] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard29.Text = CardsForSale_InstantCard[29].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard30_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[30]--;

            if (CardsForSale_InstantCard[30] < 0) { CardsForSale_InstantCard[30] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[30] >= 0) { TotalSold_InstantCard[30] -= Price_InstantCard[30]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[30] = CardsForSale_InstantCard[30] * Price_InstantCard[30];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[30] * Price_InstantCard[30] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard30.Text = CardsForSale_InstantCard[30].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard31_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[31]--;

            if (CardsForSale_InstantCard[31] < 0) { CardsForSale_InstantCard[31] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[31] >= 0) { TotalSold_InstantCard[31] -= Price_InstantCard[31]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[31] = CardsForSale_InstantCard[31] * Price_InstantCard[31];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[31] * Price_InstantCard[31] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard31.Text = CardsForSale_InstantCard[31].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard32_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[32]--;

            if (CardsForSale_InstantCard[32] < 0) { CardsForSale_InstantCard[32] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[32] >= 0) { TotalSold_InstantCard[32] -= Price_InstantCard[32]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[32] = CardsForSale_InstantCard[32] * Price_InstantCard[32];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[32] * Price_InstantCard[32] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard32.Text = CardsForSale_InstantCard[32].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard33_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[33]--;

            if (CardsForSale_InstantCard[33] < 0) { CardsForSale_InstantCard[33] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[33] >= 0) { TotalSold_InstantCard[33] -= Price_InstantCard[33]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[33] = CardsForSale_InstantCard[33] * Price_InstantCard[33];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[33] * Price_InstantCard[33] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[34] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard33.Text = CardsForSale_InstantCard[33].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard34_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[34]--;

            if (CardsForSale_InstantCard[34] < 0) { CardsForSale_InstantCard[34] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[34] >= 0) { TotalSold_InstantCard[34] -= Price_InstantCard[34]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[34] = CardsForSale_InstantCard[34] * Price_InstantCard[34];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[34] * Price_InstantCard[34] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[35] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard34.Text = CardsForSale_InstantCard[34].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard35_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[35]--;

            if (CardsForSale_InstantCard[35] < 0) { CardsForSale_InstantCard[35] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[35] >= 0) { TotalSold_InstantCard[35] -= Price_InstantCard[35]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[35] = CardsForSale_InstantCard[35] * Price_InstantCard[35];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[35] * Price_InstantCard[35] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard35.Text = CardsForSale_InstantCard[35].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard36_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[36]--;

            if (CardsForSale_InstantCard[36] < 0) { CardsForSale_InstantCard[36] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[36] >= 0) { TotalSold_InstantCard[36] -= Price_InstantCard[36]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[36] = CardsForSale_InstantCard[36] * Price_InstantCard[36];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[36] * Price_InstantCard[36] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard36.Text = CardsForSale_InstantCard[36].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard37_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[37]--;

            if (CardsForSale_InstantCard[37] < 0) { CardsForSale_InstantCard[37] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[37] >= 0) { TotalSold_InstantCard[37] -= Price_InstantCard[37]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[37] = CardsForSale_InstantCard[37] * Price_InstantCard[37];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[37] * Price_InstantCard[37] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard37.Text = CardsForSale_InstantCard[37].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard38_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[38]--;

            if (CardsForSale_InstantCard[38] < 0) { CardsForSale_InstantCard[38] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[38] >= 0) { TotalSold_InstantCard[38] -= Price_InstantCard[38]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[38] = CardsForSale_InstantCard[38] * Price_InstantCard[38];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[38] * Price_InstantCard[38] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[39] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard38.Text = CardsForSale_InstantCard[38].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard39_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[39]--;

            if (CardsForSale_InstantCard[39] < 0) { CardsForSale_InstantCard[39] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[39] >= 0) { TotalSold_InstantCard[39] -= Price_InstantCard[39]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[39] = CardsForSale_InstantCard[39] * Price_InstantCard[39];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[39] * Price_InstantCard[39] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[40] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard39.Text = CardsForSale_InstantCard[39].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard40_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[40]--;

            if (CardsForSale_InstantCard[40] < 0) { CardsForSale_InstantCard[40] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[40] >= 0) { TotalSold_InstantCard[40] -= Price_InstantCard[40]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[40] = CardsForSale_InstantCard[40] * Price_InstantCard[40];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[40] * Price_InstantCard[40] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard40.Text = CardsForSale_InstantCard[40].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard41_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[41]--;

            if (CardsForSale_InstantCard[41] < 0) { CardsForSale_InstantCard[41] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[41] >= 0) { TotalSold_InstantCard[41] -= Price_InstantCard[41]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[41] = CardsForSale_InstantCard[41] * Price_InstantCard[41];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[41] * Price_InstantCard[41] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard41.Text = CardsForSale_InstantCard[41].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard42_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[42]--;

            if (CardsForSale_InstantCard[42] < 0) { CardsForSale_InstantCard[42] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[42] >= 0) { TotalSold_InstantCard[42] -= Price_InstantCard[42]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[42] = CardsForSale_InstantCard[42] * Price_InstantCard[42];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[42] * Price_InstantCard[42] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard42.Text = CardsForSale_InstantCard[42].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard43_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[43]--;

            if (CardsForSale_InstantCard[43] < 0) { CardsForSale_InstantCard[43] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[43] >= 0) { TotalSold_InstantCard[43] -= Price_InstantCard[43]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[43] = CardsForSale_InstantCard[43] * Price_InstantCard[43];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[43] * Price_InstantCard[43] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[44] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard43.Text = CardsForSale_InstantCard[43].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard44_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[44]--;

            if (CardsForSale_InstantCard[44] < 0) { CardsForSale_InstantCard[44] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[44] >= 0) { TotalSold_InstantCard[44] -= Price_InstantCard[44]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[44] = CardsForSale_InstantCard[44] * Price_InstantCard[44];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[44] * Price_InstantCard[44] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[45] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard44.Text = CardsForSale_InstantCard[44].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard45_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[45]--;

            if (CardsForSale_InstantCard[45] < 0) { CardsForSale_InstantCard[45] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[45] >= 0) { TotalSold_InstantCard[45] -= Price_InstantCard[45]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[45] = CardsForSale_InstantCard[45] * Price_InstantCard[45];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[45] * Price_InstantCard[45] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard45.Text = CardsForSale_InstantCard[45].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard46_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[46]--;

            if (CardsForSale_InstantCard[46] < 0) { CardsForSale_InstantCard[46] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[46] >= 0) { TotalSold_InstantCard[46] -= Price_InstantCard[46]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[46] = CardsForSale_InstantCard[46] * Price_InstantCard[46];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[46] * Price_InstantCard[46] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard46.Text = CardsForSale_InstantCard[46].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard47_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[47]--;

            if (CardsForSale_InstantCard[47] < 0) { CardsForSale_InstantCard[47] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[47] >= 0) { TotalSold_InstantCard[47] -= Price_InstantCard[47]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[47] = CardsForSale_InstantCard[47] * Price_InstantCard[47];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[47] * Price_InstantCard[47] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard47.Text = CardsForSale_InstantCard[47].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard48_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[48]--;

            if (CardsForSale_InstantCard[48] < 0) { CardsForSale_InstantCard[48] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[48] >= 0) { TotalSold_InstantCard[48] -= Price_InstantCard[48]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[48] = CardsForSale_InstantCard[48] * Price_InstantCard[48];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[48] * Price_InstantCard[48] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[49] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard48.Text = CardsForSale_InstantCard[48].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard49_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[49]--;

            if (CardsForSale_InstantCard[49] < 0) { CardsForSale_InstantCard[49] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[49] >= 0) { TotalSold_InstantCard[49] -= Price_InstantCard[49]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[49] = CardsForSale_InstantCard[49] * Price_InstantCard[49];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[49] * Price_InstantCard[49] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[50] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard49.Text = CardsForSale_InstantCard[49].ToString();


            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard50_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[50]--;

            if (CardsForSale_InstantCard[50] < 0) { CardsForSale_InstantCard[50] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[50] >= 0) { TotalSold_InstantCard[50] -= Price_InstantCard[50]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[50] = CardsForSale_InstantCard[50] * Price_InstantCard[50];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[50] * Price_InstantCard[50] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard50.Text = CardsForSale_InstantCard[50].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard51_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[51]--;

            if (CardsForSale_InstantCard[51] < 0) { CardsForSale_InstantCard[51] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[51] >= 0) { TotalSold_InstantCard[51] -= Price_InstantCard[51]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[51] = CardsForSale_InstantCard[51] * Price_InstantCard[51];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[51] * Price_InstantCard[51] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard51.Text = CardsForSale_InstantCard[51].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard52_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[52]--;

            if (CardsForSale_InstantCard[52] < 0) { CardsForSale_InstantCard[52] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[52] >= 0) { TotalSold_InstantCard[52] -= Price_InstantCard[52]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[52] = CardsForSale_InstantCard[52] * Price_InstantCard[52];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[51] * Price_InstantCard[51] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard52.Text = CardsForSale_InstantCard[52].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard53_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[53]--;

            if (CardsForSale_InstantCard[53] < 0) { CardsForSale_InstantCard[53] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[53] >= 0) { TotalSold_InstantCard[53] -= Price_InstantCard[53]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[53] = CardsForSale_InstantCard[53] * Price_InstantCard[53];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[51] * Price_InstantCard[51] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[54] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard53.Text = CardsForSale_InstantCard[53].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard54_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[54]--;

            if (CardsForSale_InstantCard[54] < 0) { CardsForSale_InstantCard[54] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[54] >= 0) { TotalSold_InstantCard[54] -= Price_InstantCard[54]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[54] = CardsForSale_InstantCard[54] * Price_InstantCard[54];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[54] * Price_InstantCard[54] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[55] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard54.Text = CardsForSale_InstantCard[54].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard55_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[55]--;

            if (CardsForSale_InstantCard[55] < 0) { CardsForSale_InstantCard[55] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[55] >= 0) { TotalSold_InstantCard[55] -= Price_InstantCard[55]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[55] = CardsForSale_InstantCard[55] * Price_InstantCard[55];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[55] * Price_InstantCard[55] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard55.Text = CardsForSale_InstantCard[55].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard56_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[56]--;

            if (CardsForSale_InstantCard[56] < 0) { CardsForSale_InstantCard[56] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[56] >= 0) { TotalSold_InstantCard[56] -= Price_InstantCard[56]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[56] = CardsForSale_InstantCard[56] * Price_InstantCard[56];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[56] * Price_InstantCard[56] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[55] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard56.Text = CardsForSale_InstantCard[56].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard57_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[57]--;

            if (CardsForSale_InstantCard[57] < 0) { CardsForSale_InstantCard[57] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[57] >= 0) { TotalSold_InstantCard[57] -= Price_InstantCard[57]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[57] = CardsForSale_InstantCard[57] * Price_InstantCard[57];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[57] * Price_InstantCard[57] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[55] + TotalSold_InstantCard[56] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard57.Text = CardsForSale_InstantCard[57].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard58_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[58]--;

            if (CardsForSale_InstantCard[58] < 0) { CardsForSale_InstantCard[58] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[58] >= 0) { TotalSold_InstantCard[58] -= Price_InstantCard[58]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[58] = CardsForSale_InstantCard[58] * Price_InstantCard[58];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[58] * Price_InstantCard[58] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[55] + TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[59] + TotalSold_InstantCard[60]);

            txtCard58.Text = CardsForSale_InstantCard[58].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }
        private void btnDecreaseCard59_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[59]--;

            if (CardsForSale_InstantCard[59] < 0) { CardsForSale_InstantCard[59] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[59] >= 0) { TotalSold_InstantCard[59] -= Price_InstantCard[59]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[59] = CardsForSale_InstantCard[59] * Price_InstantCard[59];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[59] * Price_InstantCard[59] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[55] + TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[60]);

            txtCard59.Text = CardsForSale_InstantCard[59].ToString();


            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");

        }
        private void btnDecreaseCard60_Click(object sender, EventArgs e)
        {
            CardsForSale_InstantCard[60]--;

            if (CardsForSale_InstantCard[60] < 0) { CardsForSale_InstantCard[60] = 0; }
            // This if statement is used to stop decreasing or decrementing once the value of CardsForSale reaches the zero value.
            if (CardsForSale_InstantCard[60] >= 0) { TotalSold_InstantCard[60] -= Price_InstantCard[60]; }

            if (GrandTotalSold_InstantCards < 0) { GrandTotalSold_InstantCards = 0; }

            TotalSold_InstantCard[60] = CardsForSale_InstantCard[60] * Price_InstantCard[60];

            GrandTotalSold_InstantCards = CardsForSale_InstantCard[60] * Price_InstantCard[60] + (TotalSold_InstantCard[1] + TotalSold_InstantCard[2] +
                  TotalSold_InstantCard[3] + TotalSold_InstantCard[4] +
                  TotalSold_InstantCard[5] + TotalSold_InstantCard[6] + TotalSold_InstantCard[7] + TotalSold_InstantCard[8] + TotalSold_InstantCard[9] +
                  TotalSold_InstantCard[10] + TotalSold_InstantCard[11] + TotalSold_InstantCard[12] + TotalSold_InstantCard[13] + TotalSold_InstantCard[14] +
                  TotalSold_InstantCard[15] + TotalSold_InstantCard[16] + TotalSold_InstantCard[17] + TotalSold_InstantCard[18] + TotalSold_InstantCard[19] +
                  TotalSold_InstantCard[20] + TotalSold_InstantCard[21] + TotalSold_InstantCard[22] + TotalSold_InstantCard[23] + TotalSold_InstantCard[24] +
                  TotalSold_InstantCard[25] + TotalSold_InstantCard[26] + TotalSold_InstantCard[27] + TotalSold_InstantCard[28] + TotalSold_InstantCard[29] +
                  TotalSold_InstantCard[30] + TotalSold_InstantCard[31] + TotalSold_InstantCard[32] + TotalSold_InstantCard[33] + TotalSold_InstantCard[34] +
                  TotalSold_InstantCard[35] + TotalSold_InstantCard[36] + TotalSold_InstantCard[37] + TotalSold_InstantCard[38] + TotalSold_InstantCard[39] +
                  TotalSold_InstantCard[40] + TotalSold_InstantCard[41] + TotalSold_InstantCard[42] + TotalSold_InstantCard[43] + TotalSold_InstantCard[44] +
                  TotalSold_InstantCard[45] + TotalSold_InstantCard[46] + TotalSold_InstantCard[47] + TotalSold_InstantCard[48] + TotalSold_InstantCard[49] +
                  TotalSold_InstantCard[50] + TotalSold_InstantCard[51] + TotalSold_InstantCard[52] + TotalSold_InstantCard[53] + TotalSold_InstantCard[54] +
                  TotalSold_InstantCard[55] + TotalSold_InstantCard[56] + TotalSold_InstantCard[57] + TotalSold_InstantCard[58] + TotalSold_InstantCard[59]);

            txtCard60.Text = CardsForSale_InstantCard[60].ToString();

            txtTotalAmount.Text = GrandTotalSold_InstantCards.ToString("c");
        }



    }

}

    