using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace SoundCload_Downloader
{
    class SoundCloud
    {
        private static String clientID = "06e3e204bdd61a0a41d8eaab895cb7df";
        public static string GetSourceURL(string url)
        {

            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                string text = "";
                using (StreamReader sr = new StreamReader(data))
                    text = sr.ReadToEnd();
                return text;
            }
            catch (Exception e)
            {
                return "error";
            }
            return "";
        }

        public static string GetStringGroup(string s, string startindex, string finishindex, int index)
        {
            int i_start = s.IndexOf(startindex, index) + startindex.Length;
            int i_finish = s.IndexOf(finishindex, i_start) - i_start;
            string result = s.Substring(i_start, i_finish);
            return result;
        }

        public static TrackID SearchTrackID(string s, int startindex)
        {
            string id = GetStringGroup(s, "\"track\",\"id\":", ",", startindex);
            string title = GetStringGroup(s, "\"title\":\"", "\",\"description\"", startindex);
            string description = GetStringGroup(s, "\"description\":\"", "\",\"label_name\"", startindex);
            string urlMp3 = resolveDownloadURL(id);
            int index = s.LastIndexOf(id);

            return new TrackID(index, id, title, description, urlMp3);
        }
        public static TrackID resolveTrackID(String url)
        {
            // https://soundcloud.com/khoidarealest/tat-ca-cua-anh?in=khoidarealest/sets/she-ep
            // https://soundcloud.com/khoidarealest/tat-ca-cua-anh
            string str = GetSourceURL("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" + clientID);

            return SearchTrackID(str, 0);
        }

        public static List<TrackID> resolveListTrackIDs(String url)
        {
            // https://soundcloud.com/khoidarealest/sets/she-ep
            List<TrackID> ret = new List<TrackID>();

            int currentindex = 0;
            string str = GetSourceURL("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" + clientID + "&limit=1000");
            while (str.IndexOf("\"track\",\"id\":", currentindex) > 0)
            {
                TrackID t = SearchTrackID(str, currentindex);
                currentindex = t.index + 1;
                ret.Add(t);
            }
            return ret;
        }

        public static List<TrackID> resolveUserTrackID(string url)
        {
            // https://soundcloud.com/khoidarealest
            string s = GetSourceURL("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" + clientID);
            string id = GetStringGroup(s, "\"id\":", ",", 0);
            string str = GetSourceURL("http://api.soundcloud.com/users/" + id + "/tracks.json?client_id=" + clientID + "&limit=1000");
            List<TrackID> ret = new List<TrackID>();
            int currentindex = 0;
            while (str.IndexOf("\"track\",\"id\":", currentindex) > 0)
            {
                TrackID t = SearchTrackID(str, currentindex);
                currentindex = t.index + 1;
                ret.Add(t);
            }
            return ret;
        }

        public static int getTrackCount(string str)
        {
            return Convert.ToInt32(GetStringGroup(str, "\"track_count\":", ",", 0));
        }

        public static string resolveDownloadURL(String id)
        {
            String str = GetSourceURL("https://api.soundcloud.com/tracks/" + id + "/streams?client_id=" + clientID);
            Console.WriteLine(str);
            if (str == "{}")
                return "error";
            return Regex.Unescape((GetStringGroup(str, "http_mp3_128_url\":\"", "\"", 0)));
        }

        public static int checkUrl(string url)
        {
            if (url.Contains("/sets/"))
            {
                Console.WriteLine("playlist");
                return 0; // resolveListTrackID

            }
            else
            {
                string str = GetSourceURL("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" + clientID);
                if (str == "" || str == "error")
                    return 3;
                string s = GetStringGroup(str, "\"kind\":\"", "\",", 0);
                Console.WriteLine(s);
                if (s == "track")
                    return 1;
                else if (s == "user")
                    return 2;
            }
            return 3;
        }
    }
}
