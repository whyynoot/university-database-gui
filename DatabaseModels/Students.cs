using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModels
{
    [Table("Students")]
    public class Students
    {
        public Students()
        {
        }
        public Students(int id, string name, int groupid, int age)
        {
            Id = id;
            Name = name;
            GroupId = groupid;
            Age = age;
        }
        public Groups Group { get; set; }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("GroupKey")]
        public int GroupId { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
