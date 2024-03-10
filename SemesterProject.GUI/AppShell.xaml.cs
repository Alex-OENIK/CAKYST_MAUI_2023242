namespace SemesterProject.GUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("mainpage", typeof(MainPage));
            Routing.RegisterRoute("createpage", typeof(CreatePage));
            Routing.RegisterRoute("updatepage", typeof(UpdatePage));
            Routing.RegisterRoute("querypage", typeof(QueryPage));
        }
    }
}
