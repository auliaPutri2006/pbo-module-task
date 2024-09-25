using System;
using System.Collections.Generic;


namespace tugas_Asprak1
{
    public class Hewan
    {
        public string nama;
        public int umur;

        public Hewan(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public virtual string Suara()
        {
            return "hewan ini bersuara!";
        }

        public string InfoHewan()
        {
            return $"\nHewan ini memiliki nama {nama} dan berumur {umur} tahun";
        }
    }

    class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.jumlahKaki = jumlahKaki;
        }
        public string InfoHewan(int jumlahKaki)
        {
            return $"\nHewan ini memiliki nama {nama}, berumur {umur}, dan memiliki {jumlahKaki} kaki";
        }

        public override string Suara()
        {
            return "Mamalia sedang mengeluarkan suaranya";
        }
    }

    class Reptil : Hewan
    {
        public double panjangTubuh;

        public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
        {
            this.panjangTubuh = panjangTubuh;
        }

        public override string Suara()
        {
            return "Reptil mengeluarkan suaranya yang besar dan berat";
        }
    }

    class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

        public override string Suara()
        {
            return "\nmenderum (uuuu!!)";
        }
    }

    class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

        public void Mengaum()
        {
            Console.WriteLine($"\nSinga {nama} mengeluarkan suara mengaum!");
        }

        public override string Suara()
        {
            return "\nAuuurgh!!";
        }
    }

    class Ular : Reptil
    {
        public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

        public void Merayap()
        {
            Console.WriteLine($"\nUlar {nama} sedang merayap di atas tanah");
        }

        public override string Suara()
        {
            return "\nShhhh!!";
        }
    }

    class Buaya : Reptil
    {
        public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

        public override string Suara()
        {
            return "\nGro-gro";
        }
    }

    class KebunBinatang
    {
        List<Hewan> koleksiHewan = new List<Hewan>();

        public void TambahHewan(Hewan hewan)
        {
            koleksiHewan.Add(hewan);
        }

        public void DaftarHewan()
        {
            foreach (var hewan in koleksiHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunbinatang = new KebunBinatang();

            Gajah gajahSatu = new Gajah("Gajah Kalimantan", 6, 4);
            Gajah gajahdua = new Gajah("Gajah Sumatra", 8, 4);
            Singa singaSatu = new Singa("Singa Afrika", 2, 4);
            Singa singadua = new Singa("Singa Australia", 3, 4);
            Ular ularSatu = new Ular("Ular Anaconda", 2, 10.0);
            Ular ulardua = new Ular("Ular Boa", 3, 12.0);
            Buaya buayaSatu = new Buaya("Buaya Muara", 1, 3.0);
            Buaya buayaDua = new Buaya("Buaya Air Tawar", 4, 5.0);

            kebunbinatang.TambahHewan(gajahSatu);
            kebunbinatang.TambahHewan(gajahdua);
            kebunbinatang.TambahHewan(singaSatu);
            kebunbinatang.TambahHewan(singadua);
            kebunbinatang.TambahHewan(ularSatu);
            kebunbinatang.TambahHewan(ulardua);
            kebunbinatang.TambahHewan(buayaSatu);
            kebunbinatang.TambahHewan(buayaDua);

            Console.WriteLine(gajahSatu.Suara());
            Console.WriteLine(gajahdua.Suara());
            Console.WriteLine(singaSatu.Suara());
            Console.WriteLine(singadua.Suara());
            Console.WriteLine(ularSatu.Suara());
            Console.WriteLine(ulardua.Suara());
            Console.WriteLine(buayaSatu.Suara());
            Console.WriteLine(buayaDua.Suara());

            singaSatu.Mengaum();
            singadua.Mengaum();
            ularSatu.Merayap();
            ulardua.Merayap();

            //perintah dari soal nomer 4:
            Reptil reptil = new Buaya("Buaya putih", 6, 5);
            Console.WriteLine(reptil.Suara());

            kebunbinatang.DaftarHewan();

            Console.WriteLine(singaSatu.InfoHewan(singaSatu.jumlahKaki));



            Console.ReadLine();
        }
    }
}

