using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OralExamFacade
{
    internal class AttendanceService
    {
        private int minimum = 70;
        private Dictionary<String,int> attendance = new Dictionary<String, int> { { "PR115", 100 },{ "PEK150", 70 },{ "PR120", 70 }, };

        public bool HasEnoughAttendance(String id)
        {
            return this.minimum <= this.attendance[id];
        }
    }
}
