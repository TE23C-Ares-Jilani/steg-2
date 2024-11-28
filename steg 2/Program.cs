
// string[] leksaker= ["Barbie", "Lego", "Slime", "Nerf", "yo-yo"];
// int[] goobieWoobies= [1, 3, 5, 7, 9];
// string[] names= ["Dac", "Wing", "Brian", "Zen", "Sador"];
// Console.WriteLine("Everyones ratings of different toys:");
// Console.ReadLine();
// for (int i = 0; i < 5; i++ )
// {
//   int r = Random.Shared.Next(4);
//   Console.WriteLine($"{names[i]} ger {leksaker[i]} betyget {goobieWoobies[r]}");
// }
// Console.ReadLine();

// List<string> cities = [];
// string city = "";

// while (city != "exit")
// {
//   Console.Clear();
//   Console.WriteLine("Type exit at anytime to see the list and quit.");
//   Console.WriteLine("write the name of a city:");
//   city = Console.ReadLine();
//   if (city == "exit")
//   {

//   }
//   else
//   {
//   Console.Clear();
//   cities.Add(city);
//   int i = -1;
//   Console.WriteLine("List of cities:");
//   foreach (string citys in cities)
//   {
//     i++;
//     Console.WriteLine(cities[i]);
//   }
//   Console.WriteLine("Click any button to continue.");
//   Console.ReadKey();
//   }
// }

List<string> cities = [];
string city = "";

while (city != "exit")
{
  Console.Clear();
  Console.WriteLine("Type exit at anytime to see the list and quit.");
  Console.WriteLine("write the name of a city:");
  city = Console.ReadLine();
  if (city == "exit")
  {

  }
  else
  {
    Console.Clear();
    cities.Add(city);
  }
}
int i = -1;
Console.WriteLine("List of cities:");
Console.WriteLine("Click any button to continue.");
foreach (string citys in cities)
{
  i++;
  Console.WriteLine(cities[i]);
}

Console.ReadKey();
