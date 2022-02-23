using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T>
    {
        public List<T> studList { get; set; }
        public void Save();
    }
}
