using System.Collections.Generic;
using webRGE.Entities;
using webRGE.Entities.Reports;

namespace webRGE.ViewModels
{
    public class Egr01NameViewModel
    {
        public IEnumerable<MainSearch> RegisterdUsers { get; set; }

        public SearchFilter SearchText { get; set; }
    }
}
