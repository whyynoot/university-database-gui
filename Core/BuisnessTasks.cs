using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using System.Linq;


namespace Core
{
    public class BuisnessTasks
    {
        private UniversityContext _context;
        public BuisnessTasks(UniversityContext context)
        {
            _context = context;
        }

        public int GetStudentsCountByGroupId(int id)
        {
            try
            {
                return _context.Groups.Find(id).Students.Count;
            } catch
            {
                return -1;
            }
        }

        public string GetCuratorNameByStudentID(int id) 
        {
            try
            {
                return _context.Students.Find(id).Group.Curator.Name;
            }
            catch
            {
                return "Wrong Data";
            }
            
        }

        public double GetAverageAgeByGroupId(int id)
        {
            try
            {
                return _context.Groups.Find(id).Students.Sum(Student => Student.Age) / (double)GetStudentsCountByGroupId(id);
            }
            catch
            {
                return -1.0;
            }
           
        }
    }
}
