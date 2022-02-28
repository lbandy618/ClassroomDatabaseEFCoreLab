using ClassroomDatabaseEFCoreLab;

//main


DisplayAllDB();

DisplayStudentDB();


//methods

static void DisplayAllDB()
{
    using (ClassContext context = new ClassContext())
    {

        foreach(Student stu in context.Students)
        {
            Console.WriteLine($"{stu.StudentID} {stu.Name}");
        }
        Console.WriteLine(); 
    }
}

static void DisplayStudentDB()
{
    using(ClassContext context = new ClassContext())
    {
        Console.Write("Please choose a student ID: ");
        int id = int.Parse(Console.ReadLine());
        Student studentResult = context.Students.First(s => s.StudentID == id);
        Console.WriteLine($"{studentResult.Name} is from {studentResult.Hometown}, and their favorite food is {studentResult.Food}.");
    }
}

//static void CreateDB()
//{
//    using (ClassContext context = new ClassContext())
//    {
//        List<Student> tempList = new List<Student>()
//        {
//            new Student()
//            {
//                Name = "Justin",
//                Food = "Baja Blast",
//                Hometown = "Wyoming",

//            },
//            new Student()
//            {
//                Name = "Lucas",
//                Food = "Sushi",
//                Hometown = "Louisville",

//            },
//            new Student()
//            {
//                Name = "Aaliyah",
//                Food = "Chicken Wings",
//                Hometown = "Manchester",

//            },
//            new Student()
//            {
//                Name = "Jon",
//                Food = "Bacon",
//                Hometown = "Toledo",

//            },
//            new Student()
//            {
//                Name = "Tarik",
//                Food = "Tacos",
//                Hometown = "Queens, NY",

//            },
//            new Student()
//            {
//                Name = "Alex",
//                Food = "Spaghetti",
//                Hometown = "Ferndale",

//            },
//            new Student()
//            {
//                Name = "Josh",
//                Food = "Nalesniki",
//                Hometown = "California",

//            }
//        };
//        context.Students.AddRange(tempList);
//        context.SaveChanges();
//    };
//}

