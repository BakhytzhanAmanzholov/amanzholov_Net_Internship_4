namespace TrainingCenter.models;

public class Course
{
    private string title;
    private List<Lesson> lessons;
    private List<Teacher> teachers;

    public Course(string title)
    {
        this.title = title;
        this.lessons = new List<Lesson>();
        this.teachers = new List<Teacher>();
    }

    public Course(string title, List<Lesson> lessons)
    {
        this.title = title;
        this.lessons = lessons;
    }

    public void AddLesson(Lesson lesson)
    {
        lessons.Add(lesson);
    }

    public IEnumerable<Lesson> GetLessons()
    {
        return lessons;
    }

    public void AddStudentToCourse(Student student)
    {
        foreach (var lesson in GetLessons())
        {
            lesson.AddStudent(student);
        }
    }

    public string GetTitle()
    {
        return title;
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
}