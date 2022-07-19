using MauiApp4.ViewModel;

namespace MauiApp4;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		BindingContext = vm;

        InitializeComponent();
	}
}

