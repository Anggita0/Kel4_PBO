using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Model
{
    public class Barang
    {

        public string Nama { get; set; }
        public int Stok { get; set; }
        public string Kategori { get; set; }
        public int Harga { get; set; }
        public DateTime TanggalMasuk { get; set; }

            public static List<Barang> DataBarang = new List<Barang>
            {
                new Barang { Nama = "Surya 12 Gudang Garam", Stok = 20, Kategori = "Rokok", Harga = 23000, TanggalMasuk = DateTime.Parse("2023-01-20") },
                new Barang { Nama = "Beras Raja Singa (Kg)", Stok = 30, Kategori = "Bahan Makanan", Harga = 12000, TanggalMasuk = DateTime.Parse("2023-02-03") },
                new Barang { Nama = "Telur (Kg)", Stok = 15, Kategori = "Bahan Makanan", Harga = 22000, TanggalMasuk = DateTime.Parse("2023-02-18") },
                new Barang { Nama = "Mie Sedap Goreng", Stok = 25, Kategori = "Bahan Makanan", Harga = 3500, TanggalMasuk = DateTime.Parse("2023-02-20") },
                new Barang { Nama = "Bimoli 2 Liter", Stok = 10, Kategori = "Bahan Makanan", Harga = 15000, TanggalMasuk = DateTime.Parse("2023-03-15") },
            };
        
    }




}
