using System;


decimal haveGold;
decimal secondGold;
decimal priceJewlry;
int buyJewlry;


Console.Write("보석의 개당 가격:");
priceJewlry = decimal.Parse(Console.ReadLine());
Console.Write("구매하고 싶은 보석 개수:");
buyJewlry = int.Parse(Console.ReadLine());
Console.Write("첫 번째 충전 골드:");
haveGold = decimal.Parse(Console.ReadLine());
Console.Write("두 번째 충전 골드:");
secondGold = decimal.Parse(Console.ReadLine());


int firstQuantity = (int)Math.Min(haveGold/priceJewlry,buyJewlry); //첫 구매 최대 수량

Console.WriteLine($"첫 번째 구매 개수: {firstQuantity}");


haveGold = haveGold - (priceJewlry * firstQuantity); // 첫 구매후 잔액
Console.WriteLine($"첫 번째 구매 후 잔액: {haveGold}");
buyJewlry = buyJewlry - firstQuantity; // 첫 구매후 사고싶은 남은 수량


haveGold = haveGold + secondGold; // 두 번째 골드 충전


int secondQuantity = (int)Math.Min(haveGold/priceJewlry,buyJewlry);//(최대개수/사고싶은양)
Console.WriteLine($"두 번째 구매 개수: {secondQuantity}");


int totalQuantity = firstQuantity + secondQuantity;
Console.WriteLine($"총 구매 개수: {totalQuantity}");

haveGold = haveGold - priceJewlry * secondQuantity;
Console.WriteLine($"최종 잔액: {haveGold}");
IAsyncDisposable