using System.ComponentModel.DataAnnotations;

namespace webRGE.Entities.Base
{
    public class BaseEntity : IBaseEntity
    { 
        public int Id { get; set; }
    }
}
