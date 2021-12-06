using StudentsGrades; 

List <Teacher>listOfStudents=new List<Teacher>();

List<string> StudentList = new List<string>();

Console.WriteLine("to add a student enter 1");
int users=int.Parse(Console.ReadLine());

void switchCheck()
{
switch (users)
{
    case 1:
        GetDetails();
        break;

    default:
        break;
}
}




void GetDetails()
{
    Console.WriteLine("put your name");
    string name = Console.ReadLine();

    Console.WriteLine("put the number of students");
    int studentNum = int.Parse(Console.ReadLine());

    for (int i = 0; i < studentNum; i++)
    {
        Teacher student = new Teacher();
        student.TeacherName = name;

        Console.WriteLine($"student{i + 1} name:");
        student.studentName = Console.ReadLine();

        Console.WriteLine($"student {i + 1} id");
        student.studentId = int.Parse(Console.ReadLine());

        Console.WriteLine("put 3 student grades");
        student.grades = new int[3];
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine($"student grade{j + 1}");
            student.grades[j] = int.Parse(Console.ReadLine());
        }
        listOfStudents.Add(student);

    }
    saveTeacher();


}
    
void saveTeacher()
{
    int counterId = 0;
    foreach(Teacher student in listOfStudents)
    {
        FileStream teachers = new FileStream($@"C:\test\{student.TeacherName}.txt", FileMode.Append);
        using (StreamWriter Writer = new StreamWriter(teachers))
        {
            Writer.WriteLine($"id:{ counterId}");
            Writer.WriteLine($"students name:{student.studentName}");
            Writer.WriteLine($"Student id:{student.studentId}");
            //Writer.WriteLine($"id:{ counterId}");
            foreach(int grade in student.grades)
            {
                Writer.Write(grade + " ,");
            }
            Writer.WriteLine();
            counterId++;
        }
    }
}


void addStudent(string students)
{
    FileStream teachers = new FileStream($@"C:\test\{students}.txt", FileMode.Open);
    using (StreamReader Reader = new StreamReader(teachers))
    {
        for (int i = 0; i < Reader.Peek(); i++)
        {
            StudentList.Add(Reader.ReadLine());
        }
    }
   foreach(string item in StudentList)
    {
        Console.WriteLine(item);
        
    }
}
addStudent("haim");














































































