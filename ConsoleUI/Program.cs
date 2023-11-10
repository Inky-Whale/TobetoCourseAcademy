// See https://aka.ms/new-console-template for more information

using Business.Concretes;
using Entities.Concretes;


Category category1 = new Category()
{
    Id = 1,
    Name = "Programlama",
    Courses = new List<Course>()
};

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);

Course course1 = new Course()
{
    Id = 1,
    Name = "Programlamaya giriş",
    Description = "giriş dersleri",
    CategoryId = 1,
    InstructorId = 1,
    Price = 200
};

CourseManager courseManager = new CourseManager();
courseManager.Add(course1);

Instructor[] instructors = new Instructor[]
{
    new Instructor{Id = 1, FirstName = "Engin", LastName = "Demiroğ"},
    new Instructor{Id = 2,FirstName = "Halit Enes", LastName = "Kalaycı"}
};

InstructorManager  instructorManager = new InstructorManager();
foreach (var instructor in instructors)
{
    instructorManager.Add(instructor);
    
}