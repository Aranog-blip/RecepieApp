using SQLite;

namespace RecepieApp.Models
{
    public class Recepie
    {
        [PrimaryKey, AutoIncrement, Column("Name")]
        public string Name { get; set; }
        public string Type  { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        
    }
}
