Console.Write("Enter name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
   Console.WriteLine("Hello, Masha!"); 
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

