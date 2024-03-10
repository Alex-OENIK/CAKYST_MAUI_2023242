using SemesterProject.Models;

namespace SemesterProject.Data
{
    public class MovieDB
    {
        readonly List<Movie> movies;

        public MovieDB()
        {
            movies = new();
            Seed();
        }

        public void Add(Movie movie) { movies.Add(movie); }

        public List<Movie> ReadAll() { return movies.Select(x => x.Clone()).ToList(); }

        public Movie? Read(string title) { return movies.Where(x => x.Title == title).First()?.Clone(); }

        public Movie? ReadRef(string title) { return movies.Where(x => x.Title == title).First() ?? null; }

        public void Delete(Movie movie) { movies.Remove(movie); }

        private void Seed()
        {
            movies.Add(new Movie("The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 91, 2001));
            movies.Add(new Movie("The Lord of the Rings: The Two Towers", "Peter Jackson", 95, 2002));
            movies.Add(new Movie("The Lord of the Rings: The Return of the King", "Peter Jackson", 94, 2003));

            movies.Add(new Movie("Star Wars: Episode IV - A New Hope", "George Lucas", 93, 1977));
            movies.Add(new Movie("Star Wars: Episode V - The Empire Strikes Back", "George Lucas", 95, 1980));
            movies.Add(new Movie("Star Wars: Episode VI - Return of the Jedi", "George Lucas", 83, 1983));

            movies.Add(new Movie("Harry Potter and the Sorcerer's Stone", "Chris Colombus", 81, 2001));
            movies.Add(new Movie("Harry Potter and the Chamber of Secrets", "Chris Colombus", 82, 2002));
            movies.Add(new Movie("Harry Potter and the Prisoner of Azkaban", "Alfonso Cuarón", 90, 2004));
        }
    }
}
