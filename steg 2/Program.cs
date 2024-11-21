
string[] leksaker= ["Barbie", "Lego", "Slime", "Nerf", "yo-yo"];
int[] goobieWoobies= [1, 3, 5, 7, 9];
string[] names= ["Dac", "Wing", "Brian", "Zen", "Sador"];
Console.WriteLine("Everyones ratings of different toys:");
Console.ReadLine();
for (int i = 0; i < 5; i++ )
{
  int r = Random.Shared.Next(4);
  Console.WriteLine($"{names[i]} ger {leksaker[i]} betyget {goobieWoobies[r]}");
}
Console.ReadLine();