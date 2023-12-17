namespace Proj
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPage1Clicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(Page1.Text);
            Navigation.PushAsync(new GridLayoutPage());
        }
        private void OnPage2Clicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(Page2.Text);
            Navigation.PushAsync(new FlexLayoutPage());
        }
        private void OnPage3Clicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(Page3.Text);
            Navigation.PushAsync(new VerticalStackLayoutPage());
        }
        private void OnPage4Clicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(Page4.Text);
            Navigation.PushAsync(new HorizontalStackLayoutPage());
        }
    }
}