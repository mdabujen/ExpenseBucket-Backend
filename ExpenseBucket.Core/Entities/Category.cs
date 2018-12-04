namespace ExpenseBucket.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
        public Backup Backup { get; set; }
    }
}
