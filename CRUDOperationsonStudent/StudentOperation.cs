using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsonStudent
{
    public class StudentOperation
    {
        List<Student> stdlist;
        public StudentOperation() 
        {
            stdlist = new List<Student>()
            {
                new Student(){RollNo=1,Name="Payal"},
                new Student(){RollNo=2,Name="Kajal"}
            };
        }

        public List<Student> ShowDetails()
        {
            return stdlist;
        }

        public Student SearchByRollNo(int rollNo)
        {
            Student stR= new Student();
            foreach (Student st in stdlist) 
            {
                if(st.RollNo == rollNo)
                {
                    stR = st;
                    break;
                }
            }
            return stR;
        }

        public void AddStudent(Student st)
        {
            stdlist.Add(st);
        }

        public void UpdateRecord(Student st)
        {
            foreach(Student st1 in stdlist)
            {
                if(st.RollNo==st.RollNo)
                {
                    st1.Name = st.Name;
                    break;
                }
            }
        }

        public void DeleteRecord(int rollno)
        {
            foreach(Student st in stdlist)
            {
                if(st.RollNo==rollno)
                {
                    stdlist.Remove(st);
                    break;
                }
            }

        }

    }
}
