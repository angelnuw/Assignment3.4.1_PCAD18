namespace Assignment3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coffee.CoffeeInfo.CreateData();
            var coffees = Coffee.CoffeeInfo.GetCoffees();

            coffeeGridView.DataSource = coffees;
        }
    }
}
