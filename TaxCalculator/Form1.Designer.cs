namespace TaxCalculator
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
            txtTaxableIncome = new TextBox();
            txtIncomeTaxOwed = new TextBox();
            TaxableIncome = new Label();
            IncomeTaxOwed = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtTaxableIncome
            // 
            txtTaxableIncome.Location = new Point(135, 19);
            txtTaxableIncome.Name = "txtTaxableIncome";
            txtTaxableIncome.Size = new Size(100, 23);
            txtTaxableIncome.TabIndex = 0;
            // 
            // txtIncomeTaxOwed
            // 
            txtIncomeTaxOwed.Location = new Point(135, 48);
            txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            txtIncomeTaxOwed.ReadOnly = true;
            txtIncomeTaxOwed.Size = new Size(100, 23);
            txtIncomeTaxOwed.TabIndex = 1;
            txtIncomeTaxOwed.TabStop = false;
            // 
            // TaxableIncome
            // 
            TaxableIncome.AutoSize = true;
            TaxableIncome.Location = new Point(23, 27);
            TaxableIncome.Name = "TaxableIncome";
            TaxableIncome.Size = new Size(92, 15);
            TaxableIncome.TabIndex = 2;
            TaxableIncome.Text = "Taxable income:";
            // 
            // IncomeTaxOwed
            // 
            IncomeTaxOwed.AutoSize = true;
            IncomeTaxOwed.Location = new Point(23, 56);
            IncomeTaxOwed.Name = "IncomeTaxOwed";
            IncomeTaxOwed.Size = new Size(100, 15);
            IncomeTaxOwed.TabIndex = 3;
            IncomeTaxOwed.Text = "Income tax owed:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(23, 94);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(160, 94);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 130);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(IncomeTaxOwed);
            Controls.Add(TaxableIncome);
            Controls.Add(txtIncomeTaxOwed);
            Controls.Add(txtTaxableIncome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income Tax Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaxableIncome;
        private TextBox txtIncomeTaxOwed;
        private Label TaxableIncome;
        private Label IncomeTaxOwed;
        private Button btnCalculate;
        private Button btnExit;
    }
}
