using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public PetType Pet { get; set; }


        public Student(int id, string name , PetType petType)
        {
            Id=id;
            Name=name;
            Pet=petType;
        }

     


    }
}
