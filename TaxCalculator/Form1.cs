namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
            decimal taxAmount = 0m;
            decimal taxPercent = 0m;
            decimal taxOver = 0m;

            taxAmount = taxableIncome switch
            {
                _ when taxableIncome >= 0 && taxableIncome < 11000 => 0m,
                _ when taxableIncome >= 11000 && taxableIncome < 44725 => 1100m,
                _ when taxableIncome >= 44725 && taxableIncome < 95375 => 5147m,
                _ when taxableIncome >= 95375 && taxableIncome < 182100 => 16290m,
                _ when taxableIncome >= 182100 && taxableIncome < 231250 => 37104m,
                _ when taxableIncome >= 231250 && taxableIncome < 578125 => 52832m,
                _ when taxableIncome >= 578125 => 174238.25m
            };

            taxPercent = taxableIncome switch
            {
                _ when taxableIncome >= 0 && taxableIncome < 11000 => 0.10m,
                _ when taxableIncome >= 11000 && taxableIncome < 44725 => 0.12m,
                _ when taxableIncome >= 44725 && taxableIncome < 95375 => 0.22m,
                _ when taxableIncome >= 95375 && taxableIncome < 182100 => 0.24m,
                _ when taxableIncome >= 182100 && taxableIncome < 231250 => 0.32m,
                _ when taxableIncome >= 231250 && taxableIncome < 578125 => 0.35m,
                _ when taxableIncome >= 578125 => 0.37m
            };

            taxAmount = taxableIncome switch
            {
                _ when taxableIncome >= 0 && taxableIncome < 11000 => 0m,
                _ when taxableIncome >= 11000 && taxableIncome < 44725 => 1100m,
                _ when taxableIncome >= 44725 && taxableIncome < 95375 => 44725m,
                _ when taxableIncome >= 95375 && taxableIncome < 182100 => 95375m,
                _ when taxableIncome >= 182100 && taxableIncome < 231250 => 182100m,
                _ when taxableIncome >= 231250 && taxableIncome < 578125 => 231250m,
                _ when taxableIncome >= 578125 => 578125m
            };

            txtIncomeTaxOwed.Text = ((taxableIncome - taxOver) * taxPercent + taxAmount).ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
