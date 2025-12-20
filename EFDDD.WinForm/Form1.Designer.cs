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
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ProductIdTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(585, 298);
            dataGridView1.TabIndex = 0;
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
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(SaveButton);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIdTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private TextBox PriceTextBox;
        private Button SaveButton;
    }
}
