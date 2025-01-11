using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gathering
    {
        public int Id { get; private set; }
        public string Host { get; private set; }
        public string Object { get; private set; }
        public List<Invitation> Invitations { get; set; } = new();
        public List<Guest> Guests { get; set; } =new();
    }
}
