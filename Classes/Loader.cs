using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Classes
{
    public class Loader
    {
        private string connectionString;
        public Loader(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task Upload(IFormFile image, string containerName)
        {
            if (image.Length > 0)
            {
                using (var fileStream = image.OpenReadStream())
                {                    
                    await LoadBlob(containerName, fileStream);
                }
            }
        }

        private async Task LoadBlob(string fileName, Stream uploadFileStream)
        {            
            uploadFileStream.Position = 0;
            await GetBlobClient(fileName).UploadAsync(uploadFileStream, true);
        }

        private BlobClient GetBlobClient(string fileName)
        {            
            BlobContainerClient containerClient = CreateContainerClient(fileName);            
            return containerClient.GetBlobClient(fileName);
        } 
        
        private BlobContainerClient CreateContainerClient(string fileName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);            
            return blobServiceClient.CreateBlobContainer(fileName);
        }

        public async Task DeleteContainer(string fileName)
        {
            if(fileName != null)
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(fileName);
                await containerClient.DeleteAsync();
            }            
        }

        public async Task<string> GetImage(string filename)
        {            
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);          
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(filename);
            BlobClient blobClient = containerClient.GetBlobClient(filename);
            BlobDownloadInfo download = await blobClient.DownloadAsync();
            return Convert.ToBase64String(ReadStream(download.Content));
        }

        private byte[] ReadStream(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public static string CreateContainerName(string fileName)
        {
            string ImageGuid = Guid.NewGuid().ToString();
            return ImageGuid + fileName.Substring(fileName.LastIndexOf('.') + 1);
        }
    }
}
