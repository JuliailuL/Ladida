 using Interfaces;

var logger = new FileLogger();
var orderService = new OrderService(logger);
orderService.ProcessOrder("12345"); 
orderService.ProcessOrder("67891");

var filelogger = new FileLogger();
var orderServiceWithFileLogging = new OrderService(filelogger);
orderService.ProcessOrder("KannNix"); 
orderService.ProcessOrder("RaffNix");