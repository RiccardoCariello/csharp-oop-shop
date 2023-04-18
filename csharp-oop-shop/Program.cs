
using csharp_oop_shop;

Prodotto myProdotto = new Prodotto("pinco" , "pallino", 120.5f);

Console.WriteLine("Cambia il nome :D");
myProdotto.Name = Console.ReadLine();

Console.WriteLine("Nome : " + myProdotto.Name);
Console.WriteLine("Descrizione : " + myProdotto.Description);
Console.WriteLine("Prezzo : " + myProdotto.Prezzo);
Console.WriteLine("Codice : " + myProdotto.Code);
Console.WriteLine("Codice Formattato : " + myProdotto.FormattedNum());
Console.WriteLine("Codice + Nome : " + myProdotto.CodeName());

Console.WriteLine("Il codice formattato è : " + myProdotto.FormattedNum());

Console.WriteLine("Il Prezzo Base è : " + myProdotto.PrezzoBase());
Console.WriteLine("Il Prezzo con Iva invece è : " + myProdotto.PrezzoIva());