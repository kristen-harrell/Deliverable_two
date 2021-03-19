
namespace KeiraTheCaticorn.Models
{

    public class Rootobject
    {
        public bool has_more { get; set; }
        public object next_offset { get; set; }
        public Gallery[] results { get; set; }
    }

    public class Gallery
    {
        public string deviationid { get; set; }
        public object printid { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string category_path { get; set; }
        public bool is_favourited { get; set; }
        public bool is_deleted { get; set; }
        public bool is_published { get; set; }
        public Author author { get; set; }
        public Stats stats { get; set; }
        public string published_time { get; set; }
        public bool allows_comments { get; set; }
        public bool is_mature { get; set; }
        public bool is_downloadable { get; set; }
        public Preview preview { get; set; }
        public Content content { get; set; }
        public Thumb[] thumbs { get; set; }
        public int download_filesize { get; set; }
    }

    public class Author
    {
        public string userid { get; set; }
        public string username { get; set; }
        public string usericon { get; set; }
        public string type { get; set; }
    }

    public class Stats
    {
        public int comments { get; set; }
        public int favourites { get; set; }
    }

    public class Preview
    {
        public string src { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public bool transparency { get; set; }
    }

    public class Content
    {
        public string src { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public bool transparency { get; set; }
        public int filesize { get; set; }
    }

    public class Thumb
    {
        public string src { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public bool transparency { get; set; }
    }

}
