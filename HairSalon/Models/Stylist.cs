using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public string StylistSpecialties { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }
    }
}