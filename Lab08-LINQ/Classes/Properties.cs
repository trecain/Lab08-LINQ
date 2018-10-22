﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08_LINQ.Classes
{
    public class Properties
    {
        /// <summary>
        /// grab all prop information out the feature list
        /// </summary>
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Borough { get; set; }
        public string Neighborhood { get; set; }
        public string County { get; set; }
    }
}
