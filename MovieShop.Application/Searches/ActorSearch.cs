﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Application.Searches
{
    public class ActorSearch : PagedSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
