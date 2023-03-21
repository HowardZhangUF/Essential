using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericList
{
    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>
        {
           new Student {Name="Adam", Sexual=1, ID=1055010001},
           new Student {Name="Steven", Sexual=2, ID=1055010002},
           new Student {Name="Brown", Sexual=1, ID=1055010003},
           new Student {Name="Cindy", Sexual=2, ID=1055010004},
           new Student {Name="Tom", Sexual=1, ID=1055010005}
        };

        return students;

    }

    static void Main(string[] args)
    {
        List<Student> students = GetStudents();
        foreach (var i in students)
        {
            string sex = i.Sexual == 1 ? "male" : "female";
            Console.WriteLine("Name:" + i.Name + ", Sexual:" + sex + ", ID:" + i.ID);
        }

    }
}
}
