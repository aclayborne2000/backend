﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListApi.Data
{
    public class ShoppingItem
    {
        public int Id { get;  set; }
        public string Description { get; set; }
        public bool Purchased { get; set; }
    }
}
