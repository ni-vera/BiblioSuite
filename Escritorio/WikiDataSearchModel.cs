using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio.WDSearch
{

    public class objeto_raiz {
        public Searchinfo searchinfo { get; set; }
        public Search[] search { get; set; }
        public int searchcontinue { get; set; }
        public int success { get; set; }
    }

    public class Searchinfo
    {
        public string search { get; set; }
    }

    public class Search
    {
        public string id { get; set; }
        public string title { get; set; }
        public int pageid { get; set; }
        public Display display { get; set; }
        public string repository { get; set; }
        public string url { get; set; }
        public string concepturi { get; set; }
        public string label { get; set; }
        public string description { get; set; }
        public Match match { get; set; }
        public string[] aliases { get; set; }
    }

    public class Display
    {
        public Label label { get; set; }
        public Description description { get; set; }
    }

    public class Label
    {
        public string value { get; set; }
        public string language { get; set; }
    }

    public class Description
    {
        public string value { get; set; }
        public string language { get; set; }
    }

    public class Match
    {
        public string type { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }

}
