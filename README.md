# Sistem E-Katalog Pengadaan Barang Pemerintah

Sistem informasi katalog elektronik untuk manajemen dan pengadaan barang pemerintahan.

## Deskripsi

Aplikasi berbasis console yang menyediakan fitur manajemen katalog produk pengadaan barang pemerintah. Sistem ini mengimplementasikan struktur data array satu dimensi dan multi-dimensi untuk penyimpanan dan pengolahan data produk.

## Fitur Utama

1. **Tampilkan Semua Produk** - Menampilkan daftar lengkap produk dengan informasi detail meliputi nama, kategori, harga, stok, dan vendor
2. **Statistik Transaksi Per Kategori** - Menyajikan laporan transaksi berdasarkan kategori produk dengan total nilai transaksi
3. **Urutkan Produk Berdasarkan Harga** - Mengurutkan produk secara ascending berdasarkan harga menggunakan algoritma Bubble Sort
4. **Urutkan Produk Berdasarkan Nama** - Mengurutkan produk secara alfabetis menggunakan algoritma Selection Sort
5. **Cari Produk Berdasarkan Kategori** - Fitur pencarian produk dengan filter kategori
6. **Hitung Total Nilai Inventory** - Menghitung total nilai inventory dengan statistik lengkap

## Kategori Produk

Sistem mengelola lima kategori produk utama:

- Alat Tulis Kantor
- Komputer & Aksesoris
- Furniture
- Kendaraan
- Peralatan Medis

## Persyaratan Sistem

- .NET SDK 9.0 atau lebih tinggi
- Windows, Linux, atau macOS
- Terminal/Command Prompt

## Instalasi

1. Clone repository ini:
```bash
git clone https://github.com/username/unsia-e-government.git
cd unsia-e-government
```

2. Build project:
```bash
dotnet build
```

## Cara Menjalankan

Jalankan aplikasi menggunakan command:

```bash
dotnet run
```

Atau jalankan file executable yang telah di-build:

```bash
dotnet bin/Debug/net9.0/unsia-e-government.dll
```

## Struktur Data

### One Dimensional Array

- `kategoriProduk[]` - Array untuk menyimpan nama kategori produk
- `totalTransaksi[]` - Array untuk menyimpan total transaksi per kategori

### Multi Dimensional Array

- `dataProduk[,]` - Array 2D untuk menyimpan data produk lengkap dengan struktur:
  - Kolom 0: Nama Produk
  - Kolom 1: Kategori
  - Kolom 2: Harga
  - Kolom 3: Stok
  - Kolom 4: Vendor

## Algoritma yang Diimplementasikan

### Bubble Sort
Digunakan untuk mengurutkan produk berdasarkan harga dengan kompleksitas waktu O(n²).

### Selection Sort
Digunakan untuk mengurutkan produk berdasarkan nama secara alfabetis dengan kompleksitas waktu O(n²).

### Linear Search
Digunakan untuk mencari dan memfilter produk berdasarkan kategori dengan kompleksitas waktu O(n).

## Penggunaan

Setelah aplikasi berjalan, ikuti petunjuk menu yang tersedia:

1. Pilih menu dengan memasukkan nomor 1-7
2. Untuk fitur pencarian berdasarkan kategori, masukkan nomor kategori yang diinginkan
3. Tekan tombol apa saja untuk kembali ke menu utama
4. Pilih menu 7 untuk keluar dari aplikasi

## Contoh Output

### Menu Utama
```
╔═══════════════════════════════════════════════════════════════════╗
║         SISTEM E-KATALOG PENGADAAN BARANG PEMERINTAH              ║
║                    UNIVERSITAS SIBER ASIA                         ║
╚═══════════════════════════════════════════════════════════════════╝

┌─────────────────────────────────────────────────────────────────┐
│                         MENU UTAMA                              │
├─────────────────────────────────────────────────────────────────┤
│ 1. Tampilkan Semua Produk                                       │
│ 2. Statistik Transaksi Per Kategori                             │
│ 3. Urutkan Produk Berdasarkan Harga                             │
│ 4. Urutkan Produk Berdasarkan Nama                              │
│ 5. Cari Produk Berdasarkan Kategori                             │
│ 6. Hitung Total Nilai Inventory                                 │
│ 7. Keluar                                                       │
└─────────────────────────────────────────────────────────────────┘
```

## Teknologi

- **Bahasa Pemrograman**: C# 12.0
- **Framework**: .NET 9.0
- **Target Platform**: Cross-platform (Windows, Linux, macOS)
- **Namespace**: UnsiaEGovernment

## Struktur Project

```
unsia-e-government/
│
├── Program.cs                      # File utama aplikasi
├── unsia-e-government.csproj      # File konfigurasi project
├── unsia-e-government.sln         # Solution file
├── README.md                       # Dokumentasi
├── LICENSE.txt                     # Lisensi
│
├── bin/                           # Output build
│   └── Debug/
│       └── net9.0/
│
└── obj/                           # File temporary build
    └── Debug/
        └── net9.0/
```

## Lisensi

Lihat file [LICENSE.txt](LICENSE.txt) untuk informasi lisensi.
