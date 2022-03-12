using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Homework
    {
        public string Topic { get; set; }
        public int Unit { get; set; }
        public DateTime CompletionTime { get; set; }
        public DateTime CreateTime { get; set; }
        public EHwSituationType HwSituationType = EHwSituationType.New;
    }
}
