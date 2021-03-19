using System;
using System.Collections.Generic;

#nullable disable

namespace KeiraTheCaticorn.Models
{
    public partial class Comment
    {
        public string Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public string UserId { get; set; }
        public string UserImage { get; set; }
        public string UserName { get; set; }
        public string Comment1 { get; set; }
    }
}
