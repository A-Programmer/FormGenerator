using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;

namespace Project.Areas.Admin.Controllers
{
    public class ManageFormsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ManageFormsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageFormData(int id)
        {
            var items = await _db.FormDatas.Where(x => x.FormId == id)
                .OrderByDescending(x => x.Id)
            .ToListAsync();

            return View(items);
        }

    }
}