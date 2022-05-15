using System.Collections.Generic;
using webRGE.Entities;

namespace webRGE.ViewModels
{
    public class Egr01ViewModel
    {
        public IEnumerable<EGR01> RegisterdUsers { get; set; }

        public SearchFilter SearchText { get; set; }
    }
}
