namespace CodeRefactoring.Models
{
    public class Animal
    {
        public int Id;
        public string Name;
        public string Owner;
        public int Age;
        public string Type;
        public bool SickOrNot = false;
        public string Notes = "";

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