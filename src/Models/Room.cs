using System.Collections.Generic;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public int ID { get; set; }

        public bool Available { get; set; }

        public List<Student> Students { get; set; }



    }
}
