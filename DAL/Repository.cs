using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            string jsonString = JsonSerializer.Serialize(studList);

            using (FileStream fStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                JsonSerializer.Serialize(fStream, studList);
            }
        }
    }
}