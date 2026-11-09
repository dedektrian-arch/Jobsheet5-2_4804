﻿Console.Write("Masukkan nama pelanggan: ");
String namaPelanggan = Console.ReadLine();

Console.Write("Masukkan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subTotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subTotal + biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PENCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {subTotal}");
Console.WriteLine($"Biaya administrasi = {biayaAdministrasi}");
Console.WriteLine($"Total bayar = {totalBayar}");
