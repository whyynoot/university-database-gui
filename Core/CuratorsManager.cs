using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;


namespace Core
{
    public class CuratorsManager
    {
        private UniversityContext _context;
        public CuratorsManager(UniversityContext context)
        {
            _context = context;
        }

        public void CreateCurator(int id, int groupId, string name, string email)
        {
            Curators curator = new Curators(id, groupId, name, email);
            try
            {
                _context.Add(curator);
                _context.SaveChanges();
            } catch (System.Exception ex)
            {
                _context.Remove(curator);
                _context.SaveChanges();
                throw ex;
            }
        }

        public void DeleteCurator(int id)
        {
            Curators curator = _context.Curators.Find(id);
            _context.Remove(curator);
            _context.SaveChanges();
        }

        public void ChangeCurator(int id, int groupId, string name, string email)
        {
            Curators curator = _context.Curators.Find(id);
            curator.GroupId = groupId;
            curator.Name = name;
            curator.Email = email;
            _context.SaveChanges();
        }

        public DbSet<Curators> GetCurators()
        {
            return _context.Curators;
        }
    }
}
