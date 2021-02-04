using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NateStapletonMovieApp.Models
{
    public static class TempStorage
    {
        private static List<Movie> applications = new List<Movie>();

        public static IEnumerable<Movie> Applications => applications;

        public static void AddApplication(Movie application)
        {
            applications.Add(application);
        }
    }
}
