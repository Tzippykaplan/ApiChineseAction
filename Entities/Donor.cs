﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Donor :Person
    {

        public List<Gift>? MyGiftsList { get; set; }

    }
}
