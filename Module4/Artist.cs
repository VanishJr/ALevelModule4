using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
	public class Artist
	{
		public int ArtistId { get; set; }
		public string? Name { get; set; }

		public DateTime DateOfBirth { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? InstagramUrl { get; set; }

		public Song? Song { get; set; }

		public List<Song> Artists { get; set; } = new List<Song>();

		public override string ToString()
		{
			return String.Format("Id: {0} | Name: {1} | DateOfBirth: {2} | Email: {3} | Phone: {4} | InstagramUrl: {4}", ArtistId, Name, DateOfBirth.ToString("dd MMM yyyy - HH:mm:ss"), Email, Phone, InstagramUrl);
		}
	}
}
