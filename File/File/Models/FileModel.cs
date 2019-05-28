using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace File.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
