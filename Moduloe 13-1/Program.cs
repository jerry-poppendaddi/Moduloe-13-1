using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:/Users/iveal/Downloads/Text1.txt";

        // Читаем весь текст
        string[] words = File.ReadAllText(filePath).Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Создаем List<T> и LinkedList<T> для слов
        List<string> list = new List<string>(words);
        LinkedList<string> linkedList = new LinkedList<string>(words);

        // Таймер для List<T>
        Stopwatch listStopwatch = Stopwatch.StartNew();
        ProcessWords(list);
        listStopwatch.Stop();

        // Таймер для LinkedList<T>
        Stopwatch linkedListStopwatch = Stopwatch.StartNew();
        ProcessWords(linkedList);
        linkedListStopwatch.Stop();

        // Результат
        Console.WriteLine("List<T> processing time: " + listStopwatch.Elapsed);
        Console.WriteLine("LinkedList<T> processing time: " + linkedListStopwatch.Elapsed);
    }

    static void ProcessWords(IEnumerable<string> words)
    {
        // Выполняем простую операцию для подсчета времени
        foreach (var word in words)
        {
           int length = word.Length;
        }
    }
}