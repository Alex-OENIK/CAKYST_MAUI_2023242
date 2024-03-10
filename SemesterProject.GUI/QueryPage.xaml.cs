using SemesterProject.GUI.ViewModels;

namespace SemesterProject.GUI;

public partial class QueryPage : ContentPage
{
	public QueryPage(QueryPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}