namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello, MAUI!";
            ColorRed = Colors.Red;

            this.BindingContext = this;



        }

       private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Butter";
        }

        private void OnChangeLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Mr.Juan Dela Cruz";
        }

        private void OnChangeBackgroundColorL(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.GreenYellow;
        }

        private void OnChangeBackgroundColorO(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Orange;
        }

        private void OnChangeBackgroundColorY(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Yellow;
        }

        private void OnChangeBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Purple;
        }
    }

}
