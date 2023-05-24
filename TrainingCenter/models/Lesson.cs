namespace TrainingCenter.models;

public class Lesson
{
    private string title;
    private Dictionary<Student, int> grades;
    private Course course;

    public Lesson(string title)
    {
        this.title = title;
    }

    public Lesson(string title, Course course)
    {
        this.title = title;
        this.grades = new Dictionary<Student, int>();
        this.course = course;
        this.course.AddLesson(this);
    }

    public Lesson(string title, Dictionary<Student, int> grades)
    {
        this.title = title;
        this.grades = grades;
    }

    public void AddGrade(Student student, int grade)
    {
        if (grades.ContainsKey(student))
        {
            grades[student] = grade;
        }
    }

    public int GetScoreForStudent(Student student)
    {
        return grades.TryGetValue(student, out int grade)
            ? grade
            : throw new ArgumentException("The student does not belong to the lesson");
    }

    public void AddStudent(Student student)
    {
        grades.Add(student, 0);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Lesson other = obj as Lesson;
        return other.title.Equals(title) && other.course.GetTitle().Equals(course.GetTitle());
    }
}