using System;
using System.Collections.Generic;
using System.Linq;

namespace insurance.Models
{
    public partial class Projectkinds
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int? Project { get; set; }
        public int? Kind { get; set; }

        public virtual Kinds KindNavigation { get; set; }
        public virtual Projects ProjectNavigation { get; set; }
    }
}
