﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ActivityTwo {
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        [JsonIgnore]
        public virtual ICollection<Products> Products { get; set; }
    }
}
