namespace _1_delegates
{
    public partial class frmCalculator : Form
    {
        private delegate int ExecuteOperation(int number1, int number2);
        private ExecuteOperation myOperation;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private int Calculate()
        {
            int number1 = Convert.ToInt32(txbNumber1.Text);
            int number2 = Convert.ToInt32(txbNumber2.Text);
            return myOperation(number1, number2);
        }

        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        private int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myOperation = new ExecuteOperation(Add);
            txbResult.Text = Calculate().ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            myOperation = new ExecuteOperation(Subtract);
            txbResult.Text = Calculate().ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            myOperation = new ExecuteOperation(Multiply);
            txbResult.Text = Calculate().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            myOperation = new ExecuteOperation(Divide);
            txbResult.Text = Calculate().ToString();
        }
    }
}