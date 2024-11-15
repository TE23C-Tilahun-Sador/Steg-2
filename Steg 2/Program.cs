// for (int i = 0; i < names.Count; i++)
// {
//     Console.WriteLine(names[i]);
// }
// Console.ReadLine();

// List<string> names = ["leksaksbil", "leksaksflygplan", "lego", "gosedjur", "beyblades" ];

// List<string> klasskamrater = ["Zulfiqar", "Brian", "Mostafa", "Haroon", "John"];

// List<int> siffror = [1,2,3,4,5];

// for (int i = 0; i < klasskamrater.Count; i++)
// {
//     Console.WriteLine($"{klasskamrater[i]} ger {names[i]} betyget {siffror[i]}");
//     Console.ReadLine();
// }

using System.Xml.Schema;

List<string> cities = [];

Console.WriteLine("Klicka på enter för att starta");
Console.ReadLine();

while(1 == 1)
{
    Console.Clear();
  

    Console.WriteLine("Skriv *exit* för att avsluta. För att fortsätta klicka på <Enter>.");
    string avsluta = Console.ReadLine(); ;

    if(avsluta == "exit")
    {
        Environment.Exit(0);
    }
    
    Console.Clear();
    
    Console.WriteLine("Skriv en stad: ");
    string stad = Console.ReadLine();
    cities.Add(stad);

    

    Console.WriteLine("");
    Console.WriteLine("Dina städer: ");
    for (int i = 0; i < cities.Count; i++)
    {
        Console.WriteLine(cities[i]);
    }
    Console.ReadLine();
    
}