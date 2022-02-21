namespace telefon_rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string [10];
            string[] Numbers = new string [10];
            while(true)
            {
                Console.Write(" (1) Yeni Numara Kaydetmek \n (2) Rehberde Arama Yapmak \n (3) Varolan Numarayı Güncelleme \n (4) Rehberi Listelemek \n (5) Varolan Numarayı Silmek \n Seçiminiz (1-5) = ");
                string chose = Console.ReadLine();
                if (chose == "1")
                {
                    Console.Clear();
                    Console.WriteLine("** Kayıt Ekranı **");
                    Console.WriteLine("------------------");
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(i+1 +". Kişinin Adı-Soyadı = ");
                        Names[i+1] = Console.ReadLine();
                        Console.Write(i+1 +". Kişinin Telefon Numarası = ");
                        Numbers[i+1] = Console.ReadLine();
                    }                   
                }
                if (chose == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("** Arama Ekranı **");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                        Console.Write(" İsim soyisim'e göre arama yapmak için: (1)\n Telefon numarasına göre arama yapmak için: (2) \n Seçiminiz = ");
                        string callChose = Console.ReadLine();
                        if (callChose == "1")
                        {
                            Console.Write("İsim soyisim giriniz : ");
                            string callName = Console.ReadLine();
                            int result = Array.IndexOf(Names , callName);
                            if(result > 0)
                            {
                                Console.WriteLine("Aradığınız Kişinin Telefonu " + Numbers[result]);
                            }
                            else Console.WriteLine("Aranan kişi bulunamadı! \n");
                            Console.Write("Aramaya devam edilsin mi ? (y/n)");
                            string continueChose = Console.ReadLine().ToUpper();
                            if (continueChose == "n") break;
                        }
                        if (callChose == "2")
                        {
                            Console.Write("Telefon numarası giriniz : ");
                            string callNumber = Console.ReadLine();
                            int result = Array.IndexOf(Numbers , callNumber);
                            if(result > 0)
                            {
                                Console.WriteLine($"Aradığınız Kişinin Adı Soyadı {Names[result]}");
                            }
                            else Console.WriteLine("Aranan kişi bulunamadı! \n");
                            Console.Write("Aramaya devam edilsin mi ? (y/n)");
                            string continueChose = Console.ReadLine().ToUpper();
                            if (continueChose == "n") break;
                        }
                    }
                if (chose == "3")
                {
                    Console.Write("Güncellemek için isim ve soyad giriniz = ");
                    string updateName = Console.ReadLine();
                    int result = Array.IndexOf(Names , updateName);
                    Console.Write("Yeni isim giriniz = ");
                    Names[result] = Console.ReadLine();
                    Console.Write("Aramaya devam edilsin mi ? (y/n)");
                    string continueChose = Console.ReadLine().ToUpper();
                    if (continueChose == "n") break;
                }
                if (chose == "4")
                {
                    for (int i = 1; i < Names.Length; i++)
                    {
                        if (Names[i] != null)
                        {
                        Console.WriteLine($"İsim Soyisim = {Names[i]} " );
                        }
                    }
                    Console.Write("Aramaya devam edilsin mi ? (y/n)");
                    string continueChose = Console.ReadLine().ToUpper();
                    if (continueChose == "n") break;
                }
                if (chose == "5")
                {
                    Console.Write("Silmek istediğiniz isim ve soyismi giriniz = " );
                    string deleteName = Console.ReadLine();
                    int result = Array.IndexOf(Names , deleteName);
                    Names[result] = null;
                    Numbers[result] = null; 
                }
            }
        }
    }
}