using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_manage_system
{
    public class studentmanagement
    {
        public int total =0;
        public double per =0;
        List<studentinfo> studentinfos;

        public studentmanagement()
        {
            studentinfos = new List<studentinfo>();
        } 

        public void addstudent(studentinfo studen)
        {
            studentinfos.Add(studen);
        }
        public void display()
        {
            foreach (studentinfo info in studentinfos)
            {
                Console.WriteLine(info.Student_id);
                Console.WriteLine(info.Student_name);
                Console.WriteLine(info.Student_maks1);
                Console.WriteLine(info.Student_maks2);
                Console.WriteLine(info.Student_maks3);

                 int sum = info.Student_maks1+info.Student_maks2+info.Student_maks3;
                Console.WriteLine(sum);

                double per = sum / 3;
                Console.WriteLine(per);
                    
                    }
        }
    }
}
