namespace Lotto_Manager_Software
{
    partial class FrmReports
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
            dGridView1 = new DataGridView();
            IndexNumber = new DataGridViewTextBoxColumn();
            Start = new DataGridViewTextBoxColumn();
            End = new DataGridViewTextBoxColumn();
            CardsSold = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblShift1 = new Label();
            lblShift2 = new Label();
            lblShift3 = new Label();
            btnCloseShift1 = new Button();
            btnCloseShift2 = new Button();
            btnCloseShift3 = new Button();
            lblTitleReports = new Label();
            grpBoxSalesInfo = new GroupBox();
            dGridView2 = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridView3).BeginInit();
            SuspendLayout();
            // 
            // dGridView1
            // 
            dGridView1.AllowUserToDeleteRows = false;
            dGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView1.Columns.AddRange(new DataGridViewColumn[] { IndexNumber, Start, End, CardsSold, Total });
            dGridView1.Location = new Point(22, 211);
            dGridView1.Name = "dGridView1";
            dGridView1.ReadOnly = true;
            dGridView1.RowHeadersWidth = 51;
            dGridView1.Size = new Size(355, 580);
            dGridView1.TabIndex = 0;
            // 
            // IndexNumber
            // 
            IndexNumber.HeaderText = "";
            IndexNumber.MinimumWidth = 6;
            IndexNumber.Name = "IndexNumber";
            IndexNumber.ReadOnly = true;
            IndexNumber.Resizable = DataGridViewTriState.False;
            IndexNumber.Width = 35;
            // 
            // Start
            // 
            Start.HeaderText = "Start";
            Start.MinimumWidth = 6;
            Start.Name = "Start";
            Start.ReadOnly = true;
            Start.Width = 60;
            // 
            // End
            // 
            End.HeaderText = "End";
            End.MinimumWidth = 6;
            End.Name = "End";
            End.ReadOnly = true;
            End.Width = 60;
            // 
            // CardsSold
            // 
            CardsSold.HeaderText = "Qty";
            CardsSold.MinimumWidth = 6;
            CardsSold.Name = "CardsSold";
            CardsSold.ReadOnly = true;
            CardsSold.Width = 60;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 65;
            // 
            // lblShift1
            // 
            lblShift1.AutoSize = true;
            lblShift1.BackColor = Color.Tomato;
            lblShift1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShift1.Location = new Point(161, 161);
            lblShift1.Name = "lblShift1";
            lblShift1.Size = new Size(90, 31);
            lblShift1.TabIndex = 1;
            lblShift1.Text = "Shift 1";
            // 
            // lblShift2
            // 
            lblShift2.AutoSize = true;
            lblShift2.BackColor = Color.Gold;
            lblShift2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShift2.Location = new Point(533, 161);
            lblShift2.Name = "lblShift2";
            lblShift2.Size = new Size(90, 31);
            lblShift2.TabIndex = 4;
            lblShift2.Text = "Shift 2";
            // 
            // lblShift3
            // 
            lblShift3.AutoSize = true;
            lblShift3.BackColor = Color.Chartreuse;
            lblShift3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShift3.Location = new Point(925, 161);
            lblShift3.Name = "lblShift3";
            lblShift3.Size = new Size(90, 31);
            lblShift3.TabIndex = 5;
            lblShift3.Text = "Shift 3";
            // 
            // btnCloseShift1
            // 
            btnCloseShift1.BackColor = Color.Tomato;
            btnCloseShift1.Cursor = Cursors.Hand;
            btnCloseShift1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnCloseShift1.Location = new Point(121, 811);
            btnCloseShift1.Name = "btnCloseShift1";
            btnCloseShift1.Size = new Size(130, 60);
            btnCloseShift1.TabIndex = 6;
            btnCloseShift1.Text = "Close";
            btnCloseShift1.UseVisualStyleBackColor = false;
            // 
            // btnCloseShift2
            // 
            btnCloseShift2.BackColor = Color.Gold;
            btnCloseShift2.Cursor = Cursors.Hand;
            btnCloseShift2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnCloseShift2.Location = new Point(524, 811);
            btnCloseShift2.Name = "btnCloseShift2";
            btnCloseShift2.Size = new Size(130, 60);
            btnCloseShift2.TabIndex = 7;
            btnCloseShift2.Text = "Close";
            btnCloseShift2.UseVisualStyleBackColor = false;
            // 
            // btnCloseShift3
            // 
            btnCloseShift3.BackColor = Color.Chartreuse;
            btnCloseShift3.Cursor = Cursors.Hand;
            btnCloseShift3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnCloseShift3.Location = new Point(915, 811);
            btnCloseShift3.Name = "btnCloseShift3";
            btnCloseShift3.Size = new Size(130, 60);
            btnCloseShift3.TabIndex = 8;
            btnCloseShift3.Text = "Close";
            btnCloseShift3.UseVisualStyleBackColor = false;
            // 
            // lblTitleReports
            // 
            lblTitleReports.BackColor = Color.Snow;
            lblTitleReports.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleReports.Location = new Point(734, 9);
            lblTitleReports.Name = "lblTitleReports";
            lblTitleReports.Size = new Size(325, 63);
            lblTitleReports.TabIndex = 9;
            lblTitleReports.Text = "Lottery Reports";
            lblTitleReports.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpBoxSalesInfo
            // 
            grpBoxSalesInfo.BackColor = SystemColors.HotTrack;
            grpBoxSalesInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxSalesInfo.Location = new Point(1162, 39);
            grpBoxSalesInfo.Name = "grpBoxSalesInfo";
            grpBoxSalesInfo.Size = new Size(588, 832);
            grpBoxSalesInfo.TabIndex = 10;
            grpBoxSalesInfo.TabStop = false;
            grpBoxSalesInfo.Text = "Sales Summary";
            // 
            // dGridView2
            // 
            dGridView2.AllowUserToDeleteRows = false;
            dGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dGridView2.Location = new Point(404, 211);
            dGridView2.Name = "dGridView2";
            dGridView2.ReadOnly = true;
            dGridView2.RowHeadersWidth = 51;
            dGridView2.Size = new Size(355, 580);
            dGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn9.Width = 35;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Start";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 60;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "End";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Qty";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Total";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 65;
            // 
            // dGridView3
            // 
            dGridView3.AllowUserToDeleteRows = false;
            dGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dGridView3.Location = new Point(788, 211);
            dGridView3.Name = "dGridView3";
            dGridView3.ReadOnly = true;
            dGridView3.RowHeadersWidth = 51;
            dGridView3.Size = new Size(355, 580);
            dGridView3.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Start";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "End";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Qty";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 65;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SpringGreen;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnBack.Location = new Point(22, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 60);
            btnBack.TabIndex = 13;
            btnBack.Text = "Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1762, 883);
            Controls.Add(btnBack);
            Controls.Add(dGridView3);
            Controls.Add(dGridView2);
            Controls.Add(grpBoxSalesInfo);
            Controls.Add(lblTitleReports);
            Controls.Add(btnCloseShift3);
            Controls.Add(btnCloseShift2);
            Controls.Add(btnCloseShift1);
            Controls.Add(lblShift3);
            Controls.Add(lblShift2);
            Controls.Add(lblShift1);
            Controls.Add(dGridView1);
            Name = "FrmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += FrmReports_Load;
            ((System.ComponentModel.ISupportInitialize)dGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGridView1;
        private Label lblShift1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label lblShift2;
        private Label lblShift3;
        private Button btnCloseShift1;
        private Button btnCloseShift2;
        private Button btnCloseShift3;
        private Label lblTitleReports;
        private GroupBox grpBoxSalesInfo;
        private DataGridViewTextBoxColumn IndexNumber;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn End;
        private DataGridViewTextBoxColumn CardsSold;
        private DataGridViewTextBoxColumn Total;
        private DataGridView dGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridView dGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btnBack;
    }
}