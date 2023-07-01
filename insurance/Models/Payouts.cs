using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Payouts
    {
        public int Id { get; set; }
        public int Post { get; set; }
        public DateTime WhenDate { get; set; }

        public virtual Posts PostNavigation { get; set; }
    }
}
