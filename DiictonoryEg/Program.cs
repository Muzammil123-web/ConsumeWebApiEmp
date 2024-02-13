using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary to store student information with a list of courses and grades
        Dictionary<string, Dictionary<string, int>> studentInfo = new Dictionary<string, Dictionary<string, int>>();

        // Adding data to the dictionary
        AddStudentData(studentInfo, "Alice", "Math", 95);
        AddStudentData(studentInfo, "Alice", "History", 87);
        AddStudentData(studentInfo, "Bob", "Math", 92);
        AddStudentData(studentInfo, "Charlie", "Physics", 88);
        AddStudentData(studentInfo, "Charlie", "History", 90);

        // Displaying student information
        DisplayStudentInfo(studentInfo, "Alice");
        DisplayStudentInfo(studentInfo, "Bob");
        DisplayStudentInfo(studentInfo, "Charlie");
    
    }

    static void AddStudentData(Dictionary<string, Dictionary<string, int>> studentInfo, string studentName, string course, int grade)
    {
        // If the student is not already in the dictionary, add them
        if (!studentInfo.ContainsKey(studentName))
        {
            studentInfo[studentName] = new Dictionary<string, int>();
        }

        // Add the course and grade to the student's record
        studentInfo[studentName][course] = grade;
    }

    static void DisplayStudentInfo(Dictionary<string, Dictionary<string, int>> studentInfo, string studentName)
    {
        // Check if the student is in the dictionary
        if (studentInfo.ContainsKey(studentName))
        {
            Console.WriteLine($"{studentName}'s courses and grades:");

            // Iterate over courses and grades for the student
            foreach (var kvp in studentInfo[studentName])
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"{studentName} not found in the dictionary.\n");
        }
    }
}
