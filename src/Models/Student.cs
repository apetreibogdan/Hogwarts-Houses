using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public PetType Pet { get; set; }



    }
}
