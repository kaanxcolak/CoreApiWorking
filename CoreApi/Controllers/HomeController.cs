using BusinessLayer.InterfacesOfManagers;
using DataLayer.InterfacesOfRepo;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [ApiController]
    [Route("h")]
    public class HomeController : Controller
    {
        private readonly IStudentManager _manager;

        public HomeController(IStudentManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        [Route("alls")]
        public IActionResult AllStudents()
        {

            try
            {
                var data = _manager.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult AddStudent(StudentVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Problem("Bilgileri eksiksiz girdiğinize emin olun! Tekrar deneyiniz!");
                }
                int index = model.Name.IndexOf(' ');
                model.FirstName = model.Name;
                if (index > -1)
                {
                    model.FirstName = model.Name.Substring(0, index);
                    model.SecondName = model.Name.Substring(index);
                }
                var result = _manager.Add(model);
                return Created("", result.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("find")]
        public IActionResult FindStudentsByYear(int? year)
        {
            try
            {
                if (year == null)
                {
                    //Yıl değeri verilmemişse bütün öğrencileri göndersin
                    return Problem("Yıl değeri vermediniz!");
                }

                var result = _manager.GetAll(x =>
                x.BirthDate != null && x.BirthDate.Value.Year == year).Data;
                if (result.Count > 0)
                {
                    return Ok(result);
                }
                else
                {
                    return Problem("Uygun veri bulunamadı!");
                }

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

    }
}