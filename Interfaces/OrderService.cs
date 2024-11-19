namespace Interfaces;

public class OrderService
{
    private FileLogger logger;
    public OrderService(FileLogger logger)
    {
        this.logger = logger;
    }

    public void ProcessOrder(string orderID)
    {
    /* Hier den Logger zu instanziieren macht diese Klasse abhängig von der spezifischen Logger-Implementation
     * Wenn die Logger - Implementation ausgetauscht werden soll, kann dies zu viel Arbeit führen, je nach größe der Klasse */
    var logger = new FileLogger();
    logger.Log($"Order {orderID} is being processed...");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} processed successfully.");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} processing complete.");
    
  }
}
 