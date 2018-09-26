using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitive.Service.Image.Analyse.Models
{
    public class Caption
    {
        public string text
        {
            get;
            set;
        }
        public double confidence
        {
            get;
            set;
        }
    }
}
