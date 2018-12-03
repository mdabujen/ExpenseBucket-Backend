using System;

namespace ExpenseBucket.Core.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Hierarchy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }        
        public int LocalId { get; set; }
        public int ParentId { get; set; }        
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal StartingBudget { get; set; }
        public Category Category { get; set; }
        public Backup Backup { get; set; }

    }
}
