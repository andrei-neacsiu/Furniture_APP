﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PartDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

    }
}
