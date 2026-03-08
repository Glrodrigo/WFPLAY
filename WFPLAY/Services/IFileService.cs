// IFileService.cs

namespace WFPLAY.Services
{
    public interface IFileService
    {
        void UploadFile(string filePath);
        byte[] DownloadFile(string fileName);
        void DeleteFile(string fileName);
        IList<string> ListFiles();
    }
}