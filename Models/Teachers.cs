using System;
using System.Collections.Generic;

namespace FaisalRaheemAcademicDataApp.Models
{
    public partial class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Designation { get; set; }
    }
}
