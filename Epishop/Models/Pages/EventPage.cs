using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Epishop.Models.Blocks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Epishop.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "5ab72018-aac4-4149-9c7c-640351e2e240", Description = "")]
    [ImageUrl("~/Epishop/Epishop/Static/img/event-tent-icon-camping-tent.jpg")]
    public class EventPage : PageData
    {
        [Display(Name ="Heading Text", GroupName =SystemTabNames.Content, Order =1)]
        public virtual string HeadingText { get; set; }

        [Display(Name = "Events",Description ="Event blocks for every event", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual ContentArea Eventblock { get; set; }
    }
}