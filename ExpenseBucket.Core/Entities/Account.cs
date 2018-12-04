﻿using System.Collections.Generic;

namespace ExpenseBucket.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Backup> Backups { get; set; }
    }
}
