using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using File.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FileUploadApp.Controllers
{
    public class DownloadController : Controller
    {
        DBContext _context;
        IHostingEnvironment _appEnvironment;

        public DownloadController(DBContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Download()
        {
            return View(_context.Files.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Download(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Download");
        }
    }
}