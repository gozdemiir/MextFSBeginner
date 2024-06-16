using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MextFSBeginner.Domain.Entities;


public class HesapMakinesi
{
    public int Topla(int sayi1, int sayi2)
    {
        var sonuc = sayi1 + sayi2;
        KonsolaYazdir(sonuc);
        return sonuc;
    }

    public int Cikar(int sayi1, int sayi2)
    {
        var sonuc = sayi1 - sayi2;
        KonsolaYazdir(sonuc);
        return sonuc;
    }

    public int Carp(int sayi1, int sayi2)
    {
        var sonuc = sayi1 * sayi2;
        KonsolaYazdir(sonuc);
        return sonuc;
    }

    public int Bol(int sayi1, int sayi2)
    {
        var sonuc = sayi1 / sayi2;
        KonsolaYazdir(sonuc);
        return sonuc;
    }

    private void KonsolaYazdir(int sonuc)
    {
        Console.WriteLine($"Piyango size çıktı: {sonuc} <3 süpersin");
    }

    public object Carp(int v1, int v2, bool v3)
    {
        throw new NotImplementedException();
    }
}







