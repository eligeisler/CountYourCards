using CountYourCards.ViewModels;

namespace CountYourCards.Views;

public partial class Watten : ContentPage
{
	public Watten(WattenViewModel vm)
	{
		InitializeComponent();

		this.BindingContext=vm;

	}
}