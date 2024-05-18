using HRSystem.Models;
using HRSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRSystem.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfile crud;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProfileController(IProfile crud, IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.crud = crud;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MyProfile(String id ) {



             return View(await this.crud.ReadWithInclude(id));

           
        
        }

        [HttpPost]
        public async Task<IActionResult> AddMyData(PersonalInfo info)
        {

            info.Image_path = await this.UploadFile(info.file);
            await  this.crud.Create(info);

            //  return RedirectToAction("MyProfile",new {id=info.UserId });
            return View();
        }


       
        private async Task<String> UploadFile(IFormFile file)
        {
            string fileName = null;
            if (file != null)
            {
                string UploadDir = Path.Combine(this.webHostEnvironment.WebRootPath, "Images");

                fileName = Guid.NewGuid().ToString() + "." + file.FileName;

                String FilePath = Path.Combine(UploadDir, fileName);

                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {

                    await file.CopyToAsync(fileStream);
                    return "/Images/" + fileName;
                }


            }

            return null;

        }



    }
}
