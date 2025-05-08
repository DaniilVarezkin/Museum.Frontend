using Microsoft.AspNetCore.Components;
using Museum.Frontend.Services;

namespace Museum.Frontend.Components.Pages.MuseumEventList
{
    public class MuseumEventListViewModel : ComponentBase
    {
        [Inject] public MuseumClient api { get; set; }

        public MuseumEventListVm? MuseumEventListVm = null;
        public string BaseUrl => api.BaseUrl;

        public async Task GetAllEventsAsync()
        {
            MuseumEventListVm = await api.GetAllAsync();
        }
        protected async override Task OnInitializedAsync()
        {
            try
            {
                await GetAllEventsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
