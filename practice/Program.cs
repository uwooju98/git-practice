using System;

decimal haveGold;
decimal priceJewlry;
int buyjewlry;

Console.Write("보유 골드: ");
haveGold = decimal.Parse(Console.ReadLine());
Console.Write("보석의 개당 가격: ");
priceJewlry = decimal.Parse(Console.ReadLine());
Console.Write("구매하고 싶은 보석 개수: ");
buyjewlry = int.Parse(Console.ReadLine());


int maximumQuantity = (int)(haveGold / priceJewlry);
int realQuantity = Math.Min(maximumQuantity, buyjewlry);

decimal usingGold = priceJewlry * realQuantity;
decimal remainGold = haveGold - usingGold;


Console.WriteLine($"구매 가능한 최대 개수: {maximumQuantity}");
Console.WriteLine($"실제 구매 개수: {realQuantity}");
Console.WriteLine($"사용한 골드: {usingGold}");
Console.WriteLine($"남은 골드: {remainGold}");

