using YodaApp.ViewModels;
namespace YodaApp.Views;

public partial class YodaAnswerPage : ContentPage
{

	YodaAnswerViewModel _viewModel;

	public YodaAnswerPage(YodaAnswerViewModel vm)
	{
		InitializeComponent();

        //var viewModel = this.MauiContext.Services.GetService<YodaAnswerViewModel>();
        _viewModel = vm;

		BindingContext = _viewModel;
	}
}