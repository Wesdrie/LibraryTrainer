using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    internal class CallAreas
    {
        public int AreaIndex { get; set; }
        public string AreaNumber { get; set; }
        public string AreaName { get; set; }
        public string AreaDescription { get; set; }

        public CallAreas(int areaIndex, string areaNumber, string areaName, string areaDescription)
        {
            this.AreaIndex = areaIndex;
            this.AreaNumber = areaNumber;
            this.AreaName = areaName;
            this.AreaDescription = areaDescription;
        }
    }
}

