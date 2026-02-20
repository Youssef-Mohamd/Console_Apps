
#  Student Grading System

A simple C# console application that manages student grades and determines whether each student has passed or failed.

---

## 📌 Project Idea

This project demonstrates how to use:

- Func
- Action
- Predicate
- Delegates


The system allows users to:

1. Enter student names.
2. Enter 5 grades for each student.
3. Calculate the average grade.
4. Check if the student passed or failed.
5. Display the final result.

---

## 🧠 How It Works

The `GradingSystem` class does not calculate or decide anything directly.  
Instead, it receives behavior using delegates:

- `Func<List<int>, double>` → Calculates the average grade.
- `Predicate<double>` → Checks if the student passed.
- `Action<Student, double, bool>` → Displays student data.

This approach makes the system flexible and extensible.

---

## 🏗 Project Structure

- `Student.cs` → Represents a student (Name + Grades).
- `GradingSystem.cs` → Handles processing and displaying results.
- `Program.cs` → Handles user input and connects everything together.

---



