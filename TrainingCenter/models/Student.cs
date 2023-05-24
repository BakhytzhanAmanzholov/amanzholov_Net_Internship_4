namespace TrainingCenter.models;

public class Student
{
    private string name;
    private Dictionary<Course, int> courseGrades;

    public Student(string name)
    {
        this.name = name;
        courseGrades = new Dictionary<Course, int>();
    }

    public void AddCourse(Course course)
    {
        course.AddStudentToCourse(this);
        courseGrades.Add(course, 0);
    }

    public IEnumerable<Course> GetCourses()
    {
        return courseGrades.Keys;
    }

    private void SetCourseGrade(Course course, int grade)
    {
        if (courseGrades.ContainsKey(course))
        {
            courseGrades[course] = grade;
        }
    }

    public int GetCourseGrade(Course course)
    {
        if (courseGrades.ContainsKey(course))
        {
            return courseGrades[course];
        }

        return 0;
    }

    public int CalculateFinalGrade(Course course)
    {
        int finalGrade = 0;
        int count = 0;
        if (courseGrades.ContainsKey(course))
        {
            foreach (Lesson lesson in course.GetLessons())
            {
                if (lesson.GetScoreForStudent(this).Equals(0))
                {
                    count++;
                }

                finalGrade += lesson.GetScoreForStudent(this);
            }

            finalGrade /= (course.GetLessons().Count() - count);
            SetCourseGrade(course, finalGrade);
            return finalGrade;
        }

        return 0;
    }
}