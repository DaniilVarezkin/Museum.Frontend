using Microsoft.AspNetCore.Components;
using Museum.Frontend.Services;

namespace Museum.Frontend.Components.Pages.Home.Components
{
    public class MuseumEventListComponentModel : ComponentBase
    {
        [Inject]
        public MuseumClient Api {  get; set; }

        public string BaseUrl => Api.BaseUrl;

        [Parameter]
        public MuseumEventListVm MuseumEventList { get; set; }
    }
}
