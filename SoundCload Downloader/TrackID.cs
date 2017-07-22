using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCload_Downloader
{
    class TrackID
    {
        public int index;
        public string id;
        public string title;
        public string description;
        public string urlMp3;
        public TrackID(int i, string j, string k, string x, string y)
        {
            index = i;
            id = j;
            title = k;
            description = x;
            urlMp3 = y;
        }
    }
}
