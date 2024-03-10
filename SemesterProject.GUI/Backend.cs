using SemesterProject.Data;
using SemesterProject.Repository;
using SemesterProject.Logic;

namespace SemesterProject.GUI
{
    public class Backend
    {
        public MovieLogic Logic { get; }

        public Backend()
        {
            Logic = new(new MovieRepo(new MovieDB()));
        }
    }
}
