using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Advertisers
    {
        public Advertisers()
        {
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public string Login { get; set; }
        public string Passcode { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
