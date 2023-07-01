using System;
using System.Collections.Generic;

namespace insurance.Models
{
    public partial class Posts
    {
        public Posts()
        {
            Payouts = new HashSet<Payouts>();
        }

        public int Id { get; set; }
        public int? Blogger { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }
        public int? Project { get; set; }
        public DateTime WhenDate { get; set; }

        public virtual Bloggers BloggerNavigation { get; set; }
        public virtual Projects ProjectNavigation { get; set; }
        public virtual ICollection<Payouts> Payouts { get; set; }
    }
}
