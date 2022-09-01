using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Microsoft.EntityFrameworkCore;
using DatabaseContext;

namespace Doctors
{
    public partial class Form1 : Form
    {
        const string connectionString = "User ID=postgres;Password=root;Server=localhost;Port=5432;Database=postgresss;";
        private Facade facade;
        public Form1()
        {
            InitializeComponent();
            //string connectionString = "Data Source=d:/university.db;";
            

           // var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            //optionsBuilder.UseNpgsql(connectionString);


            UniversityContext context = new UniversityContext(connectionString);

            GroupsManager doctorsManager = new GroupsManager(context);
            CuratorsManager certificatesManager = new CuratorsManager(context);
            StudentsManager specializationsManager = new StudentsManager(context);
            BuisnessTasks buisnessTasks = new BuisnessTasks(context);
            ProfessorsManager professorsManager = new ProfessorsManager(context);

            facade = new Facade(doctorsManager, certificatesManager, specializationsManager, buisnessTasks, professorsManager);



            curatorsGrid.Columns.Add("Id", "ID");
            curatorsGrid.Columns.Add("GroupId", "GroupID");
            curatorsGrid.Columns.Add("Name", "Имя");
            curatorsGrid.Columns.Add("Email", "Email");


            groupsGrid.Columns.Add("Id", "ID");
            groupsGrid.Columns.Add("Name", "Имя");
            groupsGrid.Columns.Add("CreationDate", "Дата создания");

            studentsGrid.Columns.Add("Id", "ID");
            studentsGrid.Columns.Add("GroupId", "GroupID");
            studentsGrid.Columns.Add("Name", "Имя");
            studentsGrid.Columns.Add("Age", "Возраст");

            proffesorsGrid.Columns.Add("Id", "ID");
            proffesorsGrid.Columns.Add("GroupIds", "GroupIds");
            proffesorsGrid.Columns.Add("Name", "Имя");
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Произошла ошибка");
        }

        private void loadGroups_Click(object sender, EventArgs e)
        {
            groupsGrid.Rows.Clear();

            var groups = facade.GetGroups();

            foreach (var group in groups)
            {
                groupsGrid.Rows.Add(group.Id, group.Name, group.CreationDate);
            }
        }

        private void loadCer(object sender, EventArgs e)
        {
            curatorsGrid.Rows.Clear();

             var curators = facade.LoadCurators();

            foreach (var curator in curators)
            {
                curatorsGrid.Rows.Add(curator.Id, curator.GroupId, curator.Name, curator.Email);
            }
        }

        private void studentsLoad_Click(object sender, EventArgs e)
        {
            studentsGrid.Rows.Clear();

            var students = facade.GetStudents();

            foreach (var student in students)
            {
                studentsGrid.Rows.Add(student.Id, student.GroupId, student.Name, student.Age);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proffesorsGrid.Rows.Clear();

            var proffesors = facade.LoadProfesors();



            foreach (var proffesor in proffesors)
            {
                List<int> groupslist = new List<int>();
                foreach (var group in proffesor.Groups)
                {
                    groupslist.Add(group.Id);

                }
                proffesorsGrid.Rows.Add(proffesor.Id, string.Join(",", groupslist), proffesor.Name);
            }

            /*foreach (var curator in curators)
            {
                curatorsGrid.Rows.Add(curator.Id, curator.GroupId, curator.Name, curator.Email);
            }*/
        }

        private void profAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(profID.Text);
                string name = profName.Text;
                var result = profgroupIds.Text.Contains(",") ? profgroupIds.Text.Split(",") : profgroupIds.Text.Split(" ");
                int[] groupsids = Array.ConvertAll(result, s => int.Parse(s));
                facade.CreateProfessor(id, name, groupsids);
            } catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(profID.Text);
                facade.DeleteProfessor(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(profID.Text);
                string name = profName.Text;
                var result = profgroupIds.Text.Contains(",") ? profgroupIds.Text.Split(",") : profgroupIds.Text.Split(" ");
                int[] groupsids = Array.ConvertAll(result, s => int.Parse(s));
                facade.ChangeProfessor(id, name, groupsids);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(groupid.Text);
                string name = groupname.Text;

                facade.CreateGroup(id, name);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void changeGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(groupid.Text);
                string name = groupname.Text;

                facade.ChangeGroup(id, name);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }



        private void deleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(groupid.Text);

                facade.DeleteGroup(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void createCur_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CurId.Text);
                int groupId = int.Parse(textBox3.Text);
                string name = CurName.Text;
                string email = CurEmail.Text;

                facade.CreateCurator(id, groupId, name, email);
            }
            catch (Exception ex)
            {
                try
                {
                    ShowError(ex.InnerException.Message);
                } catch {
                    ShowError(ex.Message);
                }
            }
           
         
        }

        private void changeCer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CurId.Text);
                int groupId = int.Parse(CurId.Text);
                string name = CurName.Text;
                string email = CurEmail.Text;

                facade.ChangeCurator(id, groupId, name, email);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void deleteCer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CurId.Text);

                facade.DeleteCurator(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void createStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(student.Text);
                string name = studname.Text;
                int groupid = int.Parse(textBox1.Text);
                int age = int.Parse(textBox2.Text);
                if (age <= 0) 
                {
                    throw new Exception(message: "Возраст не может быть ниже 0 или равен 0");
                }

                facade.CreateStudent(id, groupid, name, age);
            }
            catch (Exception ex)
            {
                try
                {
                    ShowError(ex.InnerException.Message);
                }
                catch
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void changeStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(student.Text);
                string name = studname.Text;
                int groupid = int.Parse(textBox1.Text);
                int age = int.Parse(textBox2.Text);
                facade.ChangeStudent(id, groupid, name, age);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void deleteStudents_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(student.Text);

                facade.DeleteStudent(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void countStudents_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(countDoctorsTb.Text);
                int count = facade.CountUserByGroupId(id);

                studenetsCount.Text = (count != -1) ? count.ToString() : "Wrong ID";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void findSpec_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSpecTb.Text);

                findSpecLabel.Text = facade.GetCuratorNameByStudentId(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void cerDate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cerDateTb.Text);
                double age = facade.GetAverageAgeByGroupId(id);

                cerDateLabel.Text = (age != -1.0) ? age.ToString() : "Wrong Data";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
