using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitive.Service.Image.Analyse.Models
{
    public class ImageInfoViewModel
    {
        public List<Category> categories
        {
            get;
            set;
        }
        public Description description
        {
            get;
            set;
        }
        public Color color
        {
            get;
            set;
        }
        public string requestId
        {
            get;
            set;
        }
        public Metadata metadata
        {
            get;
            set;
        }
    }
}
