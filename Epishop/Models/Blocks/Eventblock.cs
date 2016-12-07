using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Epishop.Models.Blocks
{
    [ContentType(DisplayName = "Eventblock", GUID = "3ecb6f70-c745-4d69-8100-12c90fffaa43", Description = "a block to display event")]
    public class Eventblock : BlockData
    {
        [Display(Name = "Event Name", Order = 1, GroupName = SystemTabNames.Content)]
        public virtual string Name { get; set; }

        [Display(Name = "Location", Description = "Where event will take place", Order = 2, GroupName = SystemTabNames.Content)]
        public virtual string Place { get; set; }

        [Display(Name = "Date Time", Description = "when event will take place", Order = 3, GroupName = SystemTabNames.Content)]
        public virtual DateTime DateTime { get; set; }

        [Display(Name = "Event Image", Description = "image picture", Order = 4, GroupName = SystemTabNames.Content)]
        public virtual ContentReference Image { get; set; }

    }
}