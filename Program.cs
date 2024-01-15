namespace ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç Sayısını Giriniz: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Bitiş Sayısını Giriniz: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Kaç Adet Sayı Oluşturulsun: ");
            int adet = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            HashSet<int> tekkullanim = new HashSet<int>();

            int control = 0;

            while (control < adet)
            {
                int rasgeleSayi = rnd.Next(start, end + 1);

                tekkullanim.Add(rasgeleSayi);

                control++;
            }

            int[] rasgeleSayilar = tekkullanim.ToArray();


            for (int i = 0; i < rasgeleSayilar.Length; i++)
            {
                Console.WriteLine(rasgeleSayilar[i]);
            }



        }
    }
}
    
