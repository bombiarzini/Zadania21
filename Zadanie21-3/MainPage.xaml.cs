namespace Zadanie21_3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            if(Zgoda.IsChecked == false)
            {
                DisplayAlert("Status", "Nie można się zarejestrować bez zgody", "Ok!");
                return;
            }
            DisplayAlert("Status", "Zarejestrowano", "Ok!");
        }
    }
}
