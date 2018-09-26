using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitive.Service.Image.Analyse.Models
{
    public class Description
    {
        public List<string> tags
        {
            get;
            set;
        }
        public List<Caption> captions
        {
            get;
            set;
        }
    }
}
