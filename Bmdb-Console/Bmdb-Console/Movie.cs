using System;
using System.Collections.Generic;
using System.Text;

namespace Bmdb_Console {
    class Movie {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Rating { get; set; }
        public int Year { get; set; }
        public String Director { get; set; }

        public Movie () {

        }

        public Movie (int id, String title, String rating, int year, String director) {
            this.Id = id;
            this.Title = title;
            this.Rating = rating;
            this.Year = year;
            this.Director = director;
        }

        public override string ToString() {
            return $"Movie: {Id}, {Title}, {Rating}, {Year}, {Director}";
        }


    }
}
