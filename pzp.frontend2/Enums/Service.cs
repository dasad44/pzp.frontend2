using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace pzp.frontend2.Enums
{
    public enum Service
    {
        [Display(Name = "Inne")]
        Other,
        [Display(Name = "Cewnikowanie")]
        Catheterization,
        [Display(Name = "Rany i opatrunki")]
        Wounds_And_Dressings,
        [Display(Name = "Podawanie leków i zastrzyków")]
        Drugs_And_Injections,
        [Display(Name = "Toaleta pacjenta")]
        Patient_Toilet,
        [Display(Name = "Nadzór nad pacjentem")]
        Patient_Supervision,
        [Display(Name = "Pomiar parametrów")]
        Parameter_Measurement,
        [Display(Name = "Edukacja")]
        Education,
        [Display(Name = "PEG/Stomia/Dreny/Tracheotomia) ")]
        PEG
    }

}
