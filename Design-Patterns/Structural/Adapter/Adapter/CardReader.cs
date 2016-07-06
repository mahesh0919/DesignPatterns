using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CardReader: MemoryCard, ILaptop
    {
        public Dictionary<string, string> GetTracks()
        {
            Dictionary<string,string> tracks =  GetMediaAlbum();
            return tracks;
        }
    }
}
