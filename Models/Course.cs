namespace EFProj.Models
{
    //[Table("courses")]
    public class Course
    {
        //[Key]
        public int Id { get; set; }
        public string Title { get; set; }
        //[Column("Length")]
        public int Duration { get; set; }
        //[NotMapped]
        public string Description { get; set; }
    }
}
