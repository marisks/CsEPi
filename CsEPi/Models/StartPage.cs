using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace CsEPi.Models
{
    [ContentType(DisplayName = "Start page", GUID = "0E7FF2CB-C0C9-498D-A7EB-29310CA122E2")]
    public class StartPage : PageData
    {
        [Display(Name = "Heading")]
        public virtual string Heading { get; set; }
    }
}