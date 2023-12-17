namespace Proj
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
            BindingContext = new FlexLayoutViewModel();
        }
    }
}
