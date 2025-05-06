using Adapter.Adapter;
using Adapter.Core;
using Adapter.ITarget;

class Program
{
    static void Main(string[] args)
    {
        IPhotoService photoService = new CloudStorageAdapter();

        Photo photoModel = new Photo();

        photoService.ImportPhoto("/path", "fileName");
        photoService.ExportPhoto(photoModel);

    }
}