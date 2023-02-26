using NetCoreConfBCN23.Foms.Validation;
using System.ComponentModel.DataAnnotations;

namespace NetCoreConfBCN23.Foms.Model
{
    public class Category
    {
        [Required()]
        [StartsWithLetter]
        public string Name { get; set; }
    }
}
