using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Materials = new HashSet<Materials>();
            Posts = new HashSet<Posts>();
            Projectkinds = new HashSet<Projectkinds>();
            Projecttags = new HashSet<Projecttags>();
            Requests = new HashSet<Requests>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Specification { get; set; }
        public int? Responsible { get; set; }
        public int? Company { get; set; }
        public DateTime DateStart { get; set; }
        public int Duration { get; set; }

        public virtual Advertisers CompanyNavigation { get; set; }
        public virtual Scouts ResponsibleNavigation { get; set; }
        public virtual ICollection<Materials> Materials { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<Projectkinds> Projectkinds { get; set; }
        public virtual ICollection<Projecttags> Projecttags { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
