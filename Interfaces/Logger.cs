using System;
namespace Interfaces;

// Um das Austauschen der Logger in Zukunft angenehmer zu gestalten, designen wir eine Abstrakte Klasse, von der alle Logger erben

public interface BaseLogger 
{
    public void Log(string message);
}
public class ConsoleLogger : BaseLogger
{

    public void Log(string message)
    {
        Console.WriteLine(message);
    }

}
// FileHandler muss ein Interface sein, weil man nur von einer Klasse erben kann.
public class FileLogger : BaseLogger, FileHandler
{
    public string FilePath {get;set;}

    public FileLogger(string filePath)
    {
        FilePath = filePath;
    }
    
    // Das hier ist ein konkretes Besispiel für das Designpattern "Dependency-Injection"
    //Mit DI lassen sich Abhängigkeiten aus einer Klasse heraus extrahieren und auf den Caller / Nutzer der Klasse übertragen.
    public void Log(string message)
    {
    File.AppendAllText("./log.txt", $"{DateTime.Now}: {message}\n");
    }
    public void DeleteFile()
    {
        File.Delete(FilePath);
    }
}


public class JsonLogger : BaseLogger
{
    public void Log(string message)
    {
    File.AppendAllText("./log.json", $"{DateTime.Now}: {message}\n");
    }
}
