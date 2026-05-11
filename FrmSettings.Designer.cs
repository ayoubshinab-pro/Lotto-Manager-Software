namespace Lotto_Manager_Software
{
    partial class FrmSettings
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
            lblSettingsTitle = new Label();
            panel1 = new Panel();
            listCards = new ListBox();
            btnSubmit = new Button();
            btnClearCardInfo = new Button();
            btnSave = new Button();
            txtCardPrice = new TextBox();
            lblCardPrice = new Label();
            txtBarcode = new TextBox();
            lblBarCode = new Label();
            txtQuantityOfCards = new TextBox();
            lblInstruction = new Label();
            lblInstantCardQuantity = new Label();
            lblCarNumber = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.BackColor = Color.Snow;
            lblSettingsTitle.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsTitle.Location = new Point(420, 9);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(458, 61);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "Lottery Settings";
            lblSettingsTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(listCards);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnClearCardInfo);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtCardPrice);
            panel1.Controls.Add(lblCardPrice);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(lblBarCode);
            panel1.Controls.Add(txtQuantityOfCards);
            panel1.Controls.Add(lblInstruction);
            panel1.Controls.Add(lblInstantCardQuantity);
            panel1.Controls.Add(lblCarNumber);
            panel1.Location = new Point(269, 88);
            panel1.MinimumSize = new Size(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 615);
            panel1.TabIndex = 3;
            // 
            // listCards
            // 
            listCards.FormattingEnabled = true;
            listCards.Location = new Point(27, 96);
            listCards.MultiColumn = true;
            listCards.Name = "listCards";
            listCards.SelectionMode = SelectionMode.MultiSimple;
            listCards.Size = new Size(690, 244);
            listCards.TabIndex = 16;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Yellow;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(301, 534);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 60);
            btnSubmit.TabIndex = 15;
            btnSubmit.TabStop = false;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClearCardInfo
            // 
            btnClearCardInfo.BackColor = Color.Red;
            btnClearCardInfo.Cursor = Cursors.Hand;
            btnClearCardInfo.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnClearCardInfo.Location = new Point(592, 534);
            btnClearCardInfo.Name = "btnClearCardInfo";
            btnClearCardInfo.Size = new Size(125, 60);
            btnClearCardInfo.TabIndex = 14;
            btnClearCardInfo.Text = "Clear";
            btnClearCardInfo.UseVisualStyleBackColor = false;
            btnClearCardInfo.Click += btnClearCardInfo_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(23, 534);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 60);
            btnSave.TabIndex = 13;
            btnSave.TabStop = false;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCardPrice
            // 
            txtCardPrice.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            txtCardPrice.Location = new Point(195, 463);
            txtCardPrice.Name = "txtCardPrice";
            txtCardPrice.Size = new Size(245, 29);
            txtCardPrice.TabIndex = 9;
            txtCardPrice.TabStop = false;
            txtCardPrice.Text = "0";
            txtCardPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCardPrice
            // 
            lblCardPrice.AutoSize = true;
            lblCardPrice.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            lblCardPrice.Location = new Point(42, 468);
            lblCardPrice.Name = "lblCardPrice";
            lblCardPrice.Size = new Size(106, 24);
            lblCardPrice.TabIndex = 8;
            lblCardPrice.Text = "Card Price :";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            txtBarcode.Location = new Point(195, 414);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(245, 29);
            txtBarcode.TabIndex = 7;
            txtBarcode.TabStop = false;
            txtBarcode.Text = "0";
            txtBarcode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            lblBarCode.Location = new Point(42, 417);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(136, 24);
            lblBarCode.TabIndex = 6;
            lblBarCode.Text = "Card BarCode :";
            // 
            // txtQuantityOfCards
            // 
            txtQuantityOfCards.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            txtQuantityOfCards.Location = new Point(195, 359);
            txtQuantityOfCards.Name = "txtQuantityOfCards";
            txtQuantityOfCards.Size = new Size(245, 29);
            txtQuantityOfCards.TabIndex = 5;
            txtQuantityOfCards.TabStop = false;
            txtQuantityOfCards.Text = "0";
            txtQuantityOfCards.TextAlign = HorizontalAlignment.Center;
            // 
            // lblInstruction
            // 
            lblInstruction.BackColor = Color.Snow;
            lblInstruction.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruction.Location = new Point(151, 11);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(458, 42);
            lblInstruction.TabIndex = 4;
            lblInstruction.Text = "Instant Card Information";
            lblInstruction.TextAlign = ContentAlignment.TopCenter;
            
            // 
            // lblInstantCardQuantity
            // 
            lblInstantCardQuantity.AutoSize = true;
            lblInstantCardQuantity.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            lblInstantCardQuantity.Location = new Point(42, 362);
            lblInstantCardQuantity.Name = "lblInstantCardQuantity";
            lblInstantCardQuantity.Size = new Size(95, 24);
            lblInstantCardQuantity.TabIndex = 4;
            lblInstantCardQuantity.Text = "Quantity :";
            // 
            // lblCarNumber
            // 
            lblCarNumber.AutoSize = true;
            lblCarNumber.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
            lblCarNumber.Location = new Point(27, 53);
            lblCarNumber.Name = "lblCarNumber";
            lblCarNumber.Size = new Size(146, 24);
            lblCarNumber.TabIndex = 3;
            lblCarNumber.Text = "Select Number :";
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1262, 743);
            Controls.Add(panel1);
            Controls.Add(lblSettingsTitle);
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lotto Manager Software";
            Load += FrmSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);




        }

        #endregion

        private Label lblSettingsTitle;
        private Label lblCarNumber;
        private Label lblInstantCardQuantity;
        private Label lblInstruction;
        private TextBox txtQuantityOfCards;
        private TextBox txtBarcode;
        private Label lblBarCode;
        private TextBox txtCardPrice;
        private Label lblCardPrice;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Button btnClearCardInfo;
        private Button btnSubmit;
        public Panel panel1;
        private ListBox listCards;
    }
}