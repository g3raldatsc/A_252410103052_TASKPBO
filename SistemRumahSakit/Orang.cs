using System;

namespace SistemRumahSakit
{
    // aku buat parent class dulu untuk nanti buat semua orang di rs
    public class Orang
    {
        // enskapsulasi
        private string nama;
        private int umur;

        // ini propertinya king
        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nama = value;
                }
                else
                {
                    Console.WriteLine("Nama tidak boleh kosong.");
                }
            }
        }

        public int Umur
        {
            get
            {
                return umur;
            }
            set
            {
                if (value >= 0)
                {
                    umur = value;
                }
                else
                {
                    Console.WriteLine("Umur tidak boleh negatif.");
                }
            }
        }

        // ini constructor si class Orang
        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        // virtual biar nanti bisa di override oleh derivcat classnyaa
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang beraktivitas di rumah sakit.");
        }

        public void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama}, Umur: {Umur} tahun.");
        }
    }
}