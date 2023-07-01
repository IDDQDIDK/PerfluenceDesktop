using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Projecttags
    {
        public int Id { get; set; }
        public int? Project { get; set; }
        public int? Tag { get; set; }

        public virtual Projects ProjectNavigation { get; set; }
        public virtual Tags TagNavigation { get; set; }
    }
}
