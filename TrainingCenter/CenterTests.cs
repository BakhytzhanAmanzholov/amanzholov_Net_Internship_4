using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainingCenter;

using models;

[TestClass]
public class CenterTests
{
    
    [TestMethod]
    public void TestAddCourse()
    {
        Center center = new Center();
        Course course = new Course("Math");

        center.AddCourse(course);

        Assert.IsTrue(center.GetCourses().Contains(course));
    }

    [TestMethod]
    public void TestAddTeacher()
    {
        Center center = new Center();
        Teacher teacher = new Teacher("John Smith");

        center.AddTeacher(teacher);

        Assert.IsTrue(center.GetTeachers().Contains(teacher));
    }

    [TestMethod]
    public void TestAddStudent()
    {
        Center center = new Center();
        Student student = new Student("Jane Doe");

        center.AddStudent(student);

        Assert.IsTrue(center.GetStudents().Contains(student));
    }

    [TestMethod]
    public void TestGetCourses()
    {
        Center center = new Center();
        Course course1 = new Course("Math");
        Course course2 = new Course("Science");

        center.AddCourse(course1);
        center.AddCourse(course2);

        Assert.AreEqual(2, center.GetCourses().Count());
        Assert.IsTrue(center.GetCourses().Contains(course1));
        Assert.IsTrue(center.GetCourses().Contains(course2));
    }

    [TestMethod]
    public void TestGetTeachers()
    {
        Center center = new Center();
        Teacher teacher1 = new Teacher("John Smith");
        Teacher teacher2 = new Teacher("Jane Doe");

        center.AddTeacher(teacher1);
        center.AddTeacher(teacher2);

        Assert.AreEqual(2, center.GetTeachers().Count());
        Assert.IsTrue(center.GetTeachers().Contains(teacher1));
        Assert.IsTrue(center.GetTeachers().Contains(teacher2));
    }

    [TestMethod]
    public void TestGetStudents()
    {
        Center center = new Center();
        Student student1 = new Student("John Smith");
        Student student2 = new Student("Jane Doe");

        center.AddStudent(student1);
        center.AddStudent(student2);

        Assert.AreEqual(2, center.GetStudents().Count());
        Assert.IsTrue(center.GetStudents().Contains(student1));
        Assert.IsTrue(center.GetStudents().Contains(student2));
    }

    [TestMethod]
    public void TestGetScoreForStudent()
    {
        Course course = new Course("Math");
        Lesson lesson = new Lesson("Linear Algebra", course);
        Student student1 = new Student("John Smith");
        Student student2 = new Student("Jane Doe");
        student1.AddCourse(course);
        student2.AddCourse(course);
        lesson.AddGrade(student1, 90);
        lesson.AddGrade(student2, 80);

        int score1 = lesson.GetScoreForStudent(student1);
        int score2 = lesson.GetScoreForStudent(student2);

        Assert.AreEqual(90, score1);
        Assert.AreEqual(80, score2);
        
        Assert.ThrowsException<ArgumentException>(() => lesson.GetScoreForStudent(new Student("David Silva")));
    }

    [TestMethod]
    public void TestGetScoreForStudentNotEnrolled()
    {
        Course course = new Course("Math");
        Lesson lesson = new Lesson("Linear Algebra", course);
        Student student = new Student("John Smith");
        student.AddCourse(course);
        int score = lesson.GetScoreForStudent(student);

        Assert.AreEqual(0, score);
    }

    [TestMethod]
    public void TestGrade()
    {
        Teacher teacher = new Teacher("John Smith");
        Student student = new Student("Jane Doe");
        Lesson lesson = new Lesson("Math");
        int score = 90;

        int grade = teacher.Grade(student, score, lesson);

        Assert.AreEqual(score, grade);
    }
    
    [TestMethod]
    public void TestCalculateFinalGrade()
    {
        Course course1 = new Course("Math");
        Course course2 = new Course("Physics");

        Lesson lesson1 = new Lesson("Linear Algebra", course1);
        Lesson lesson2 = new Lesson("Linear", course1);
        Lesson lesson3 = new Lesson("Linear Algebra Algebra", course1);
        Lesson lesson4 = new Lesson("Mechanics", course2);
        Lesson lesson5 = new Lesson("Mechanics", course2);
        Lesson lesson6 = new Lesson("Mechanics", course2);
        

        Student student1 = new Student("John Smith");
        Student student2 = new Student("Jane Doe");

        student1.AddCourse(course1);
        student2.AddCourse(course2);

        lesson1.AddGrade(student1, 90);
        lesson2.AddGrade(student1, 85);
        lesson3.AddGrade(student1, 92);
        lesson4.AddGrade(student2, 88);
        lesson5.AddGrade(student2, 95);
        lesson6.AddGrade(student2, 70);
       
       
        int finalGrade1 = student1.CalculateFinalGrade(course1);
        int finalGrade2 = student2.CalculateFinalGrade(course2);

        Assert.AreEqual(89, finalGrade1);
        Assert.AreEqual(84, finalGrade2);
    }
}