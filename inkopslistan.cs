List<string> names = new List<string>(); // En lista som kan bara innehålla text. Varornas namn
List<int> prices = new List<int>(); // En lista som kan bara innehålla heltal. prisetet på varorna

names.Add("Mjölk"); // la till mjölk i string listan 
prices.Add(15); // la till 15kr som pris
names.Add("Bröd");
prices.Add(32);
names.Add("Ost");
prices.Add(89);


while (true) // Denna while loopen upprepar allt inom den för alltid eftersom jag har satt (true) efter.
{
    int total = 0; // total börjar alltid på 0. Den står inuti while loopen så att den ska "restarta" efter varje varv.

    for (int i = 0; i < names.Count; i++)  // En for loop. Den går genom plats 0,1,2 osv så länge (i) är mindre än antalet varor.
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr"); // {i + 1}. gör att det står nummer före varan plus 1 för att det börjar alltid på 0. {names[i]} - gör att själva varan skrivs och sen - emmellan. {prices[i]} kr visar priset på varan baserat på var den är i listan.
        total = total + prices[i]; // lägger till priset på den nuvarande varan i total.
    }

    Console.WriteLine($"Totalt: {total} kr");  // Detta med hjälp av total = total + prices [i] visar det totala summan på alla varorna. 

    Console.Write("Skriv en vara: ");
    string input = Console.ReadLine(); // läser det användaren har matat in som en sträng och kallar det för input.

    if (int.TryParse(input, out int nummer)) // if sats med en tryparce som försöker omvandla texten till en int och kallar det för nummer.
    {
        int index = nummer - 1; // gör att inmatnigen blir minus ett för att i listor börjar den första alltid på 0. Alltså ist för 1,2,3 så är det 0,1,2.
        if (nummer >= 1 && nummer <= names.Count) // if sats som kolla ifall nummret större eller lika med 1 och ifall den är mindre än eller lika med  antalet varor på listan.
        {
            Console.WriteLine($"{names[index]} togs bort"); 
            names.RemoveAt(index);
            prices.RemoveAt(index);
            // tar bort namn och pris på önskad vara.
        } 
        else
        {
            Console.WriteLine($"Vara nummer {index + 1} finns inte i listan"); // annars säger systemet att det inte existerar en vara med det numret.
        }
    }
    else 
    {
        Console.Write("Pris: "); // ifall nytt namn blir inmatad så frågar systemet om pris.
        string prisText = Console.ReadLine(); 
        if (int.TryParse(prisText, out int pris)) // if sats. inehåller en tryparce som försöker att omvandlara användarens inmatning från sträng till en integer. 
        {
            names.Add(input);
            prices.Add(pris);
            // Lägger till inmatningen i respektive listor. 
            Console.WriteLine($"{input} kostar {pris}");
        }
        else // ifall användare inte skriver ett giltigt heltal.
        {
            Console.WriteLine("Priset måste vara ett heltal.");
        }

    }
}