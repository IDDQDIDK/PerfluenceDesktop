using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Materials
    {
        public int Id { get; set; }
        public byte[] Logo { get; set; }
        public string SomeText { get; set; }
        public int? Project { get; set; }

        public virtual Projects ProjectNavigation { get; set; }
    }
}
