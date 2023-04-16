using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tpmodul9_1302210128.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>()
        {
            new  Mahasiswa(){ nama = "Ariel Pabibak Pali' Mallua'", nim = "1302210128"},
            new  Mahasiswa(){ nama = "Lebron James", nim = "1302000001"},
            new  Mahasiswa(){ nama = "Stephen Curry", nim = "1302000002"}
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GET()
        {
            return mahasiswas;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa murid)
        {
            mahasiswas.Add(murid);
        }

        [HttpGet("{id}")]
        public void GET(int id, [FromBody] Mahasiswa murid)
        {

            mahasiswas[id] = murid;
        }//maaf tapi ini saya belum dapat caranya

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}
