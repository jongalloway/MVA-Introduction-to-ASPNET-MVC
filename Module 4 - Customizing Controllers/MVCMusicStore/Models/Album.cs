using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCMusicStore.Models
{
	public class Album
	{
		public int AlbumID { get; set; }

		public string Title { get; set; }

		public Artist Artist { get; set; }

		public virtual List<Review> Review { get; set; }
	}
}
