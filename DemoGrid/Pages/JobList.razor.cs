using System.Text;
using System.Text.Json;

namespace DemoGrid.Pages;

public partial class JobList
{
    private List<CadJobDto> cadJobs=new();


    protected override async Task OnInitializedAsync()
    {
        var requestModel = new
        {
            userName = "vishal.banwat@scandinaviandigital.com",
            fromdate = "2022-07-03T12:53:35.139Z",
            todate = "2023-08-03T12:53:35.139Z"
        };

        var jsonContent = new StringContent(JsonSerializer.Serialize(requestModel), Encoding.UTF8, "application/json");

        using (var httpResponse = await HttpClient.PostAsync("https://api.config2.com/api/Queue/ListOfAllJobsByUser", jsonContent))
        {
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                cadJobs= JsonSerializer.Deserialize<List<CadJobDto>>(result);
            }
            else
            {
                cadJobs = new List<CadJobDto>();
            }
        }
    }

 
}
