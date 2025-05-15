namespace MauiHello
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_hello_Clicked(object sender, EventArgs e) => lbl_hello.Text = "Hello";


    }

}
