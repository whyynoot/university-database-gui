using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class ProfessorsManager
    {
        private UniversityContext _context;

        public ProfessorsManager(UniversityContext context)
        {
            _context = context;
        }

        public void CreateProfessors(int id, string name, int[] groupids)
        {
            Professors professor = new Professors(id, name);
            foreach (var groupid in groupids)
            {
                professor.Groups.Add(_context.Groups.Find(groupid));
            }
            /*foreach (var groupid in groupids)
            {
                professor.Groups.Add(new GroupsProffesors(groupid, id));
            }*/

            try
            {
                _context.Add(professor);
                _context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                _context.Remove(professor);
                _context.SaveChanges();
                throw ex;
            }
        }

        public void DeleteProfessor(int id)
        {
            Professors professor = _context.Professors.Find(id);
            _context.Remove(professor);
            _context.SaveChanges();
        }

        public void ChangeProfessor(int id, int[] groupids, string name)
        {
            Professors professor = _context.Professors.Find(id);
            professor.Groups.Clear();
            foreach (var groupid in groupids)
            {
                professor.Groups.Add(_context.Groups.Find(groupid));
            }
            professor.Name = name;
            _context.SaveChanges();
        }

        /*public List<int> getProffesorsGroups(int id)
        {
            var gr = _context.Professors
                                .Include(p=> p.Groups);
        }*/
       

        public DbSet<Professors> GetProffesors()
        {
            return _context.Professors;
        }

        
    }
}
