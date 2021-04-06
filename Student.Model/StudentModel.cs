using Student.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class StudentModel
    {
        public static List<StudentDto> getAll()
        {
            List<StudentDto> result = new List<StudentDto>();
            DataClasses1DataContext dtx = new DataClasses1DataContext();
            var res = dtx.students.ToList();
            res.ForEach(s => result.Add(new StudentDto { id = s.Id, name= s.name })) ;
            return result;



        }
    }
}
