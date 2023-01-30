using System;

class Program
{
    static void Main()
    {
        Phone Xiaomi = new Phone(89002357565, "POCO F3", 7.1f);
        
        Phone Samsung = new Phone(89605843489, "Galaxy S10", 7.5f);

        Phone Iphone = new Phone(89205846947, "11 Pro Max", 6.8f);

        Xiaomi.techHar();
        Console.WriteLine("");
        Samsung.techHar();
        Console.WriteLine("");
        Iphone.techHar();
    }
    
}
public class Phone
{
    public long Number;
    public string Model;
    public float Weight;

    public Phone(long number, string model, float weight)
    {
        Number = number;
        Model = model;
        Weight = weight;
    }

    public Phone(long number,string model)
    {
        Number = number;
        Model = model;     
    }

    public Phone()
    {

    }

    public void receiveCall(string callName)
    {
        Console.WriteLine($"Звонит {callName}");
    }
    public long getNumber(long phoneNumber)
    {
        return phoneNumber;
    }
    public void techHar()
    {
        Console.WriteLine($"Номер вашего телефона: {Number}\n Модель вашего телефона: {Model}\n " +
                            $"Диагональ вашего телефона: {Weight}");
    }

    p
}