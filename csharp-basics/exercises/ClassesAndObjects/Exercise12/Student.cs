namespace Exercise12
{
    public class Student : IStudent
    {
        private List<string> _testsTaken = new List<string>();

        public List<string> TestsTaken
        {
            get
            {
                if (_testsTaken.Count == 0)
                {
                    Console.WriteLine("No tests taken");
                }

                return _testsTaken;
            }
        }

        public void TakeTest(ITestPaper paper, string[] answers)
        {
            int countOfRightAnswers = paper.MarkScheme.Zip(answers,(i, j) => i == j).Count(eq => eq);
            int percentComplete = (int)Math.Round((double)(100 * countOfRightAnswers) / answers.Length);

            var markstr = paper.PassMark.Replace("%", "");
            var mark = Int32.Parse(markstr);

            if (mark <= percentComplete)
            {
                _testsTaken.Add($"{paper.Subject} Passed! ({percentComplete}%)");
            }
            else
            {
                _testsTaken.Add($"{paper.Subject} Failed! ({percentComplete}%)");
            }
        }
    }
}
