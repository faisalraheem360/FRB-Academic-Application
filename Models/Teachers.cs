using System;
using System.Collections.Generic;

namespace FRBAcademicDataApp.Models
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
