using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;
using ModuleName.OrchardCore.Models;

namespace ModuleName.OrchardCore.Handlers
{
    public class TestPartPartHandler : ContentPartHandler<TestPartPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, TestPartPart part)
        {
            part.Show = true;

            return Task.CompletedTask;
        }
    }
}