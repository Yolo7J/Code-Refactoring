using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeRefactoring.Constants;

namespace CodeRefactoring.Models
{
    public class AnimalDetails
    {
        [Key]
        public string Id;
        [MaxLength(AnimalConstants.MaxNameLength), MinLength(AnimalConstants.MinNameLength)]
        public string Name;
        [ForeignKey("OwnerId")]
        public User Owner;
        public string OwnerId;
        [Range(AnimalConstants.MinAge, AnimalConstants.MaxAge)]
        public ushort Age;
        [Required]
        [MaxLength(AnimalConstants.MaxTypeLength)]
        public string Type;
        public bool SickOrNot = false;
        [MaxLength(AnimalConstants.MaxNoteLength)]
        public string Notes = "";

        public AnimalDetails()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}