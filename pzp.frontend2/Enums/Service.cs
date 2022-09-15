using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace pzp.frontend2.Enums
{
    public enum Service
    {
        Cardiology,
        [Display(Name = "Prior to accepting Quote")]
        MedicalResearch,
        Dental
    }

}
