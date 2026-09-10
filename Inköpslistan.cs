List<string> names = new List<string>(); // En lista som kan bara innehålla text. Varornas namn
List<int> prices = new List<int>(); // En lista som kan bara innehålla heltal. prisetet på varorna

names.Add("Mjölk"); // la till mjölk i string listan 
prices.Add(15); // la till 15kr som pris
names.Add("Bröd");
prices.Add(32);
names.Add("Ost");
prices.Add(89);

int total = 0; // total börjar alltid på 0;

for (int i = 0; i < names.Count; i++)  // En for loop. Den går genom plats 0,1,2 osv så länge (i) är mindre än antalet varor.

{
    Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr"); // {i + 1}. gör att det står nummer före varan. plus 1 för att det börjar alltid på 0. {names[i]} - gör att själva varan skrivs och sen - emmellan. {prices[i]} kr visar priset på varan baserat på var den är i listan.
    total = total + prices[i]; // lägger till priset på den nuvarande varan i total.
}

Console.WriteLine($"Totalt: {total} kr");  // Detta med hjälp av total = total + prices [i] visar det totala summan på alla varorna. 
