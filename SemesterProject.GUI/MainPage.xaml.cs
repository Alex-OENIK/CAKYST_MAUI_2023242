using SemesterProject.GUI.ViewModels;

namespace SemesterProject.GUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
