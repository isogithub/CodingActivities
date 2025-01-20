

int sayi = 135989531;

PalindromikSayi1(sayi);

PalindromikSayi2(sayi);


Console.ReadLine();


static void PalindromikSayi1(int sayi)
{
	int toplam = 0;
	int i = 0;
	int temp = 0;
	int sayac = 0;

	int girilenSayi = sayi;

	for (i = girilenSayi; girilenSayi != 0; girilenSayi = girilenSayi / 10)
	{
		temp = girilenSayi % 10;
		toplam = toplam * 10 + temp;
		sayac++;
	}

	if (toplam == i)
	{
		Console.WriteLine("doğrudur");
		Console.WriteLine("PalindromikSayi1 Döngü sayısı : " + sayac);
	}
	else
	{
		Console.WriteLine("yanlış");
		Console.WriteLine("PalindromikSayi1 Döngü sayısı : " + sayac);
	}

}

static void PalindromikSayi2(int sayi)
{
	string girilenSayi = Convert.ToString(sayi);
	string sonuc = string.Empty;
	int sayac = 0;

	for (int i = 0; i < girilenSayi.Length / 2; i++)
	{
		if (girilenSayi[i] == girilenSayi[girilenSayi.Length - 1 - i])
		{
			sayac++;
		}
	}

	if (sayac == girilenSayi.Length / 2)
	{
		Console.WriteLine("Sonuç doğru");
		Console.WriteLine("PalindromikSayi2 Döngü sayısı : " + sayac);
	}
	else
	{
		Console.WriteLine("Sonuç Yanlış.");
		Console.WriteLine("PalindromikSayi2 Döngü sayısı : " + sayac);
	}
}