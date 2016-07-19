#region Usings

using System.ComponentModel.DataAnnotations;
using RedingtonMiniProject.Models;
using RedingtonMiniProject.Resources;

#endregion

namespace RedingtonMiniProject.ViewModels
{
    public class ProbabilityCalculatorViewModel
    {
        [Display(ResourceType = typeof (Translations), Name = "ADisplayedName")]
        [Range(0.0, 1.0)]
        public double A { get; set; }

        [Display(ResourceType = typeof (Translations), Name = "BDisplayedName")]
        [Range(0.0, 1.0)]
        public double B { get; set; }

        public Operation Operation { get; set; }
    }
}