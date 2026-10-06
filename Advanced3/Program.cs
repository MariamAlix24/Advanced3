namespace Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            Console.WriteLine($"All Grades: {string.Join(", ", grades)}");
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades[0]}");
            Console.WriteLine($"Last Grade: {grades[^1]}");
            grades.Sort();
            Console.WriteLine($"Sorted Grades: {string.Join(", ", grades)}");
            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First Grade Above 90: {firstAbove90}");
            List<int> failingGrades = grades.FindAll(g => g < 75);
            Console.WriteLine($"Failing Grades: {string.Join(", ", failingGrades)}");
            grades.RemoveAll(g => g < 75);
            Console.WriteLine($"Grades After Removing Failing: {string.Join(", ", grades)}");
            bool hasPerfectScore = grades.Contains(100);
            Console.WriteLine($"Has Perfect Score: {hasPerfectScore}");
            List<string> formattedGrades = new List<string>();
            foreach (int item in grades)
            {
                formattedGrades.Add($"Grade: {item}");
            }
            Console.WriteLine("Formatted Grades List:");
            foreach (string str in formattedGrades)
            {
                Console.WriteLine(str);
            }
            #endregion
        }
    }
}
