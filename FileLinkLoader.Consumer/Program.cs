using FileLinkLoader.Consumer;
using MassTransit;

var busControl = Bus.Factory.CreateUsingRabbitMq(config => 
{
    config.ReceiveEndpoint("file-url-sent-event", e =>
    {
        e.Consumer<FileUrlConsumer>();
    });
});

await busControl.StartAsync(new CancellationToken());

try
{
    Console.WriteLine("Consuming file URL. Press enter to exit");
    
    await Task.Run(() => Console.ReadLine());
}
finally
{
    await busControl.StopAsync();
}