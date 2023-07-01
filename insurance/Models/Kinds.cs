using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Kinds
    {
        public Kinds()
        {
            Projectkinds = new HashSet<Projectkinds>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Projectkinds> Projectkinds { get; set; }
    }
}
