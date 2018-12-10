using System;
using System.Collections.Generic;

namespace ExpenseBucket.Core.Entities
{
    public class Backup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }

        public User Account { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
