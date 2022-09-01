using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class GroupsManager
    {
        private UniversityContext _context;
        public GroupsManager(UniversityContext context)
        {
            _context = context;
        }

        public void CreateGroup(int id, string name)
        {
            Groups group = new Groups(id, name);
           
            try
            {
                _context.Add(group);
                _context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                _context.Remove(group);
                _context.SaveChanges();
                throw ex;
            }
        }

        public void DeleteGroup(int id)
        {
            Groups group = _context.Groups.Find(id);
            _context.Remove(group);
            _context.SaveChanges();
        }

        public void ChangeGroup(int id, string name)
        {
            Groups doctor = _context.Groups.Find(id);
            doctor.Name = name;
            _context.SaveChanges();
        }

        public DbSet<Groups> GetGroups()
        {
            return _context.Groups;
        }
    }
}
