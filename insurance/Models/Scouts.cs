using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Scouts
    {
        public Scouts()
        {
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Passcode { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
