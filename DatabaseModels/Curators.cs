using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModels
{
    [Table("Curators")]
    public class Curators
    {
        public Curators(int id, int groupid, string name, string email)
        {
            Id = id;
            GroupId = groupid;
            Name = name;
            Email = email;
        }

        public Curators()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("GroupKey")]
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public Groups Group { get; set; }
    }
}
