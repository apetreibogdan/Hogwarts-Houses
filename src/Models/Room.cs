using System.Collections.Generic;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public int ID { get; set; }

        public bool IsOcupied { get; set; }



        public List<Student> Roommates { get; set; }



    }
}
