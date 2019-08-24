using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModuleName.OrchardCore.Settings
{
    public class TestPartPartSettingsViewModel
    {
        public string MySetting { get; set; }

        [BindNever]
        public TestPartPartSettings TestPartPartSettings { get; set; }
    }
}
