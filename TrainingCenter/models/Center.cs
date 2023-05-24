namespace TrainingCenter.models;

public class Center
{
    private List<Course> courses;
    private List<Teacher> teachers;
    private List<Student> students;

    public Center()
    {
        this.courses = new List<Course>();
        this.teachers = new List<Teacher>();
        this.students = new List<Student>();
    }

    public Center(List<Course> courses, List<Teacher> teachers, List<Student> students)
    {
        this.courses = courses;
        this.teachers = teachers;
        this.students = students;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Course> GetCourses()
    {
        return courses;
    }

    public List<Teacher> GetTeachers()
    {
        return teachers;
    }

    public List<Student> GetStudents()
    {
        return students;
    }

}