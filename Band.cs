using System;

namespace Rhythm
{
    class Band
    {
        public string Name { get; set; }
        public bool IsSigned { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Id { get; set; }
        public int NumberOfMembers { get; set; }
        public string Website { get; set; }
        public string Style { get; set; }
        public string ContactName { get; set; }
        public int ContactPhoneNumber { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}