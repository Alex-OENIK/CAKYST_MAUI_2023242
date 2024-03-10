using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using SemesterProject.Models;


namespace SemesterProject.GUI.ViewModels
{
    public partial class QueryPageViewModel
    {
        public string Title { get; } = "Query";

        public ObservableCollection<Movie> Movies { get; } = [];

        public string? DirectorFilter { get; set; }
        public string? YearFilter { get; set; }

        readonly Backend backend;

        public QueryPageViewModel(Backend backend)
        {
            this.backend = backend;
        }

        [RelayCommand]
        public void FilterByDirector()
        {
            if (DirectorFilter != null)
            {
                Movies.Clear();
                backend.Logic.ByDirector(DirectorFilter).ForEach(x => Movies.Add(x));
            }
        }

        [RelayCommand]
        public void FilterByYear()
        {
            if (YearFilter != null && int.TryParse(YearFilter, out int year))
            {
                Movies.Clear();
                backend.Logic.ReleasedInYear(year).ForEach(x => Movies.Add(x));
            }
        }
    }
}
