using Microsoft.AspNetCore.Mvc;
using MVCWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebForm.Controllers
{
    public class TestPageSimpleFormController : Controller
    {
        public List<TestPageSimpleFormPerson> Persons { get; set; }
        public TestPageSimpleFormController()
        {
            Persons = GetSamplePeople();
        }

        public IActionResult Index()
        {
            return View(Persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(TestPageSimpleFormPerson person)
        {
            var editedPerson = Persons.FirstOrDefault(p => p.Id == person.Id);
            if (editedPerson != null)
            {
                editedPerson.LegalName = person.LegalName;
                editedPerson.PreferredName = person.PreferredName;
            }
            return View();
        }

        public IActionResult Delete(TestPageSimpleFormPerson person)
        {
            return View();
        }

        public IActionResult Details(TestPageSimpleFormPerson person)
        {
            return View();
        }
        private List<TestPageSimpleFormPerson> GetSamplePeople()
        {
            var lincoln = new TestPageSimpleFormPerson(Guid.Parse("2aa3cc23-ffb5-494f-921a-0e181d4bdad1"), "Abraham Lincoln", "Abe Lincoln");
            var jackson = new TestPageSimpleFormPerson(Guid.Parse("ae86d064-bf9e-44c7-8cc6-21a5ee8c78fc"), "Thomas Jonathan Jackson", "Stonewall Jackson");
            var persons = new List<TestPageSimpleFormPerson>()
            {
                lincoln,
                jackson
            };
            return persons;
        }
    }
}
