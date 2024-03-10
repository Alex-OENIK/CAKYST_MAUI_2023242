using SemesterProject.Data;
using SemesterProject.Models;

namespace SemesterProject.Repository
{
    public class MovieRepo
    {
        MovieDB db;

        public MovieRepo(MovieDB db)
        {
            this.db = db;
        }

        public void Create(Movie movie) { db.Add(movie); }

        public List<Movie> ReadAll() { return db.ReadAll(); }

        public Movie? Read(string title) { return db.Read(title); }

        public void Update(Movie movie)
        {
            ArgumentNullException.ThrowIfNull(movie);

            Movie? m = db.ReadRef(movie.Title);
            if (m != null)
            {
                m.Director = movie.Director;
                m.Rating = movie.Rating;
                m.ReleaseYear = movie.ReleaseYear;
            }

        }

        public void Delete(Movie movie) { db.Delete(movie); }

        public void Delete(string title)
        {
            Movie? m = Read(title);
            if (m != null) { Delete(m); }
        }
    }
}
