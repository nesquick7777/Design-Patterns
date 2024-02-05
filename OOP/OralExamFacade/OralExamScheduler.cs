using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OralExamFacade
{
    internal class OralExamScheduler
    {
        AttendanceService attendanceService = new AttendanceService();
        LabExercisesService labExercisesService = new LabExercisesService();
        ExamService examService = new ExamService();

        public bool isEligibleForOralExam(string id)
        {
            return attendanceService.HasEnoughAttendance(id) && labExercisesService.HasEnoughAttendance(id) && examService.HasEnoughPoints(id);
        }
    }
}
