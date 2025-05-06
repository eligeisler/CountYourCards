using CountYourCards.ViewModels;
using System.Threading.Tasks;

namespace CountYourCards.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }

}
