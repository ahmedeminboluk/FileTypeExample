using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    public class BigPara 
    {
        public string Title { get; set; }
        public string Spot { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public int Order { get; set; }
    }
}
