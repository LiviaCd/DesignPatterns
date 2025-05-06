using Adapter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ITarget
{
    public interface IPhotoService
    {
        public void ImportPhoto(string path, string name);
        public void ExportPhoto(Photo photo);
    }
}
