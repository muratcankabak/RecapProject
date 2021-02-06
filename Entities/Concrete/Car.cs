﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarDescription { get; set; }
    }
}
