namespace ExpenseBucket.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public object ImageId { get; set; }
        public Backup Backup { get; set; }
    }
}
