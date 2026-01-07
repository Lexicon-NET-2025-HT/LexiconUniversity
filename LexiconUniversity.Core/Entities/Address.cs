using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconUniversity.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        //Foreign key
        public int StudentId { get; set; }

        //Navigational property
        public Student Student { get; set; }
    }
}
