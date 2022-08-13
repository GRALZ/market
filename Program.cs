int anakart = 584, islemci = 3828, ekrankarti = 40525, kasa = 680, b, ram= 145, c, s, toplam;
string a, d;

Console.WriteLine("ALTAY BİLGİSAYAR A.Ş");

Console.WriteLine("Üye girişi");

Console.Write("hesap girişi: ");
a = Convert.ToString(Console.ReadLine());
Console.WriteLine("şifre girişi: ");
b = Convert.ToInt16(Console.ReadLine());

if (a == "ibrahim@hotmail.com" || b == 1234)
{
    
    goto market ;
}
else if (a == "ibrahim@hotmail.com" || b == 1234)
{
 
    goto market;
}
else if (a == "ibrahim@hotmail.com" || b == 1234)
{
    goto market;
}
else {
     Console.ReadKey();
}

market:
Console.Clear();
Console.WriteLine(" 1.MSI B460M PRO Soket 1200 DDR4 2933 VGA DVI HDMI M.2 USB 3.2 MATX Anakart");
Console.WriteLine(" 2.Intel Core i3-10100F 3.6 GHz 4 Çekirdek 6MB Cache LGA1200 Soket 14nm İşlemci ");
Console.WriteLine(" 3.Inno3D GTX1650 Twin x2 OC 4GB 128Bit GDDR5 DX(12) PCI-E 3.0 Ekran Kartı");
Console.WriteLine(" 4.Gameforce Cold 4X120MM Rainbow Fanlı Oyuncu Kasası 4X120MM - 600W 80 Plus");
Console.WriteLine(" 5.G.Skill 8GB Ripjaws V 3600mhz CL18 DDR4 Ram (F4-3600C18S-8GVK)");
Console.WriteLine("İstediğiniz ürünün sayısını giriniz:");
c= Convert.ToInt16(Console.ReadLine());
if (c == 1)
{
    Console.Write("Kac adet alacaksınız:");
    s = Convert.ToInt16(Console.ReadLine());
    toplam = s * anakart;
    Console.Write(toplam);
       
}
else if(c == 2)
{
    Console.Write("Kac adet alacaksınız:");
    s = Convert.ToInt16(Console.ReadLine());
    toplam = s * islemci;
    Console.Write(toplam);

}
else if (c == 3)
{
    Console.Write("Kac adet alacaksınız: ");
    s = Convert.ToInt16(Console.ReadLine());
    toplam = s * ekrankarti;
    Console.Write(toplam);

}
else if (c == 4)
{
    Console.Write("Kac adet alacaksınız: " );
    s = Convert.ToInt16(Console.ReadLine());
    toplam = s * kasa;
    Console.Write(toplam );

}
else if (c == 5)
{
    Console.Write("Kac adet alacaksınız: ");
    s = Convert.ToInt16(Console.ReadLine());
    toplam = s * ram;
    Console.Write(toplam );

}
else
{
    Console.Write("yanlış tuşladınız ");
}
Console.WriteLine("Alışverişe devam edecek misiniz ? evet = E hayır = H :");
d = Convert.ToString(Console.ReadLine());
if (d=="E" || d=="e")
{
    Console.WriteLine("teşekürler siparisiniz alınmıştır.");
    goto market;

}
else
{
    goto kargo;
}
kargo:
Console.WriteLine("Kargo ister misinizevet = E hayır = H :");
string k=Convert.ToString(Console.ReadLine());
if (d == "E" || d == "e")
{
    toplam = toplam + 32;

}
else
{
    return;
}
Console.WriteLine("Uygulamaya devam edecek misiniz:");
if (d == "E" || d == "e")
{
    goto market; 

}
else
{
    return;
}

Console.ReadKey();