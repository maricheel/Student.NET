using Student.Dto;
using Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Controleur
{
    public class StudentControleur
    {
        public static List<StudentDto> getAll()
        {
            return StudentModel.getAll().ToList();
        }



    }
}
