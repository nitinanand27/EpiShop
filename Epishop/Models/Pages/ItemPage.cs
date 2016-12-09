using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;
using EPiServer.Web;
using EPiServer.Editor.TinyMCE.Plugins;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors.SelectionFactories;
using Epishop.Business.EditorDescriptors;
using EPiServer.XForms;

namespace Epishop.Models.Pages
{
    [ContentType(DisplayName = "ItemPage", GUID = "bb6822d6-0d7d-461b-97b0-792f6e1daa2b", Description = "")]
    public class ItemPage : PageData
    {
        [Display(Name = "Heading text", GroupName = SystemTabNames.Content, Order = 1)]
        [StringLength(maximumLength: 10, ErrorMessage = "Max length 10, min 3", MinimumLength = 3)]
        public virtual string Heading { get; set; }

        [Display(Name = "Item Image", GroupName = SystemTabNames.Content, Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual Url ImageUrl { get; set; }

        [Display(Name = "Button text", GroupName = SystemTabNames.Content, Order = 3)]
        public virtual string ButtonText { get; set; }

        //[Display(Name = "Button link", GroupName = SystemTabNames.Content, Order = 4)]
        //public virtual LinkItem LinkUrl { get; set; }

        [Display(Name = "body", GroupName = SystemTabNames.Content, Order = 5)]
        public virtual XhtmlString MainBody { get; set; }


        /*[Display(Name = "Datetime", GroupName = SystemTabNames.Content, Order = 6)]
        [Range(typeof(DateTime), minimum:"2016-12-10 12:00:00", maximum: "2016-12-20 12:00:00")]
        public virtual DateTime DateTime { get; set; }*/

        [Display(Name = "page", GroupName = SystemTabNames.Content, Order = 7)]
        public virtual PageType Page { get; set; }

        [Display(Name = "Content reference",Description ="Choose single esxisting content", GroupName = SystemTabNames.Content, Order = 7)]
        //[AllowedTypes(new[] { typeof(ArticlePage) }, new[] { typeof(ContactPage) })]
        public virtual ContentReference ContentReference { get; set; }

        [Display(Name = "Image", GroupName = SystemTabNames.Content, Order = 8)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Video file", GroupName = SystemTabNames.Content, Order = 9)]
        [UIHint(UIHint.Video)]
        public virtual ContentReference Video { get; set; }

        [Display(Name = "Content Area", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual ContentArea ContentArea { get; set; }

        [Display(Name = "LinkItemCollection", GroupName = SystemTabNames.Content, Order = 11)]
        public virtual LinkItemCollection LinkItems { get; set; }

        [Display(Name = "Select 1 Contact Page", GroupName = SystemTabNames.Content, Order = 12)]
        [SelectOne(SelectionFactoryType =typeof(ContactPageSelectionFactory))]
        public virtual string SelectContactPage { get; set; }

        [Display(Name = "Select Contact Pages", GroupName = SystemTabNames.Content, Order = 13)]
        [SelectMany(SelectionFactoryType = typeof(ContactPageSelectionFactory))]
        public virtual string SelectManyContactPage { get; set; }

        [Display(Name = "My Form", GroupName = SystemTabNames.Content, Order = 14)]
        public virtual XForm Form { get; set; }
    }
}