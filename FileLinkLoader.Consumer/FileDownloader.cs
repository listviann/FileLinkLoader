namespace FileLinkLoader.Consumer;

public class FileDownloader
{
    private readonly HttpClient _client = new();
    
    public async Task<string> DownloadFileToTemp(string filePath, string fileUrl)
    {
        using var response = await _client.GetAsync(fileUrl);
        if (response.IsSuccessStatusCode)
        {
            using var stream = System.IO.File.Create(filePath);
            await response.Content.CopyToAsync(stream);
            return "OK";
        }
        else
        {
            return "Failed to download file";
        }
    }
}
