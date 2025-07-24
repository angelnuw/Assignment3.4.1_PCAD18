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
            CoffeeInfo.CreateData();
            var coffees = CoffeeInfo.GetCoffees();

            //binding the coffee data to the DataGridView
            coffeeBindingSource.DataSource = coffees;
            coffeeGridView.DataSource = coffees;
        }
    }
}
