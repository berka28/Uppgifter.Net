using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SharedClassLibrary.Helpers
{
    public static class FileHelper
    {
        public static async Task<string> GetFileContentAsync(string filename)
        {
            StorageFolder storageFolder = KnownFolders.DocumentsLibrary;
            StorageFile file = await storageFolder.GetFileAsync(filename);

            return await FileIO.ReadTextAsync(file);
        }
    }
}
