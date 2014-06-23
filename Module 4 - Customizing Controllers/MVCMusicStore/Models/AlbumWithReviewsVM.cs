using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class AlbumWithReviewsVM
    {
        public string AlbumTitle {get; set; }
        public List<string> ReviewContent { get; set; }
    }
}