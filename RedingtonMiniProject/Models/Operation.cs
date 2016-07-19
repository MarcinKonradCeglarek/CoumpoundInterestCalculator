#region Usings

using System.ComponentModel.DataAnnotations;
using RedingtonMiniProject.Resources;

#endregion

namespace RedingtonMiniProject.Models
{
    public enum Operation
    {
        [Display(ResourceType = typeof (Translations), Name = "CombineWith")]
        CombineWith,

        [Display(ResourceType = typeof (Translations), Name = "Either")]
        Either
    }
}