namespace OralExamFacade
{
    internal class ExamService
    {
        private int minimum = 50;
        private Dictionary<String, int> attendance = new Dictionary<String, int> { { "PR115", 45 }, { "PEK150", 70 }, { "PR120", 90 }, };

        public bool HasEnoughPoints(String id)
        {
            return this.minimum <= this.attendance[id];
        }
    }
}