using SQLite;

namespace RecepieApp.Models
{
    [Table("recepie")]
    public class Recepie
    {
        [PrimaryKey, AutoIncrement, Column("Id")]

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Type  { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        
    }
}
