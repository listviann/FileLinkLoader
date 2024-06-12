namespace FileLinkLoader.Consumer;

public class FileDownloaderFacade
{
    private readonly FileCreator _fileCreator;
    private readonly FileDownloader _fileDownloader;

    public FileDownloaderFacade()
    {
        _fileCreator = new();
        _fileDownloader = new();
    }

    public async Task<string> DownloadFileFromUrl(string fileUrl)
    {
        try
        {
            string filePath = _fileCreator.CreateFileFromUrl(fileUrl);
            var result = await _fileDownloader.DownloadFileToTemp(filePath, fileUrl);

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return $"Error: {ex.Message}";
        }
    }
}
