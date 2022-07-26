﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Category
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
