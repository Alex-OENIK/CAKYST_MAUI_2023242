using SemesterProject.GUI.ViewModels;

namespace SemesterProject.GUI;

public partial class UpdatePage : ContentPage
{
	public UpdatePage(UpdatePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}