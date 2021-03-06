#pragma checksum "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\Pages\CreateCola.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe9a1b868429ffbf88199f8b8f8e13bddf16225"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AssessmentDotNet2020.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using AssessmentDotNet2020.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\_Imports.razor"
using AssessmentDotNet2020.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\Pages\CreateCola.razor"
using AssessmentDotNet2020.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cola/create")]
    public partial class CreateCola : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Cristian\source\repos\AssessmentDotNet2020\AssessmentDotNet2020\Client\Pages\CreateCola.razor"
       
    private People people = new People();
    private List<ColaPeople> cola1 = new List<ColaPeople>();
    private List<ColaPeople> cola2 = new List<ColaPeople>();


    protected async override Task OnInitializedAsync()
    {
        await loadColas();
    }

    public async Task Crear()
    {
        var httpResponse = await repositorio.Post("api/people", people);
        if (httpResponse.Error)
        {
            var body = await httpResponse.HttpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
        else
        {
            Console.WriteLine("Resigtro insertado con exito");
            people = new People();
        }
        await loadColas();
    }
    public async Task loadColas()
    {
        var httpResponse = await repositorio.Get<List<ColaPeople>>($"api/people/{1}");
        cola1 = httpResponse.Response;
        httpResponse = await repositorio.Get<List<ColaPeople>>($"api/people/{2}");
        cola2 = httpResponse.Response;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
