using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
	public class Song
	{
		public int SongId { get; set; }
		public string? Title { get; set; }

		public DateTime RealeseDate { get; set; }
		public DateTime Duration { get; set; }

		public int ArtistId { get; set; }

		public Artist? Artist { get; set; }

		public Genre? Genre { get; set; }

		public List<Song> Songs { get; set; } = new List<Song>();

		public override string ToString()
		{
			return String.Format("Id: {0} | Name: {1} | DateOfBirth: {2} | Email: {3} | Phone: {4} | InstagramUrl: {4}", SongId, Title, RealeseDate.ToString("dd MMM yyyy - HH:mm:ss"), Duration.ToString("dd MMM yyyy - HH:mm:ss"));
		}
	}
}
