using Molina.Feature.PageContent.Models;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Molina.Feature.PageContent.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult GetAuthorDetails()
        {
            var ContextItem = Sitecore.Context.Item;

            AuthorDetails authorDetails = new AuthorDetails
            {
                AuthorName = new HtmlString(FieldRenderer.Render(ContextItem, "AuthorName")), 
                AuthorAge = new HtmlString(FieldRenderer.Render(ContextItem, "AuthorAge")),
                AuthorDesignation = new HtmlString(FieldRenderer.Render(ContextItem, "AuthorDesignation")),
                AuthorSpeciality = new HtmlString(FieldRenderer.Render(ContextItem, "AuthorSpeciality")), 
                AuthorImage = new HtmlString(FieldRenderer.Render(ContextItem, "AuthorImage")), 
            };

            return View("/Views/Molina/PageContent/Author.cshtml", authorDetails);
        }
    }
}