using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Laptop
    {
        // Now this class is laptop, in future it may be a mediaplayer or mobile devise
        private ILaptop albumSource;
        public Laptop(ILaptop album)
        {
            this.albumSource = album;
        }
        public void PlayAlbums()
        {
            Dictionary<string, string> albumList = albumSource.GetTracks();

            foreach (var pair in albumList)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
        }

    }
}
