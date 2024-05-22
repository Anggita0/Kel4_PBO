using Kel4_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kel4_PBO.Model
{
    internal class barangContext
    {
        public List<Barang> barangList = new List<Barang>();

        public bool Update(Barang barang)
        {
            bool isSuccess = false;
            string connectionString = "Server=localhost;Port=5432;Database=kinkapp;User Id=postgres;Password=Jisung03";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE barang_table
                        SET 
                            stok = @Stok,
                            kategori = @Kategori,
                            harga = @Harga,
                            tanggal_masuk = @TanggalMasuk
                        WHERE 
                            nama = @Nama";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nama", barang.Nama);
                        cmd.Parameters.AddWithValue("@Stok", barang.Stok);
                        cmd.Parameters.AddWithValue("@Kategori", barang.Kategori);
                        cmd.Parameters.AddWithValue("@Harga", barang.Harga);
                        cmd.Parameters.AddWithValue("@TanggalMasuk", barang.TanggalMasuk);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            { 
                                Console.WriteLine(ex.Message);
                isSuccess = false;
            }

            return isSuccess;
        }

    }
} 
         
       