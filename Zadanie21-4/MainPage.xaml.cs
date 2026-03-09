namespace Zadanie21_4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void Wybor(object sender, EventArgs e)
        {
            if (Temat.SelectedIndex == -1)
            {
                Priorytet.ItemsSource = null;
                Priorytet.IsEnabled = false;
                return;
            }

           
            if (Temat.SelectedIndex == 0)
            {
                Priorytet.IsEnabled = true;
                Priorytet.ItemsSource = new[] { "Niski", "Średni", "Wysoki" };
                Priorytet.SelectedIndex = -1;
            }
            
            else if (Temat.SelectedIndex == 2)
            {
                Priorytet.IsEnabled = true;
                Priorytet.ItemsSource = new[] { "Niski", "Średni" };
                Priorytet.SelectedIndex = -1;
            }
            
            else
            {
                Priorytet.ItemsSource = null;
                Priorytet.IsEnabled = false;
            }
        }
        
        void ButtonWyslij(object sender, EventArgs e)
        {
            if(Temat.SelectedIndex == -1 || Priorytet.SelectedIndex == -1 || string.IsNullOrEmpty(Tresc.Text))
            {
                DisplayAlert("Błąd", "Proszę wypełnić wszystkie pola.", "OK");
            }
            else
            {
                DisplayAlert("Sukces", "Pola wypelnione", "OK");
            }
        }
        
    }
}
