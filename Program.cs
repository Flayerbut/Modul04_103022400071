using Modul4_103022400071;

KodePaket kp  = new KodePaket();

Console.WriteLine("Masukkan nama paket (Basic, Standard, Premium, Unlimited, Gaming, Streaming, Family, Business, Student, Traveler): ");
string namaPaket = Console.ReadLine();

Console.WriteLine("Kode paket:" + kp.getKodePaket(namaPaket));
Console.ReadLine();