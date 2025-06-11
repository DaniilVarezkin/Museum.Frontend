using Microsoft.AspNetCore.Components;
using Museum.Frontend.Services;

namespace Museum.Frontend.Components.Pages.MuseumEventDetails
{
    public class MuseumEventDetailsViewModel : ComponentBase
    {
        [Parameter]
        public string? Id { get; set; }

        [Inject]
        public MuseumClient Api { get; set; }

        public string BaseUrl => Api.BaseUrl;

        public Guid MuseumEventId => Guid.TryParse(Id, out Guid eventId)
            ? eventId : Guid.Empty;

        public MuseumEventDetailsVm? DetailsVm { get; set; }

        public string PagetTitleImg { get
            {
                var photoPath = DetailsVm?.Photos?.FirstOrDefault()?.FilePath?.Replace("\\", "/");
                if (photoPath != null)
                {
                    return Path.Combine(BaseUrl, photoPath);
                }
                return "assets/images/background/page-title-5.jpg";
            } 
        }
        protected async override Task OnInitializedAsync()
        {
            await GetMuseumEventDetailsAsync();
        }


        private async Task GetMuseumEventDetailsAsync()
        {
            try
            {
                if(MuseumEventId != Guid.Empty)
                {
                    DetailsVm = await Api.GetAsync(MuseumEventId);
                }
            } 
            catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
