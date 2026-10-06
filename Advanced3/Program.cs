namespace Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            /*List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
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
            }*/
            #endregion
            #region Exercise 2: Leaderboard
            /* Dictionary<int, string> leaderboard = new Dictionary<int, string>
         {
             { 500, "Ahmed" },
             { 200, "Sara" },
             { 800, "Ali" },
             { 350, "Mona" }
         };
             List<int> sortedScores = new List<int>(leaderboard.Keys);
             sortedScores.Sort();
             foreach (int score in sortedScores)
             {
                 Console.WriteLine($"Score: {score}, Player: {leaderboard[score]}");
             }
             int firstKey = sortedScores[0];
             string firstValue = leaderboard[firstKey];
             Console.WriteLine($"First Value: {firstValue} with Score: {firstKey}");
             bool exists = leaderboard.ContainsKey(500);
             Console.WriteLine($"Does score 500 exist {exists}");
             if (leaderboard.TryGetValue(999, out string player))
             {
                 Console.WriteLine($"Player with score 999: {player}");
             }
             else
             {
                 Console.WriteLine("Player with score 999 was not found.");
             }
             leaderboard.Remove(200);
             sortedScores = new List<int>(leaderboard.Keys);
             sortedScores.Sort();
             Console.WriteLine("Updated Leaderboard:");
             foreach (int score in sortedScores)
             {
                 Console.WriteLine($"Score: {score}, Player: {leaderboard[score]}");
             }*/
            #endregion
            #region Exercise 3: Phone Book
            /*  Dictionary<string, string> phoneBook = new Dictionary<string, string>
          {
              { "Ahmed", "01011111111" },
              { "Sara", "01122222222" },
              { "Ali", "01233333333" },
              { "Mona", "01544444444" }
          };
              phoneBook["Omar"] = "01055555555";
              try
              {
                  phoneBook.Add("Ahmed", "01000000000");
              }
              catch (ArgumentException ex)
              {
                  Console.WriteLine($"Error caught: {ex.Message}");
              }
              bool isAdded = phoneBook.TryAdd("Ahmed", "01000000000");
              Console.WriteLine($"Was Ahmed added again? {isAdded}");
              bool exists = phoneBook.ContainsKey("Hassan");
              Console.WriteLine($"Does 'Hassan' exist in phone book? {exists}");
              string searchName = "Hassan";
              string resultNumber = phoneBook.ContainsKey(searchName) ? phoneBook[searchName] : "Not Found";
              Console.WriteLine($"Searching for '{searchName}': {resultNumber}");
              Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
              Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));*/
            #endregion
            #region Exercise 4: Unique Email Validator
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");
            Console.WriteLine($"Stored emails count: {emails.Count}");
            Console.WriteLine("Explanation: The count is 2 because HashSet only stores unique elements, and using StringComparer.OrdinalIgnoreCase makes it treat 'AHMED@test.com' as a duplicate of 'ahmed@test.com'.");
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);
            Console.WriteLine("UnionWith (A U B): " + string.Join(", ", unionSet));
            HashSet<int> intersectionSet = new HashSet<int>(setA);
            intersectionSet.IntersectWith(setB);
            Console.WriteLine("IntersectWith (A ∩ B): " + string.Join(", ", intersectionSet));
            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);
            Console.WriteLine("ExceptWith (A - B): " + string.Join(", ", exceptSet));
            HashSet<int> subSet = new HashSet<int> { 1, 2 };
            bool isSub = subSet.IsSubsetOf(setA);
            Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSub}");
            #endregion
            #region Exercise 5: Print Queue Simulator
            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");
            Console.WriteLine("Queue contents: " + string.Join(", ", printQueue));
            Console.WriteLine($"Queue Count: {printQueue.Count}");
            string nextDocument = printQueue.Peek();
            Console.WriteLine($"Next document to print: {nextDocument}");
            int count = printQueue.Count;
            for (int i = 0; i < count; i++)
            {
                string currentDoc = printQueue.Dequeue();
                Console.WriteLine($"Printing: {currentDoc}");
            }
            bool success = printQueue.TryDequeue(out string result);
            Console.WriteLine($"Did TryDequeue succeed? {success}");
            Console.WriteLine($"Result value: '{result}'");
            Console.WriteLine("Explanation: TryDequeue returns false on an empty queue instead of throwing an Exception.");
            #endregion
            #region Exercise 6: Browser History (Undo)
            Stack<string> history = new Stack<string>();
            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");
            string currentPage = history.Peek();
            Console.WriteLine($"Current page (top of stack): {currentPage}");
            string leftPage1 = history.Pop();
            Console.WriteLine($"Leaving: {leftPage1}");
            string leftPage2 = history.Pop();
            Console.WriteLine($"Leaving: {leftPage2}");
            string leftPage3 = history.Pop();
            Console.WriteLine($"Leaving: {leftPage3}");
            Console.WriteLine($"Current page after going back 3 times: {history.Peek()}");
            history.Clear();
            bool successs = history.TryPop(out string resultt);
            Console.WriteLine($"Did TryPop succeed? {successs}");
            Console.WriteLine($"Result value: '{resultt}'");
            Console.WriteLine("Explanation: TryPop returns false on an empty stack instead of throwing an Exception.");
            #endregion
        }
    }
}
