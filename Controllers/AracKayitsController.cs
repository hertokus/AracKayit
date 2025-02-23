using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using GülsanAraçKayıt.Models;

namespace GülsanAraçKayıt.Controllers
{
    public class AracKayitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AracKayitsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: AracKayits
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehicleRecords.ToListAsync());
        }

        // GET: AracKayits/Search
        public async Task<IActionResult> Search(string searchString)
        {
            var records = from m in _context.VehicleRecords
                          select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                records = records.Where(s => s.Plaka.Contains(searchString)
                                              || s.SoforAdi.Contains(searchString)
                                              || s.DorsePlakasi.Contains(searchString)
                                              || s.GuvenlikAdi.Contains(searchString));
            }

            return View("Index", await records.ToListAsync());
        }

        // GET: AracKayits/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Araç kaydını ve soruları veritabanından çekiyoruz
            var aracKayit = _context.VehicleRecords
                                    .FirstOrDefault(m => m.Id == id);
            if (aracKayit == null)
            {
                return NotFound();
            }

            // Soruları veritabanından çek
            var sorular = _context.FormSorular.ToList();
            ViewBag.Sorular = sorular;

            return View(aracKayit);
        }

        // POST: AracKayits/Approve/5
        [HttpPost]
        public IActionResult Approve(int id, List<int> onaySorulari)
        {
            // İlgili araç kaydını bul
            var aracKayit = _context.VehicleRecords.Find(id);

            if (aracKayit == null)
            {
                // Araç kaydı bulunamazsa bir hata döndür
                return NotFound();
            }

            // Veritabanından tüm soruları çekin
            var tumSorular = _context.FormSorular.ToList();

            // Tüm soruların işaretlenip işaretlenmediğini kontrol edin
            if (onaySorulari != null && onaySorulari.Count == tumSorular.Count)
            {
                // Tüm sorular işaretlenmişse onay ver
                aracKayit.Onay = true;
            }
            else
            {
                aracKayit.Onay = false;
            }

            try
            {
                // Veritabanını güncelle
                _context.Update(aracKayit);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayın veya kullanıcıya gösterin
                ViewBag.ErrorMessage = "Onay işlemi sırasında bir hata oluştu.";
                return View("Error");
            }

            // İşlem tamamlandıktan sonra Index sayfasına dön
            return RedirectToAction(nameof(Index));
        }



        // GET: AracKayits/Create
        public IActionResult Create()
        {
            var guvenlikList = _context.Guvenlikler.ToList();
            ViewBag.GuvenlikList = new SelectList(guvenlikList, "Ad", "Ad");

            return View();
        }

        // POST: AracKayits/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Plaka,DorsePlakasi,SoforAdi,GuvenlikAdi,NakliyeSirketi,IsletmedenGeldigiYer,KayitTarihi")] AracKayit aracKayit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aracKayit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var guvenlikList = _context.Guvenlikler.ToList();
            ViewBag.GuvenlikList = new SelectList(guvenlikList, "Ad", "Ad");

            return View(aracKayit);
        }

        // GET: AracKayits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aracKayit = await _context.VehicleRecords.FindAsync(id);
            if (aracKayit == null)
            {
                return NotFound();
            }

            var guvenlikList = _context.Guvenlikler.ToList();
            ViewBag.GuvenlikList = new SelectList(guvenlikList, "Ad", "Ad");

            return View(aracKayit);
        }

        // POST: AracKayits/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Plaka,DorsePlakasi,SoforAdi,GuvenlikAdi,NakliyeSirketi,IsletmedenGeldigiYer,KayitTarihi,Onay")] AracKayit aracKayit)
        {
            if (id != aracKayit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aracKayit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AracKayitExists(aracKayit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var guvenlikList = _context.Guvenlikler.ToList();
            ViewBag.GuvenlikList = new SelectList(guvenlikList, "Ad", "Ad");

            return View(aracKayit);
        }

        // GET: AracKayits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aracKayit = await _context.VehicleRecords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aracKayit == null)
            {
                return NotFound();
            }

            return View(aracKayit);
        }

        // POST: AracKayits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aracKayit = await _context.VehicleRecords.FindAsync(id);
            if (aracKayit == null)
            {
                return NotFound(); // Kayıt yoksa 404 döner.
            }

            _context.VehicleRecords.Remove(aracKayit);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        private bool AracKayitExists(int id)
        {
            return _context.VehicleRecords.Any(e => e.Id == id);
        }
    }
}
