using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts
{
    public class UpdateContentViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}
