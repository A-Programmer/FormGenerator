using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project.Data;
using Project.Models;
using Project.ViewModels;

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
        
        public async Task<IActionResult> Form(int id)
        {
            var form = await _db.Forms.Include("Fields").FirstOrDefaultAsync(x => x.Id == id);
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> Form(FormDataViewModel dta)
        {
            var frmId = dta.FormId;
            var obj = JObject.Parse(dta.FormValues);
            var namesString = dta.FilesName.Remove(dta.FilesName.LastIndexOf('='));
            var namesList = namesString.Split('=');
            Dictionary<string,string> namesDic = new Dictionary<string, string>();
            foreach(var row in namesList)
            {
                var item = row.Split('|');
                namesDic.Add(item[0],item[1]);
            }
            if(dta.Files != null)
            {
                foreach(var file in dta.Files)
                {
                    var currentfileName = file.FileName;
                    var names = namesDic.Where(x => x.Value == currentfileName);
                    if(names.Any())
                    {
                        var name = names.FirstOrDefault();
                        var gotName = name.Key; //Title of field
                        var gotFileName = currentfileName; //Save This File and return address
                        //Upload Image
                        
                        var fileLink = String.Format("<a href='{0}' target='_blank'>دانلود فایل</a>","Url of Uploaded Image");
                        obj.Add(gotName,fileLink);
                    }
                }
            }
            _db.FormDatas.Add(new FormData()
            {
                FormValues = JsonConvert.SerializeObject(obj),
                FormId = frmId
            });
            await _db.SaveChangesAsync();
            var forms = await _db.Forms.Include("Fields").FirstOrDefaultAsync(x => x.Id == frmId);
            return View(forms);
        }

    }
}