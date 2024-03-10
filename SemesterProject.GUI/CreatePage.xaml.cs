using SemesterProject.GUI.ViewModels;

namespace SemesterProject.GUI;

public partial class CreatePage : ContentPage
{
	public CreatePage(CreatePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}