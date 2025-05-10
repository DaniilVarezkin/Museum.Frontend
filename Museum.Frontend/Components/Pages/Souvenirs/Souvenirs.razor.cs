using Microsoft.AspNetCore.Components;
using Museum.Frontend.Services;

namespace Museum.Frontend.Components.Pages.Souvenirs
{
    public class SouvenirsViewModel : ComponentBase
    {
        [Inject] public MuseumClient Api { get; set; }

        public SouvenirListVm? SouvenirListVm = null;
        public string BaseUrl => Api.BaseUrl;

        public async Task GetAllSouvenirsAsync()
        {
            SouvenirListVm = await Api.GetAll2Async();
        }
        protected async override Task OnInitializedAsync()
        {
            try
            {
                await GetAllSouvenirsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
