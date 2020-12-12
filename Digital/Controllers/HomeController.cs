using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Digital.Models;
using Microsoft.AspNetCore.Authorization;
using System.Dynamic;

namespace Digital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ResumeContext _context = new ResumeContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

  
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateResume(Resume resume)
        {
            _context.Resumes.Add(resume);
            _context.SaveChanges();
            return RedirectToAction("Resume", "Home");

        }

        public ActionResult Resume()
        {

            return View(_context.Resumes.ToList());
        }


        public ActionResult UpdateResumePage(int id)
        {

            return View(_context.Resumes.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult UpdateResume(Resume resume)
        {
            Resume d = _context.Resumes.Where(s => s.Id == resume.Id).First();
            d.Address = resume.Address;
            d.Tel = resume.Tel;
            d.Email = resume.Email;
            d.Profile = resume.Profile;

            _context.SaveChanges();
            return RedirectToAction("Resume", "Home");
        }

        [HttpPost]
        public bool DeleteResume(int id)
        {
            try
            {
                Resume resume = _context.Resumes.Where(s => s.Id == id).First();
                _context.Resumes.Remove(resume);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }



        [HttpPost]
        public ActionResult CreateLanguage(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
            return RedirectToAction("Language", "Home");

        }

        public ActionResult Language()
        {

            return View(_context.Languages.ToList());
        }


        public ActionResult UpdateLanguagePage(int id)
        {

            return View(_context.Languages.Where(s => s.IDLanguage == id).First());
        }

        [HttpPost]
        public ActionResult UpdateLanguage(Language language)
        {
            Language d = _context.Languages.Where(s => s.IDLanguage == language.IDLanguage).First();
            d.LanguageName = language.LanguageName;
            d.Proficiency = language.Proficiency;
            

            _context.SaveChanges();
            return RedirectToAction("Language", "Home");
        }

        [HttpPost]
        public bool DeleteLanguage(int id)
        {
            try
            {
                Language language = _context.Languages.Where(s => s.IDLanguage == id).First();
                _context.Languages.Remove(language);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Skill", "Home");

        }

        public ActionResult Skill()
        {

            return View(_context.Skills.ToList());
        }


        public ActionResult UpdateSkillPage(int id)
        {

            return View(_context.Skills.Where(s => s.IDSkill == id).First());
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            Skill d = _context.Skills.Where(s => s.IDSkill == skill.IDSkill).First();
            d.SkillName = skill.SkillName;
           


            _context.SaveChanges();
            return RedirectToAction("Skill", "Home");
        }

        [HttpPost]
        public bool DeleteSkill(int id)
        {
            try
            {
                Skill skill = _context.Skills.Where(s => s.IDSkill == id).First();
                _context.Skills.Remove(skill);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }


        [HttpPost]
        public ActionResult CreateWorkExperience(WorkExperience workexperience)
        {
            _context.WorkExperiences.Add(workexperience);
            _context.SaveChanges();
            return RedirectToAction("WorkExperience", "Home");

        }

        public ActionResult WorkExperience()
        {

            return View(_context.WorkExperiences.ToList());
        }


        public ActionResult UpdateWorkExperiencePage(int id)
        {

            return View(_context.WorkExperiences.Where(s => s.ExperienceID == id).First());
        }

        [HttpPost]
        public ActionResult UpdateWorkExperience(WorkExperience workexperience)
        {
            WorkExperience d = _context.WorkExperiences.Where(s => s.ExperienceID == workexperience.ExperienceID).First();
            d.Company = workexperience.Company;
            d.Title = workexperience.Title;
            d.Country = workexperience.Country;
            d.FromYear = workexperience.FromYear;
            d.ToYear = workexperience.ToYear;
            d.Description = workexperience.Description;


            _context.SaveChanges();
            return RedirectToAction("WorkExperience", "Home");
        }

        [HttpPost]
        public bool DeleteWorkExperince(int id)
        {
            try
            {
                WorkExperience workexperince = _context.WorkExperiences.Where(s => s.ExperienceID == id).First();
                _context.WorkExperiences.Remove(workexperince);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }


        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Education", "Home");

            //var result = (from N in _context.Educations
            //              where N.University.Contains(term)
            //              select new { value = N.University });
        }

        public ActionResult Education()
        {

            return View(_context.Educations.ToList());
        }


        public ActionResult UpdateEducationPage(int id)
        {

            return View(_context.Educations.Where(s => s.IDEdu == id).First());
        }

        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            Education d = _context.Educations.Where(s => s.IDEdu == education.IDEdu).First();
            d.University = education.University;
            d.Degree = education.Degree;
            d.FromYear = education.FromYear;
            d.ToYear = education.ToYear;
     


            _context.SaveChanges();
            return RedirectToAction("Education", "Home");
        }

        [HttpPost]
        public bool DeleteEducation(int id)
        {
            try
            {
                Education education = _context.Educations.Where(s => s.IDEdu == id).First();
                _context.Educations.Remove(education);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        [HttpPost]
        public ActionResult CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return RedirectToAction("Company", "Home");

        }

        public ActionResult Company()
        {

            return View(_context.Companies.ToList());
        }


        public ActionResult UpdateCompanyPage(int id)
        {

            return View(_context.Companies.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult UpdateCompany(Company company)
        {
            Company d = _context.Companies.Where(s => s.Id == company.Id).First();
            d.NameOfCompany = company.NameOfCompany;
            d.Salary = company.Salary;
            d.Description = company.Description;
           


            _context.SaveChanges();
            return RedirectToAction("Company", "Home");
        }

        [HttpPost]
        public bool DeleteCompany(int id)
        {
            try
            {
                Company company = _context.Companies.Where(s => s.Id == id).First();
                _context.Companies.Remove(company);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        [HttpPost]
        public ActionResult CreateUser(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Persons.Add(person);
                _context.SaveChanges();
                
            }
            else
            {
                TempData["ErrorMessage"] = "IS EMPTY OR THIS VALUE ALREADY EXISTS IN DATABASE";
            }
            return RedirectToAction("Person", "Home");

        }

        public ActionResult Person()
        {
            var errMsg = TempData["ErrorMessage"] as string;
            dynamic myModel = new ExpandoObject();
            myModel.Persons = _context.Persons.ToList();
            myModel.ErrorMessage = errMsg;


            return View(myModel);
         
        }


        public ActionResult UpdateUserPage(int id)
        {

            return View(_context.Persons.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult UpdateUser(Person person)
        {
            Person d = _context.Persons.Where(s => s.Id == person.Id).First();
            d.FirstName = person.FirstName;
            d.LastName = person.LastName;
            d.Email = person.Email;
            d.Password = person.Password;
            d.DateOfBirth = person.DateOfBirth;
            d.Resumes = person.Resumes;


            _context.SaveChanges();
            return RedirectToAction("Person", "Home");
        }

        [HttpPost]
        public bool DeleteUser(int id)
        {
            try
            {
                Person person = _context.Persons.Where(s => s.Id == id).First();
                _context.Persons.Remove(person);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
