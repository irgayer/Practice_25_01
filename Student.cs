namespace Practice_25_01
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            double result;
            double sum = 0;
            for(int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }
            result = sum / Grades.Length;
            return result;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
