using System;

public class Ogrenci
{
    private int ogrenciNo;
    private string isim;
    private string soyisim;
    private double vize1;
    private double vize2;
    private double final;
    private string okulIsmi;
    public Ogrenci(int ogrenciNo, string isim, string soyisim, double vize1, double vize2, double final, string okulIsmi)
    {
        this.ogrenciNo = ogrenciNo;
        this.isim = isim;
        this.soyisim = soyisim;
        this.vize1 = vize1;
        this.vize2 = vize2;
        this.final = final;
        this.okulIsmi = okulIsmi;
    }
    public void OgrenciBilgileriniGoster()
    {
        Console.WriteLine($"Öğrenci No: {ogrenciNo}");
        Console.WriteLine($"İsim: {isim}");
        Console.WriteLine($"Soyisim: {soyisim}");
        Console.WriteLine($"Okul: {okulIsmi}");
    }
    public double OgrenciOrtalamasiBul()
    {
        return (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
    }
    public string OkulGetir()
    {
        return okulIsmi;
    }
}
