using System;

namespace Interfaces;

// Um das Austauschen der Logger in Zukunft angenehmer zu gestalten, designen wir eine Abstrakte Klasse, von der alle Logger erben
public abstract class BaseLogger // Eine abstrakte Klasse kann man nicht instanziieren
{
    public abstract void Log(string message);
}
public class ConsoleLogger : BaseLogger
{

    public override void Log(string message)
    {
        Console.WriteLine(message);
    }

}

public class FileLogger : BaseLogger
{
    // Das hier ist ein konkretes Besispiel für das Designpattern "Dependency-Injection"
    //Mit DI lassen sich Abhängigkeiten aus einer Klasse heraus extrahieren und auf den Caller / Nutzer der Klasse übertragen.
    public override void Log(string message)
    {
    File.AppendAllText("./log.txt", $"{DateTime.Now}: {message}\n");
    }
}


public class JsonLogger : BaseLogger
{
    public override void Log(string message)
    {
    File.AppendAllText("./log.json", $"{DateTime.Now}: {message}\n");
    }
}
