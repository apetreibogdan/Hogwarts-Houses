using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        

        public string Name { get; set; }

        public PetType Pet { get; set; }


        public Student( string name , PetType petType)
        {
          
            Name=name;
            Pet=petType;
        }

     


    }
}
