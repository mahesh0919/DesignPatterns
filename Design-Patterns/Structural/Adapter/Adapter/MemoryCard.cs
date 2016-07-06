using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MemoryCard
    {
        public Dictionary<string, string> GetMediaAlbum()
        {
            Dictionary<string, string> albums = new Dictionary<string, string>();
            albums.Add("ARRahman", "Roja");
            albums.Add("DeviSri", "Devi");
            albums.Add("Keeravani", "Bahubali");

            return albums;
        }

    }
}
