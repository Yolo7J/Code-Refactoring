using System;
using Namespace;

namespace NameSpace
{
    public class AnimalService
    {
        private CodeRefactorDbContext _db;
        public AnimalService(CodeRefactorDbContext d) { _db = d; }

        public void DoHeal(int id)
        {
            var x = _db.Animal.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal id=" + id);
            }
        }

        public void AddNewAnimal(string n, string o, int a, string t)
        {
            var newAnimal = new Animal();
            newAnimal.Id = new Random().Next(1000, 9999);
            newAnimal.Name = n;
            newAnimal.Owner = o;
            newAnimal.Age = a;
            newAnimal.Type = t;
            newAnimal.SickOrNot = false;
            _db.Animal.Add(newAnimal);
        }

        public void RandomAgeUp()
        {
            foreach (var x in _db.Animal.ToList())
            {
                x.agee += 7;
            }
        }
    }
}
