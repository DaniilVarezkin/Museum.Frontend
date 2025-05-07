using Microsoft.AspNetCore.Components;
using Museum.Frontend.Services;

namespace Museum.Frontend.Components.Pages
{
    public class HomeViewModel : ComponentBase
    {
        [Inject] public MuseumClient api {  get; set; }

        public MuseumEventListVm? response = null;
        public string BaseUrl => api.BaseUrl;

        public async Task GetAllEventsAsync()
        {
            response = await api.GetAllAsync();
        }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                await base.OnInitializedAsync();
            }
            catch { }
        }
    }
}
