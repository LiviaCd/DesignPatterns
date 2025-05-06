using Adapter.Adaptee;
using Adapter.Core;
using Adapter.ITarget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    public class CloudStorageAdapter : IPhotoService
    {
        private readonly CloudStorage _cloudStorage = new CloudStorage();
        public void ExportPhoto(Photo photo)
        {
            _cloudStorage.ExportPhotoFromPath(photo.Path);
        }

        public void ImportPhoto(string path, string name)
        {
            _cloudStorage.ImportPhotoFromPath(path);
        }
    }
}
