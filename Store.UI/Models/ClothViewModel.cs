﻿using Store.Domain;
using Store.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.UI.Models
{
    public class ClothViewModel
    {
        public IEnumerable<ICloth> Clothes { get; set; }
    }
}