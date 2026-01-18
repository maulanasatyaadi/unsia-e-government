using System;

namespace UnsiaEGovernment
{
    class EKatalogPemerintah
    {
        // ==================== ONE DIMENSIONAL ARRAY ====================
        // Array untuk menyimpan nama kategori produk
        static readonly string[] kategoriProduk = ["Alat Tulis Kantor", "Komputer & Aksesoris", "Furniture", "Kendaraan", "Peralatan Medis"];

        // Array untuk menyimpan total transaksi per kategori
        static readonly double[] totalTransaksi = [15000000, 45000000, 30000000, 120000000, 85000000];

        // ==================== MULTI DIMENSIONAL ARRAY ====================
        // Array 2D untuk menyimpan data produk [index, 0=Nama, 1=Kategori, 2=Harga, 3=Stok, 4=Vendor]
        static readonly string[,] dataProduk = {
            { "Laptop Dell Latitude", "Komputer & Aksesoris", "12500000", "25", "PT Teknologi Nusantara" },
            { "Meja Kerja Kayu Jati", "Furniture", "3500000", "15", "CV Furniture Indonesia" },
            { "Printer HP LaserJet", "Komputer & Aksesoris", "4200000", "30", "PT Teknologi Nusantara" },
            { "Kursi Kantor Ergonomis", "Furniture", "2100000", "40", "CV Furniture Indonesia" },
            { "Kertas A4 80gsm", "Alat Tulis Kantor", "45000", "500", "PT Sumber Rejeki" },
            { "Pulpen Joyko", "Alat Tulis Kantor", "2500", "1000", "PT Sumber Rejeki" },
            { "Monitor LED 24 inch", "Komputer & Aksesoris", "2800000", "20", "PT Teknologi Nusantara" },
            { "Lemari Arsip Besi", "Furniture", "5500000", "10", "CV Furniture Indonesia" },
            { "Stapler Heavy Duty", "Alat Tulis Kantor", "85000", "100", "PT Sumber Rejeki" },
            { "Mouse Wireless Logitech", "Komputer & Aksesoris", "350000", "80", "PT Teknologi Nusantara" }
        };

        // ==================== MAIN PROGRAM ====================
        static void Main(string[] args)
        {
            bool running = true;

            TampilkanHeader();

            while (running)
            {
                TampilkanMenu();
                Console.Write("\nPilih menu (1-7): ");
                string pilihan = Console.ReadLine() ?? "";
                Console.Clear();

                switch (pilihan)
                {
                    case "1":
                        TampilkanSemuaProduk();
                        break;
                    case "2":
                        TampilkanStatistikKategori();
                        break;
                    case "3":
                        UrutkanProdukBerdasarkanHarga();
                        break;
                    case "4":
                        UrutkanProdukBerdasarkanNama();
                        break;
                    case "5":
                        CariProdukBerdasarkanKategori();
                        break;
                    case "6":
                        HitungTotalNilaiInventory();
                        break;
                    case "7":
                        running = false;
                        TampilkanPenutup();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nTekan tombol apa saja untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        // ==================== PROCEDURE (VOID METHODS) ====================

        /// <summary>
        /// Procedure untuk menampilkan header aplikasi
        /// </summary>
        static void TampilkanHeader()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║         SISTEM E-KATALOG PENGADAAN BARANG PEMERINTAH              ║");
            Console.WriteLine("║                    UNIVERSITAS SIBER ASIA                         ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
        }

        /// <summary>
        /// Procedure untuk menampilkan menu utama
        /// </summary>
        static void TampilkanMenu()
        {
            Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                         MENU UTAMA                              │");
            Console.WriteLine("├─────────────────────────────────────────────────────────────────┤");
            Console.WriteLine("│ 1. Tampilkan Semua Produk                                       │");
            Console.WriteLine("│ 2. Statistik Transaksi Per Kategori                             │");
            Console.WriteLine("│ 3. Urutkan Produk Berdasarkan Harga                             │");
            Console.WriteLine("│ 4. Urutkan Produk Berdasarkan Nama                              │");
            Console.WriteLine("│ 5. Cari Produk Berdasarkan Kategori                             │");
            Console.WriteLine("│ 6. Hitung Total Nilai Inventory                                 │");
            Console.WriteLine("│ 7. Keluar                                                       │");
            Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
        }

        /// <summary>
        /// Procedure untuk menampilkan semua produk dari multi dimensional array
        /// </summary>
        static void TampilkanSemuaProduk()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    DAFTAR SEMUA PRODUK                            ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15} {4,8} {5,-30}",
                "No", "Nama Produk", "Kategori", "Harga", "Stok", "Vendor");
            Console.WriteLine(new string('─', 120));

            for (int i = 0; i < dataProduk.GetLength(0); i++)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15:N0} {4,8} {5,-30}",
                    (i + 1),
                    dataProduk[i, 0],
                    dataProduk[i, 1],
                    double.Parse(dataProduk[i, 2]),
                    dataProduk[i, 3],
                    dataProduk[i, 4]);
            }

            Console.WriteLine(new string('─', 120));
            Console.WriteLine($"Total Produk: {dataProduk.GetLength(0)} item");
        }

        /// <summary>
        /// Procedure untuk menampilkan statistik kategori menggunakan one dimensional array
        /// </summary>
        static void TampilkanStatistikKategori()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║             STATISTIK TRANSAKSI PER KATEGORI (2025)               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("{0,-5} {1,-30} {2,20}", "No", "Kategori", "Total Transaksi (Rp)");
            Console.WriteLine(new string('─', 60));

            double grandTotal = 0;
            for (int i = 0; i < kategoriProduk.Length; i++)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,20:N0}",
                    (i + 1),
                    kategoriProduk[i],
                    totalTransaksi[i]);
                grandTotal += totalTransaksi[i];
            }

            Console.WriteLine(new string('─', 60));
            Console.WriteLine("{0,-5} {1,-30} {2,20:N0}", "", "TOTAL KESELURUHAN", grandTotal);

            // Menampilkan kategori dengan transaksi tertinggi
            int indexTertinggi = CariIndexTertinggi(totalTransaksi);
            Console.WriteLine($"\n✓ Kategori dengan transaksi tertinggi: {kategoriProduk[indexTertinggi]}");
            Console.WriteLine($"  Nilai: Rp {totalTransaksi[indexTertinggi]:N0}");
        }

        /// <summary>
        /// Procedure untuk mengurutkan produk berdasarkan harga (Bubble Sort)
        /// </summary>
        static void UrutkanProdukBerdasarkanHarga()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║         PRODUK DIURUTKAN BERDASARKAN HARGA (ASCENDING)            ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            // Copy array untuk sorting
            string[,] sortedData = (string[,])dataProduk.Clone();

            // Bubble Sort berdasarkan harga
            for (int i = 0; i < sortedData.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < sortedData.GetLength(0) - i - 1; j++)
                {
                    double harga1 = double.Parse(sortedData[j, 2]);
                    double harga2 = double.Parse(sortedData[j + 1, 2]);

                    if (harga1 > harga2)
                    {
                        // Tukar seluruh baris
                        for (int k = 0; k < sortedData.GetLength(1); k++)
                        {
                            string temp = sortedData[j, k];
                            sortedData[j, k] = sortedData[j + 1, k];
                            sortedData[j + 1, k] = temp;
                        }
                    }
                }
            }

            // Tampilkan hasil sorting
            Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15}",
                "No", "Nama Produk", "Kategori", "Harga (Rp)");
            Console.WriteLine(new string('─', 80));

            for (int i = 0; i < sortedData.GetLength(0); i++)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15:N0}",
                    (i + 1),
                    sortedData[i, 0],
                    sortedData[i, 1],
                    double.Parse(sortedData[i, 2]));
            }
        }

        /// <summary>
        /// Procedure untuk mengurutkan produk berdasarkan nama (Selection Sort)
        /// </summary>
        static void UrutkanProdukBerdasarkanNama()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║        PRODUK DIURUTKAN BERDASARKAN NAMA (ALPHABETICAL)           ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            // Copy array untuk sorting
            string[,] sortedData = (string[,])dataProduk.Clone();

            // Selection Sort berdasarkan nama
            for (int i = 0; i < sortedData.GetLength(0) - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < sortedData.GetLength(0); j++)
                {
                    if (string.Compare(sortedData[j, 0], sortedData[minIndex, 0], StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    // Tukar seluruh baris
                    for (int k = 0; k < sortedData.GetLength(1); k++)
                    {
                        (sortedData[minIndex, k], sortedData[i, k]) = (sortedData[i, k], sortedData[minIndex, k]);
                    }
                }
            }

            // Tampilkan hasil sorting
            Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15}",
                "No", "Nama Produk", "Kategori", "Harga (Rp)");
            Console.WriteLine(new string('─', 80));

            for (int i = 0; i < sortedData.GetLength(0); i++)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,15:N0}",
                    (i + 1),
                    sortedData[i, 0],
                    sortedData[i, 1],
                    double.Parse(sortedData[i, 2]));
            }
        }

        /// <summary>
        /// Procedure untuk mencari dan menampilkan produk berdasarkan kategori
        /// </summary>
        static void CariProdukBerdasarkanKategori()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              CARI PRODUK BERDASARKAN KATEGORI                     ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            // Tampilkan daftar kategori
            Console.WriteLine("Kategori yang tersedia:");
            for (int i = 0; i < kategoriProduk.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {kategoriProduk[i]}");
            }

            Console.Write("\nMasukkan nomor kategori (1-5): ");
            string input = Console.ReadLine() ?? "";
            
            // Validasi input dan konversi ke index
            if (!int.TryParse(input, out int nomorKategori) || nomorKategori < 1 || nomorKategori > kategoriProduk.Length)
            {
                Console.WriteLine("\nNomor kategori tidak valid!");
                return;
            }
            
            string kategoriCari = kategoriProduk[nomorKategori - 1];

            Console.WriteLine($"\n--- Produk dalam kategori '{kategoriCari}' ---\n");
            Console.WriteLine("{0,-5} {1,-30} {2,15} {3,8}", "No", "Nama Produk", "Harga (Rp)", "Stok");
            Console.WriteLine(new string('─', 60));

            int counter = 0;
            for (int i = 0; i < dataProduk.GetLength(0); i++)
            {
                if (dataProduk[i, 1].Equals(kategoriCari, StringComparison.OrdinalIgnoreCase))
                {
                    counter++;
                    Console.WriteLine("{0,-5} {1,-30} {2,15:N0} {3,8}",
                        counter,
                        dataProduk[i, 0],
                        double.Parse(dataProduk[i, 2]),
                        dataProduk[i, 3]);
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Tidak ada produk dalam kategori tersebut.");
            }
            else
            {
                Console.WriteLine(new string('─', 60));
                Console.WriteLine($"Total: {counter} produk ditemukan");
            }
        }

        /// <summary>
        /// Procedure untuk menampilkan penutup
        /// </summary>
        static void TampilkanPenutup()
        {
            Console.WriteLine("\n╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║     Terima kasih telah menggunakan E-Katalog Pemerintah           ║");
            Console.WriteLine("║          Program dibuat untuk pembelajaran Array di C#            ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");
        }

        // ==================== FUNCTION (RETURN METHODS) ====================

        /// <summary>
        /// Function untuk mencari index dengan nilai tertinggi dalam one dimensional array
        /// </summary>
        /// <param name="array">Array yang akan dicari</param>
        /// <returns>Index dari nilai tertinggi</returns>
        static int CariIndexTertinggi(double[] array)
        {
            int indexMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indexMax])
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }

        /// <summary>
        /// Function untuk menghitung total nilai inventory
        /// </summary>
        /// <returns>Total nilai inventory</returns>
        static double HitungTotalNilaiInventory()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 PERHITUNGAN NILAI INVENTORY                       ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("{0,-5} {1,-30} {2,15} {3,8} {4,18}",
                "No", "Nama Produk", "Harga (Rp)", "Stok", "Total Nilai (Rp)");
            Console.WriteLine(new string('─', 85));

            double totalNilai = 0;
            for (int i = 0; i < dataProduk.GetLength(0); i++)
            {
                double harga = double.Parse(dataProduk[i, 2]);
                int stok = int.Parse(dataProduk[i, 3]);
                double nilaiProduk = harga * stok;

                Console.WriteLine("{0,-5} {1,-30} {2,15:N0} {3,8} {4,18:N0}",
                    (i + 1),
                    dataProduk[i, 0],
                    harga,
                    stok,
                    nilaiProduk);

                totalNilai += nilaiProduk;
            }

            Console.WriteLine(new string('─', 85));
            Console.WriteLine("{0,-5} {1,-30} {2,15} {3,8} {4,18:N0}",
                "", "TOTAL NILAI INVENTORY", "", "", totalNilai);

            // Hitung dan tampilkan statistik tambahan
            double rataRataNilai = HitungRataRataNilaiProduk();
            Console.WriteLine($"\n✓ Rata-rata nilai per produk: Rp {rataRataNilai:N0}");
            Console.WriteLine($"✓ Jumlah jenis produk: {dataProduk.GetLength(0)} item");
            Console.WriteLine($"✓ Total stok keseluruhan: {HitungTotalStok()} unit");

            return totalNilai;
        }

        /// <summary>
        /// Function untuk menghitung rata-rata nilai produk
        /// </summary>
        /// <returns>Rata-rata nilai produk</returns>
        static double HitungRataRataNilaiProduk()
        {
            double totalNilai = 0;
            for (int i = 0; i < dataProduk.GetLength(0); i++)
            {
                double harga = double.Parse(dataProduk[i, 2]);
                int stok = int.Parse(dataProduk[i, 3]);
                totalNilai += (harga * stok);
            }
            return totalNilai / dataProduk.GetLength(0);
        }

        /// <summary>
        /// Function untuk menghitung total stok semua produk
        /// </summary>
        /// <returns>Total stok</returns>
        static int HitungTotalStok()
        {
            int totalStok = 0;
            for (int i = 0; i < dataProduk.GetLength(0); i++)
            {
                totalStok += int.Parse(dataProduk[i, 3]);
            }
            return totalStok;
        }
    }
}
