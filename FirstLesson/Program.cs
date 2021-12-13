
Console.WriteLine("1 = register");
Console.WriteLine("reqem daxil et :");


int reqem = int.Parse(Console.ReadLine());


if (reqem == 1)
{
    Console.WriteLine("adiniz nedir ?:");
    string ad = Console.ReadLine();
    Console.WriteLine("yasiniz necedir?"); 
    int yas = int.Parse(Console.ReadLine());
    if (yas < 18) 
    {
        Console.WriteLine( ad+" necesen ay "+ ad + " sene qurban olaram ay " + ad);

    }
    else
    {
        Console.WriteLine("register tamamlandi");
    }

}
if(reqem == 2)
{
    Console.WriteLine("hesabinizin adi nedir");
    string nick = Console.ReadLine();
    Console.WriteLine("passwordunuz nedir");    
    int pass = int.Parse(Console.ReadLine());
        string[] nickler = { "rivai", "ahma"};
        for(int i = 0; i < nickler.Length; i++)
    {
        if (nick == nickler[i])
        {
            Console.WriteLine("giris olundu");
        }
        else
        {
            Console.WriteLine("SEHVDI");
        }
    }

}