using System;

namespace ExpenseBucket.Core.Entities
{
    public class Backup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public Account Account { get; set; }
    }
}
