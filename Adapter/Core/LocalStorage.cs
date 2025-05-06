using Adapter.ITarget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    public class LocalStorage : IPhotoService
    {
        public void ExportPhoto(Photo photo)
        {
            Console.WriteLine("Export photo in local storage");
        }

        public void ImportPhoto(string path, string name)
        {
            Console.WriteLine("Import photo from local storage");
        }
    }
}
