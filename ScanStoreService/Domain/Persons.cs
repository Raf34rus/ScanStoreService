using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class Persons
    {
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
    }
}
