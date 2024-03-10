using SemesterProject.Models;
using SemesterProject.Repository;

namespace SemesterProject.Logic
{
    public class MovieLogic
    {
        readonly MovieRepo repo;

        public MovieLogic(MovieRepo repo)
        {
            this.repo = repo;
        }

        public List<Movie> ByDirector(string director)
        {
            return repo.ReadAll().Where(x => x.Director == director).ToList();
        }

        public List<Movie> ReleasedInYear(int year)
        {
            return repo.ReadAll().Where(x => x.ReleaseYear == year).ToList();
        }

        public void Create(Movie movie) { repo.Create(movie); }

        public Movie? Read(string title) { return repo.Read(title); }

        public List<Movie> ReadAll() { return repo.ReadAll(); }

        public void Update(Movie movie) { repo.Update(movie); }

        public void Delete(Movie movie) { repo.Delete(movie); }

        public void Delete(string title) { repo.Delete(title); }
    }
}
