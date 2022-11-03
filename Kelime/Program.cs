Console.WriteLine("kelime gir: ");
string kelime=Console.ReadLine();

// foreach (char eleman in kelime)
// {
//     Console.WriteLine(eleman);
// }

for (int i = 0; i < kelime.Length; i++)
{
    Console.Write(Convert.ToChar(Convert.ToInt32(kelime[i])-32));
}
Console.WriteLine("\n"+kelime.ToUpper());