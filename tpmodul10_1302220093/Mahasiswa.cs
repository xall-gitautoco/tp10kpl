using System;

// mendeklarasikan class bernama Mahasiswa
public class Mahasiswa
{

    // mendeklarasikan atribut Mahasiswa yakni NIM, dan Nama
    public string NIM { get; set; }
    public string Nama { get; set; }

    // Constructor untuk Class Mahasiswa
    public Mahasiswa(String nama, string nim)
	{
		this.Nama = nama;
        this.NIM = nim;
	}
}
