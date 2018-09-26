using System;
using System.Collections.Generic;
using System.Text;

namespace Cognitive.Service.Image.Analyse.Models
{
    public class Category
    {
        public string name
        {
            get;
            set;
        }
        public double score
        {
            get;
            set;
        }
        public Detail detail
        {
            get;
            set;
        }
    }
}
