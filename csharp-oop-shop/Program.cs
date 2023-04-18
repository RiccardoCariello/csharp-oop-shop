
using csharp_oop_shop;

Prodotto myProdotto = new Prodotto("pinco" , "pallino", 120.5f);


Console.WriteLine(myProdotto.Name);
Console.WriteLine(myProdotto.Description);
Console.WriteLine(myProdotto.Prezzo);
Console.WriteLine(myProdotto.Code);
Console.WriteLine(myProdotto.FormattedNum());
Console.WriteLine(myProdotto.CodeName());

Console.WriteLine("Il codice formattato è : " + myProdotto.FormattedNum());

