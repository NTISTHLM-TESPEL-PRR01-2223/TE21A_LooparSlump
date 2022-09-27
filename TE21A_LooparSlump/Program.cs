
Random generator = new Random();

while (true)
{
  int result = generator.Next(5, 15);
  Console.WriteLine(result);

  // if (result == 0)
  // {
  //   Console.WriteLine("Du får en banan");
  // }
  // if (result == 1)
  // {
  //   Console.WriteLine("Du får en annan banan");
  // }
  Console.ReadLine();
}

// int hp = 5;

// while (hp > 0)
// {
//   Console.WriteLine("Still alive!");
//   Console.WriteLine(hp);
//   // hp--;
// }
Console.ReadLine();
