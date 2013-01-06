using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout.Mvc.Sandbox.Models
{
    public class ExamplesIndexViewModel
    {
        public IList<AdditionalRequirement> Requirements { get; set; }
    }

    public class AdditionalRequirement
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}