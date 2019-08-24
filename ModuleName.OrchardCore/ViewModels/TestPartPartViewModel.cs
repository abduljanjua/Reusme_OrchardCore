using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;
using ModuleName.OrchardCore.Models;
using ModuleName.OrchardCore.Settings;

namespace ModuleName.OrchardCore.ViewModels
{
    public class TestPartPartViewModel
    {
        public string MySetting { get; set; }

        public bool Show { get; set; }

        [BindNever]
        public ContentItem ContentItem { get; set; }

        [BindNever]
        public TestPartPart TestPartPart { get; set; }

        [BindNever]
        public TestPartPartSettings Settings { get; set; }
    }
}
