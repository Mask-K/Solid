using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IItemPrice
{
    void SetPrice(double price);
}

interface IItemDiscount
{
    void ApplyDiscount(String discount);
}
interface IItemPromocode
{
    void ApplyPromocode(String promocode);
}

interface IItemSetColor
{
    void SetColor(byte color);
}
interface IItemSize
{
    void SetSize(byte size);
}

class Book : IItemPrice, IItemDiscount
{
    double Price { get; set; }
    string Discount { get; set; }
    public void SetPrice(double price)
    {
        Price = price;
    }
    public void ApplyDiscount(String discount)
    {
        Discount = discount;
    }
}

class Surcoat : IItemSetColor, IItemSize, IItemPrice, IItemDiscount
{
    private double Price;
    private byte Color;
    private byte Size;
    private string Discount;
    public void SetPrice(double price)
    {
        Price = price;
    }
    public void ApplyDiscount(String discount)
    {
        Discount = discount;
    }
    public void SetColor(byte color)
    {
        Color = color;
    }
    public void SetSize(byte size)
    {
        Size = size;
    }

}


class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}