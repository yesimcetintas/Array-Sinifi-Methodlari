// See https://aka.ms/new-console-template for more information

// Sort

int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

Console.WriteLine("******Sırasız Dizi*****");

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("******Sıralı Dizi*****");

Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//Clear
Console.WriteLine("******Clear*****");
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//Reverse
Console.WriteLine("******Reverse*****");

Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//IndexOf
Console.WriteLine("******IndexOf*****");

Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//Resize
Console.WriteLine("******ReSize*****");

Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=99;
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}