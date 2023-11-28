using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Models
{
    public class Products
    {
        public string Serial { get; set; }
        public string ProductName { get; set; }
        public int? PurchasePrice { get; set; }
        public int? SalePrice { get; set; }
        public int? Quantity { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; } = false;
        public List<ProductImages> ImageUrls { get; set; } = new List<ProductImages>();
        public Products()
        {
            Serial = string.Empty;
            ProductName = string.Empty;
        }
    }   
}
