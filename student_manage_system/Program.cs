using student_manage_system;

studentmanagement studentmanagement = new studentmanagement();
studentinfo studentinfo = new studentinfo();

Console.WriteLine("student id");
studentinfo.Student_id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("student name");
studentinfo.Student_name = Console.ReadLine();

Console.WriteLine("student maks1");
studentinfo.Student_maks1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("student maks2");
studentinfo.Student_maks2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("student maks3");
studentinfo.Student_maks3 = Convert.ToInt32(Console.ReadLine());

studentmanagement.addstudent(studentinfo);
studentmanagement.display();
