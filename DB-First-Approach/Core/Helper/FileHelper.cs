using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper;

public class FileHelper : MemoryStream
{
    public FileHelper(MemoryStream options) : base()
    {

    }

    public void StreamFile(string FilePath, IFormFile file)
    {
        string uploads = Path.Combine(FilePath, "Uploads");
        //Create directory if it doesn't exist 
        Directory.CreateDirectory(uploads);

        if (file.Length > 0)
        {
            string filePath = Path.Combine(uploads, file.FileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }
        }

    }

}
