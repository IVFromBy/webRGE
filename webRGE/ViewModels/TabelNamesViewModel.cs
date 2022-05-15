using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using webRGE.Entities.Enum;

namespace webRGE.ViewModels
{
    public class TabelNamesViewModel
    {
        public TabelNames TabelNames { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
