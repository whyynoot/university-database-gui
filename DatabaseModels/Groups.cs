using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModels
{
    [Table("Groups")]
    public class Groups
    { 
        public Groups(int id, string name)
        {
            Id = id;
            Name = name;
            CreationDate = DateTime.Now;
            Professors = new HashSet<Professors>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreationDate { get; set;}
        public ICollection<Students> Students { get; set; }
        public ICollection<Professors> Professors { get; set; } = new List<Professors>();
        public Curators Curator { get; set; }
    }

}
