using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    class ProgramList
    {
        public string ID { get; set; }
        public string Program_name { get; set; }
        public Nullable<DateTime> Date { get; set; }

        public TimeSpan Start_at { get; set; }
        public TimeSpan End_at { get; set; }
        public string Description { get; set; }
    }
}
