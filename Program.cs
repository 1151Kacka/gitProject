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

string userInput3 = Console.ReadLine();
for (int i = 0; i <= 5; i++)
Console.WriteLine(i + ". " + userInput3);

for (int i = 1; i <= 5; i++)
{
    string userInput5 = Console.ReadLine();
    for (int o = 1; o <= i; ++o)
    {
        Console.WriteLine(o + ". " + userInput5);
    }
}
Console.WriteLine("konec akce");

for (int i = 1; ;++i)
{
    string userInput4 = Console.ReadLine();
    for (int o = 1; o <= i; ++o)
    {
        Console.WriteLine(o + ". " + userInput4);
    }
}

//Načtěte od uživatele slovo a to zopakujte 5. (už jsme dělali)
//Načtěte od uživatele slovo a první zopakujte jednou, další slovo zopakujte dvakrát, další třikrát atd.
for (int i = 1; i <= 5; i++)
{
    string userInput5 = Console.ReadLine();
    for (int o = 1; o <= i; ++o)
    {
        Console.WriteLine(o + ". " + userInput5);
    }
}