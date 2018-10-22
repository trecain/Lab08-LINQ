using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Lab08_LINQ.Classes;

namespace Lab08_LINQ.Classes
{
    public class FeatureCollection
    {
        ///<summary>
        /// create properties that will hold the bulk of the information in the JSON file
        /// </summary>
        
        public string Type { get; set; }
        public List<Feature> Features  { get; set; }
    }
}
