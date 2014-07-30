using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace CsEPi.Models
{
    [ContentType(DisplayName = "Start page", GUID = "0E7FF2CB-C0C9-498D-A7EB-29310CA122E2", Order = 10, AvailableInEditMode = true)]
    public class StartPage : PageData
    {
    }
}