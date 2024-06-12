# FileLinkLoader
Данное приложение было разработано в рамках тестового задания.
При развертывании локально позволяет загружать в файлы изображения через их URL.
Данное приложение имеет 2 сервиса:

* FileLinkLoader.API
* FileLinkLoader.Consumer

FileLinkLoader.API - API которрый принимает get запрос в котрый передается url для скачивания файла и ретранслирует его через RabbitMq на consumer на втором сервисе.
FileLinkLoader.Consumer - второй сервис, который скачивает файл из переданного url и кладет его во временную папку.

В сочетании с RabbitMQ при разработке также использовалась библиотека MassTransit.