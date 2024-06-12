using MassTransit;
using SharedModels;

namespace FileLinkLoader.Consumer;

public class FileUrlConsumer : IConsumer<IUrlSent>
{
    public async Task Consume(ConsumeContext<IUrlSent> context)
    {
        var fileUrl = context.Message.FileUrl;
        Console.WriteLine(fileUrl);
        
        var facade = new FileDownloaderFacade();
        await facade.DownloadFileFromUrl(fileUrl);
    }
}
