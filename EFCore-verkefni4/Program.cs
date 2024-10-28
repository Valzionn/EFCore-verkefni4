using EFCore_verkefni4.Data;
using EFCore_verkefni4.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // new Teacher
            var teacher = new Teacher
            {
                Category = 1,
                FirstName = "Albert",
                LastName = "Einstein"
            };
            context.Teachers.Add(teacher);
            context.SaveChanges();

            Console.WriteLine("Teacher added");


            // new Subject
            var subject = new Subject
            {
                Title = "Mathematics"
            };
            context.Subjects.Add(subject);
            context.SaveChanges();

            Console.WriteLine("Subject added");

            //new Group
            var group = new Group
            {
                Name = "Group A"
            };
            context.Groups.Add(group);
            context.SaveChanges();

            Console.WriteLine("Group added");

            // new Student
            var student = new Student
            {
                FirstName = "Mikill",
                LastName = "Hugsudur",
                GroupId = group.GroupId // Associate with Group
            };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added");

            // Associate the Teacher with the Subject
            var subjectTeacher = new SubjectTeacher
            {
                TeacherId = teacher.TeacherId,
                SubjectId = subject.SubjectId
            };
            context.SubjectTeachers.Add(subjectTeacher);
            context.SaveChanges();

            Console.WriteLine("Teacher - Subject added");

            // Student mark
            var mark = new Mark
            {
                StudentId = student.StudentId,
                SubjectId = subject.SubjectId,
                Date = DateTime.Now,
                Value = 85 // Example mark
            };
            context.Marks.Add(mark);
            context.SaveChanges();

            Console.WriteLine("Student Mark added");
        }
    }
}
