using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitive.Service.Image.Analyse.Models
{
    public class Color
    {
        public string dominantColorForeground
        {
            get;
            set;
        }
        public string dominantColorBackground
        {
            get;
            set;
        }
        public List<string> dominantColors
        {
            get;
            set;
        }
        public string accentColor
        {
            get;
            set;
        }
        public bool isBwImg
        {
            get;
            set;
        }
    }
}
