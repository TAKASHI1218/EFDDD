namespace EFDDD.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dg1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ProductIdTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            SaveButton = new Button();
            dg2 = new DataGridView();
            LogDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogDataGrid).BeginInit();
            SuspendLayout();
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(49, 34);
            dg1.Name = "dg1";
            dg1.Size = new Size(334, 298);
            dg1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.Location = new Point(49, 349);
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.Size = new Size(141, 23);
            ProductIdTextBox.TabIndex = 2;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(196, 349);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(164, 23);
            ProductNameTextBox.TabIndex = 3;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(366, 349);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(95, 23);
            PriceTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(483, 349);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // dg2
            // 
            dg2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg2.Location = new Point(407, 34);
            dg2.Name = "dg2";
            dg2.Size = new Size(334, 298);
            dg2.TabIndex = 6;
            // 
            // LogDataGrid
            // 
            LogDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogDataGrid.Location = new Point(49, 378);
            LogDataGrid.Name = "LogDataGrid";
            LogDataGrid.Size = new Size(687, 90);
            LogDataGrid.TabIndex = 7;
            // 
            // Title
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 480);
            Controls.Add(LogDataGrid);
            Controls.Add(dg2);
            Controls.Add(SaveButton);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIdTextBox);
            Controls.Add(dg1);
            Name = "Title";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private TextBox PriceTextBox;
        private Button SaveButton;
        private DataGridView dg2;
        private DataGridView LogDataGrid;
    }
}
