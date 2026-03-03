namespace zadanie21_2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Git", "Zalogowane!", "OK");
        }



        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Email = EmailEntry.Text;
            var Password = PasswordEntry.Text;

            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                LoginButton.IsVisible = true;

            }
            else
            {
                LoginButton.IsVisible = false;


            }

        }
    }
}
