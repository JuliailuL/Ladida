 using Interfaces;

var consoleLogger = new ConsoleLogger();

var orderService = new OrderService(consoleLogger);
orderService.ProcessOrder("123456");
orderService.ProcessOrder("789101");

var filelogger = new FileLogger("./logger.txt");
var orderServiceWithFileLogging = new OrderService(filelogger);
orderServiceWithFileLogging.ProcessOrder("KannNix"); 
orderServiceWithFileLogging.ProcessOrder("RaffNix");