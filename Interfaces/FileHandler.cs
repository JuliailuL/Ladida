using System;

namespace Interfaces;
/// <summary>
/// Ein Interdace ist ein Vertrag. Wer ein Interface implementiert muss alle Member (Eigenschaften und Methoden) des Interfaces implementieren.
/// Ein Interface ist eine Blaupause für eine Klasse / ein Struct, die beschreibt welche Methoden und Eigenschaften die Klasse / das Struct haben muss, aber nicht wie die Methoden / Eigenschaften sein müssen
/// </summary>
public interface FileHandler
{
    public string FilePath { get; set; }

//Konstruktor geht nicht, weil von einem Interface keine Instanz erstellt werden kann.
public void DeleteFile();

}
