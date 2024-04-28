using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220093.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // inisialisasi data mahasiswa berupa anggota kelompok
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Rd.M. Faisal Ramadhan Junaidi","1302220093"),
            new Mahasiswa("Cokorda Arturito Revan Putra Diarta","1302223057"),
            new Mahasiswa("Farrel Haykal Giffari","1302220064"),
            new Mahasiswa("Rifqi Alghifari","1302223028"),
            new Mahasiswa("Faishal Harits Al-Fajri","1302223120"),
            new Mahasiswa("Riva Dwi Fadhillah Fajri Permana","1302223010"),
        };

        // menggunakan IEnumerable untuk menampilkan seluruh list
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // menggunakan post untuk menambah data pada list mahasiswa
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mahasiswa.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        // menampilan data mahasiwa berdasarkan id yang diinput
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]


        // menggunakan delete untuk menghapus data list berdasarkan id
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}
 