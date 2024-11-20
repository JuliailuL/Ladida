using System;

namespace Interfaces;

public interface FileHandler
{
    public string FilePath { get; set; }

//Konstruktor geht nicht, weil von einem Interface keine Instanz erstellt werden kann.
public void DeleteFile();

}
