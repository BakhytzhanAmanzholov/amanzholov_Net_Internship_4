namespace TrainingCenter.models;

public class Teacher
{
    private string fullName;
    private List<Course> courses;

    public Teacher(string fullName)
    {
        this.fullName = fullName;
        this.courses = new List<Course>();
    }

    public Teacher(string fullName, List<Course> courses)
    {
        this.fullName = fullName;
        this.courses = courses;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public int Grade(Student student, int grade, Lesson lesson)
    {
        bool prime = false;
        foreach (var course in courses)
        {
            if (course.GetLessons().Contains(lesson))
            {
                prime = true;
            }
        }

        if (prime)
        {
            lesson.AddGrade(student, grade);
        }
        return grade;
    }
}