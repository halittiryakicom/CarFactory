using CarFactory;

//liste tnaımlaması yaptık.
List<Factory> cars = new List<Factory>();

while(true)
{
    //kullanıcıya tercihini sorudk
    Console.WriteLine("Araba üretimine devam etmek istiyor musun? (e/h)");
    string choice = Console.ReadLine();
    if (choice.ToLower() == "h")
    {
        //kullanıcının girdiği arabaları listeden çekip ekrana yazdırdık
        Console.WriteLine("Arabaların listesi");
        foreach(Factory factory in cars)
        {
            Console.WriteLine($"Seri Numarası: {factory.SerialNo}, Markası: {factory.Brand}");
        }
        Console.WriteLine("İyi günler dileriz");
        break;
    }
    else if (choice.ToLower() == "e")
    {
        //arabanın bilgilerini aldık.
        Console.WriteLine("Yeni araba üretimi başlıyor..........");
        Console.WriteLine("Lütfen Seri Numarası giriniz: ");
        string seriNo = Console.ReadLine();

        Console.WriteLine("Arabanın markasını giriniz: ");
        string brand = Console.ReadLine();

        Console.WriteLine("Arabanın modelini giriniz: ");
        string model = Console.ReadLine();

        Console.WriteLine("Arabanın rengini giriniz: ");
        string color = Console.ReadLine();

        door: 
        try
        {
            //arabanın kapı sayısında ki hata durumunu kontrol ettik.
            Console.WriteLine("Lütfen arabanın kapı sayısını giriniz: ");
            int doorCount = Convert.ToInt32(Console.ReadLine());
            Factory car = new Factory(seriNo, brand, model, color, doorCount);
            cars.Add(car);

        }
        catch (FormatException ex) 
        {
            Console.WriteLine("Lütfen sadece sayısal bir değer giriniz.");
            goto door;
        }
    }
    else
    {
        Console.WriteLine("Lütfen sadece e yada h harfi olarak giriş yapınız. Devam etmek istiyorsanız e harfini, istemiyorsanız h harfini giriniz.");
    }
}