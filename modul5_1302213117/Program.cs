internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan angka = new Penjumlahan();
        //nim 1302213117
        Console.WriteLine(angka.JumlahTigaAngka<int>(13, 02, 21));
    }
}

public class Penjumlahan 
{
    public T JumlahTigaAngka<T>(T input1,T input2,T input3)
    {
        dynamic angka1 = input1;
        dynamic angka2 = input2;
        dynamic angka3 = input3;
        return angka1 + angka2 + angka3;
    }
}

