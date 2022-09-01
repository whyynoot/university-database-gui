using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class StudentsManager
    {
        private UniversityContext _context;

        public StudentsManager(UniversityContext context)
        {
            _context = context;
        }

        public void CreateStudent(int id, int groupid, string name, int age)
         {
             Students student = new Students(id, name, groupid, age);
            try
            {
                _context.Add(student);
                _context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                _context.Remove(student);
                _context.SaveChanges();
                throw ex;
            }
        }

        public void DeleteStudent(int id)
        {
            Students student = _context.Students.Find(id);
            _context.Remove(student);
            _context.SaveChanges();
        }

        public void ChangeStudent(int id, int groupid, string name, int age)
        {
            Students student = _context.Students.Find(id);
            student.Name = name;
            student.GroupId = groupid;
            student.Age = age;
            _context.SaveChanges();
        }

      
        public DbSet<Students> GetStudents()
        {
            return _context.Students;
        }

    }
}
