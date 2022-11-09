public class Student : Person
{
    private int _numCourses;
    private string? _courses;
    private int _grades;

    public Student(string name, string address, int numCourses, string courses):base(name, address)
    {
        _numCourses = numCourses;
        _courses = courses;
    }
    public void AddCoursesGrades(int grade)
    {
        
    }
    public void PrintGrades()
    {
        System.Console.WriteLine(_grades);
    }
}