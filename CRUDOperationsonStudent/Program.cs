using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsonStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            StudentOperation crud = new StudentOperation();
            do
            {
                Console.WriteLine("1.Show Student Datails");
                Console.WriteLine("2.Search Student by Id");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Record");
                Console.WriteLine("5.Delete Record");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<Student> stlist = crud.ShowDetails();
                        foreach(Student s in stlist)
                        {
                            Console.WriteLine($"{s.RollNo}\t{s.Name}");
                            
                        }
                        break;
                        case 2:
                        Console.WriteLine("Enter Roll Number you want to search Record");
                        int RollNo= Convert.ToInt32(Console.ReadLine());
                        Student strec= crud.SearchByRollNo(RollNo);
                        Console.WriteLine($"{strec.RollNo}\t{strec.Name}");
                        break;
                        case 3:
                        Student stadd=new Student();
                        Console.WriteLine("Enter Roll number");
                        stadd.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name of Student");
                        stadd.Name = Console.ReadLine();
                        crud.AddStudent(stadd);
                        break;
                        case 4:
                        Student stup=new Student();
                        Console.WriteLine("Enter Roll Number of Student you want to Update");
                        stup.RollNo= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        stup.Name = Console.ReadLine();
                        crud.UpdateRecord(stup);
                        break;
                        case 5:
                       // Student stdel=new Student();
                        Console.WriteLine("Enter Roll Number to Delete Record");
                        int rollno= Convert.ToInt32(Console.ReadLine());
                        crud.DeleteRecord(rollno);
                        break;

                }
                Console.WriteLine("Enter 1 To Continue");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 1);
        }
    }
}
