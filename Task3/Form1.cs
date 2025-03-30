namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumberInput.Text);
            int result = Fibonacci(n);
            lblFibonacciResult.Text = $"Fibonacci({n}) = {result}";
        }

        public double Power(double baseNum, int power)
        {
            if (power == 0) return 1;
            if (power < 0) return 1 / Power(baseNum, -power);
            return baseNum * Power(baseNum, power - 1);
        }

        private void btbCalculatePower_Click(object sender, EventArgs e)
        {
            double x = int.Parse(txtBaseInput.Text);
            int n = int.Parse(txtExponentInput.Text);
            double result = Power(x, n);
            lblPowerResult.Text = $"{x}^{n} = {result}";
        }
        
    }
}
