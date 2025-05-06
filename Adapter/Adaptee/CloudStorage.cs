using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adaptee
{
    public class CloudStorage
    {
        public void ImportPhotoFromPath(string path)
        {
            Console.WriteLine("Import photo from path");
        }

        public void ExportPhotoFromPath(string path)
        {
            Console.WriteLine("Export photo from path");
        }
    }
}
