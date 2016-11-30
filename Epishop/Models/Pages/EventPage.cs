using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Epishop.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "16da29ce-95f3-4880-ab54-f412a01ae0d1", Description = "")]
    public class EventPage : SitePageData
    {        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Header text", Description ="Heading for Event page", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Header{ get; set; }
    }
}