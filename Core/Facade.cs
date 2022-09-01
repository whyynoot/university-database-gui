using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseContext;
using DatabaseModels;


namespace Core
{
    public class Facade
    {

        private GroupsManager _groupManager;
        private CuratorsManager _curatorManager;
        private StudentsManager _studentManager;
        private BuisnessTasks _buisnessTasks;
        private ProfessorsManager _professorsManager;

        public Facade(GroupsManager doctorsManager, CuratorsManager certificatesManager,
            StudentsManager specializationsManager, BuisnessTasks buisnessTasks, ProfessorsManager professorsManager)
        {
            _groupManager = doctorsManager;
            _curatorManager = certificatesManager;
            _studentManager = specializationsManager;
            _buisnessTasks = buisnessTasks;
            _professorsManager = professorsManager;
        }

        public DbSet<Groups> GetGroups()
        {
            return _groupManager.GetGroups();
        }

        public void CreateGroup(int id, string name)
        {
            _groupManager.CreateGroup(id, name);
        }

        public void CreateProfessor(int id, string name, int[] groupids)
        {
            _professorsManager.CreateProfessors(id, name, groupids);
        }

        public void ChangeProfessor(int id, string name, int[] groupids)
        {
            _professorsManager.ChangeProfessor(id, groupids, name);
        }

        public void DeleteProfessor(int id)
        {
            _professorsManager.DeleteProfessor(id);
        }


        public void CreateCurator(int id, int groupid, string name, string email)
        {
            _curatorManager.CreateCurator(id, groupid, name, email);
        }

        public void DeleteCurator(int id)
        {
            _curatorManager.DeleteCurator(id);
        }

        public void ChangeCurator(int id, int groupid, string name, string email)
        {
            _curatorManager.ChangeCurator( id, groupid, name, email);
        }

        public DbSet<Curators> LoadCurators()
        {
            return _curatorManager.GetCurators();
        }

        public DbSet<Professors> LoadProfesors()
        {
            return _professorsManager.GetProffesors();
        }

        public DbSet<Students> GetStudents()
        {
            return _studentManager.GetStudents();
        }

        public void CreateStudent(int id, int groupid, string name, int age)
        {
            _studentManager.CreateStudent(id, groupid, name, age);
        }

        public void DeleteStudent(int id)
        {
            _studentManager.DeleteStudent(id);
        }

        public void ChangeStudent(int id, int groupid, string name, int age)
        {
            _studentManager.ChangeStudent( id, groupid, name, age);
        }

        public void ChangeGroup(int id, string name)
        {
            _groupManager.ChangeGroup(id, name);
        }

        public void DeleteGroup(int id)
        {
            _groupManager.DeleteGroup(id);
        }

        public int CountUserByGroupId(int id)
        {
            return _buisnessTasks.GetStudentsCountByGroupId(id);
        }

        public string GetCuratorNameByStudentId(int id)
        {
            return _buisnessTasks.GetCuratorNameByStudentID(id);
        }

        public double GetAverageAgeByGroupId(int id)
        {
            return _buisnessTasks.GetAverageAgeByGroupId(id);
        }
        /*
                public int CountDoctorsWithSpecialization(int id)
                {
                    return _buisnessTasks.GetStudentsCountByGroupId(id);
                }

                public string GetNameOfSpecialization(int id)
                {
                    return _buisnessTasks.GetNameOfSpecialization(id);
                }

                public DateTime GetLastCertificate(int id)
                {
                    return _buisnessTasks.GetLastCertificate(id);
                }*/
    }
}
