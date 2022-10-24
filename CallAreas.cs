using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    internal class CallAreas
    {
        int areaIndex;
        string areaNumber, areaName, areaDescription;

        public CallAreas(int areaIndex, string areaNumber, string areaName, string areaDescription)
        {
            this.areaIndex = areaIndex;
            this.areaNumber = areaNumber;
            this.areaName = areaName;
            this.areaDescription = areaDescription;
        }

        public int AreaIndex { get; set; }
        public string AreaNumber { get; set; }
        public string AreaName { get; set; }
        public string AreaDescription { get; set; }
    }
}
