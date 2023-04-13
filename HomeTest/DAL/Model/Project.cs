using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DtoClasses
{
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public int durationInDays { get; set; }
        public int bugsCount { get; set; }
        public bool madeDadeline { get; set; }
    }
}
