//1. ůkol
bool proceed = true;
string result = "";
while (proceed)
{
    string userInput2 = "Zadej něco ";
    string userInput1 = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userInput1))
    {
        Console.WriteLine("Nezadal jsi žádný znak.");
        proceed = false;
    }
    result += userInput1;
  
}
Console.WriteLine(result);

//2. úkol
string userInput3 = Console.ReadLine();
for (int i = 0; i <= 5; i++)
Console.WriteLine(i + ". " + userInput3);

//2.+3. úkol
for (int i = 1; i <= 5; i++)
{
    string userInput5 = Console.ReadLine();
    for (int o = 1; o <= i; o++)
    {
        Console.WriteLine(o + ". " + userInput5);
    }
}
Console.WriteLine("konec akce");
//3. úkol
bool preceed = true;
while (preceed)
{
    for (int i = 1; i <= i; i++)
    {
        string userInput6 = Console.ReadLine();
        for (int o = 1; o <= i; o++)
        {
            Console.WriteLine(o + ". " + userInput6);
        }
    }
    
}
