using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModels
{
    [Table("Professors")]
    public class Professors
    {
        public Professors(int id, string name)
        {
            Id = id;
            Name = name;
            this.Groups = new HashSet<Groups>();
            //Groups = new List<GroupsProffesors>();
        }
        public Professors()
        {
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ICollection<Groups> Groups { get; set; } = new List<Groups>();
    }

    [Table("GroupsProfesors")]
    public class GroupsProffesors
    {
        [Key]
        public int profId { get; set; }

        [Key]
        public int groupId { get; set; }

        public GroupsProffesors(int group, int id)
        {
            profId = id;
            groupId = id;
        }

        [ForeignKey("GroupKey")]
        public Groups Group { get; set; }
        [ForeignKey("ProfessorsKey")]
        public Professors Professor { get; set; }
    }
}
