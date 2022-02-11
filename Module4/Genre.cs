using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string? Title { get; set; }

        public Genre? Song { get; set; }

        public List<Song> Genres { get; set; } = new List<Song>();

        public override string ToString()
        {
            return String.Format("Id: {0} | Name: {1} | DateOfBirth: {2} | Email: {3} | Phone: {4} | InstagramUrl: {4}", GenreId, Title);
        }
    }
}
