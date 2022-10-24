using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    internal class CallAreas
    {
        string areaNumber, areaName, areaDescription;

        public CallAreas(string areaNumber, string areaName, string areaDescription)
        {
            this.areaNumber = areaNumber;
            this.areaName = areaName;
            this.areaDescription = areaDescription;
        }

        public string AreaNumber { get; set; }
        public string AreaName { get; set; }
        public int AreaDescription { get; set; }
    }
}
