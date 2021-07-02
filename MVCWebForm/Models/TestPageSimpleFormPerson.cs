using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebForm.Models
{
    public class TestPageSimpleFormPerson
    {
        public Guid Id { get; set; }
        public string LegalName { get; set; }
        public string PreferredName { get; set; }
        public TestPageSimpleFormPerson()
        {
            Id = Guid.NewGuid();
            LegalName = string.Empty;
            PreferredName = string.Empty;
        }
        public TestPageSimpleFormPerson(string legalName, string preferredName)
        {
            Id = Guid.NewGuid();
            LegalName = legalName;
            PreferredName = preferredName;
        }
        public TestPageSimpleFormPerson(Guid id, string legalName, string preferredName)
        {
            Id = id;
            LegalName = legalName;
            PreferredName = preferredName;
        }
    }
}
