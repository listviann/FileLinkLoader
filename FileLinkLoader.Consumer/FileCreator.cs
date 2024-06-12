namespace FileLinkLoader.Consumer;

public class FileCreator
{
    public string CreateFileFromUrl(string fileUrl)
    {
        var tempFolderPath = Path.GetTempPath();
        Directory.CreateDirectory(tempFolderPath);

        var fileName = Path.GetFileName(fileUrl);
        var filePath = Path.Combine(tempFolderPath, fileName);

        return filePath;
    }
}
