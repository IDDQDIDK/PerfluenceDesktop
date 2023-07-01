using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Tags
    {
        public Tags()
        {
            Projecttags = new HashSet<Projecttags>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Projecttags> Projecttags { get; set; }
    }
}
