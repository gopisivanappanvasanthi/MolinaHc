using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Molina.Feature.PageContent.Models
{
    public class AuthorDetails
    {
        public HtmlString AuthorName { get; set; }
        public HtmlString AuthorAge { get; set; }
        public HtmlString AuthorDesignation { get; set; }
        public HtmlString AuthorSpeciality { get; set; }
        public HtmlString AuthorImage { get; set; }

    }
}