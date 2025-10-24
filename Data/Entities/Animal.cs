using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeRefactoring.Constants;

namespace CodeRefactoring.Data.Entities
{
    public class Animal
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

        public Animal()
        {
            Id = Guid.NewGuid().ToString();
        }

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            SickOrNot = false;
            Notes = "feeling ok i guess";
        }

    }
}