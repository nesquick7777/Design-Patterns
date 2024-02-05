namespace OralExamFacade
{
    internal class LabExercisesService
    {
        private int minimum = 8;
        private Dictionary<String, int> attendance = new Dictionary<String, int> { { "PR115", 7 }, { "PEK150", 8 }, { "PR120", 80 }, };

        public bool HasEnoughAttendance(String id)
        {
            return this.minimum <= this.attendance[id];
        }
    }
}