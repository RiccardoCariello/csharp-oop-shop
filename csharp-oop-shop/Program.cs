
using csharp_oop_shop;

Prodotto myProdotto = new Prodotto("pinco" , "pallino", 120.5f, 10);

Console.WriteLine("Cambia il nome :D");
myProdotto.Name = Console.ReadLine();

Console.WriteLine("Nome : " + myProdotto.Name);
Console.WriteLine("Descrizione : " + myProdotto.Description);
Console.WriteLine("Prezzo : " + myProdotto.Price);
Console.WriteLine("Codice : " + myProdotto.Code);
Console.WriteLine("Codice Formattato : " + myProdotto.FormattedNum());
Console.WriteLine("Codice Formattato PadLeft: " + myProdotto.getFormattedCodePadLeft8());
Console.WriteLine("Codice + Nome : " + myProdotto.CodeName());

Console.WriteLine("Il Prezzo Base è : " + myProdotto.GetPrezzoBase());
Console.WriteLine("Il Prezzo con Iva invece è : " + myProdotto.GetPrezzoIva());