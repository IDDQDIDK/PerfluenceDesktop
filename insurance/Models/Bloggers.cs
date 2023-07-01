using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Bloggers
    {
        public Bloggers()
        {
            Posts = new HashSet<Posts>();
            Requests = new HashSet<Requests>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Blog { get; set; }
        public string Requisits { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string Login { get; set; }
        public string Passcode { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
