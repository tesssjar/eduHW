using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<T> : IRepository<T>
    {
        public string FilePath { get; set; }
        public Repository(string path)
        {
            FilePath = path;
        }
        public List<T> studList { get; set; }

        public void Save()
        {
            
        }
    }
}