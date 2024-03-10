namespace SemesterProject.Models
{
    public class Movie(string title, string director, byte rating, int releaseYear)
    {
        public string Title { get; set; } = title;

        public string Director { get; set; } = director;

        public byte Rating { get; set; } = rating;

        public int ReleaseYear { get; set; } = releaseYear;

        public override string ToString()
        {
            return $"Title: {Title}, Director: {Director}, Rating: {Rating}, Released in: {ReleaseYear} ";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            return obj is Movie movie &&
                Title == movie.Title &&
                Director == movie.Director &&
                Rating == movie.Rating &&
                ReleaseYear == movie.ReleaseYear;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Director, Rating, ReleaseYear);
        }

        public Movie Clone()
        {
            return new Movie(Title, Director, Rating, ReleaseYear);
        }
    }
}
