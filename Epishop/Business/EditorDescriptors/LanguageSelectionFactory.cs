using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epishop.Business.EditorDescriptors
{
    public class LanguageSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] { new SelectItem() { Text = "English", Value = "En" }, new SelectItem() { Text = "Swedish", Value = "Sv" }, new SelectItem() { Text = "Hindi", Value = "Hi" } };
        }
        IEnumerable<ISelectItem> ISelectionFactory.GetSelections(ExtendedMetadata metadata)
        {
            throw new NotImplementedException();
        }
    }
}