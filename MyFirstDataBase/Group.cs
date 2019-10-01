using System.Collections.Generic;

namespace MyFirstDataBase
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
