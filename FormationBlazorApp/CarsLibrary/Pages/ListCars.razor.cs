using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ServicesLibrary.Models;
using ServicesLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarsLibrary.Pages
{
    public partial class ListCars : ComponentBase
    {
        [Inject]
        public CarsService carServ { get; set; }
        [Inject]
        public IJSRuntime jsRuntime { get; set; }

        private List<Car>? cars;

        protected override async Task OnInitializedAsync()
        {
            this.cars = await carServ.GetCarsAsync();
        }

        public async void delete(Car car)
        {
            if (await jsRuntime.InvokeAsync<bool>("confirm", $"Souhaitez-vous supprimer la voiture {car.Model}"))
            {
                await carServ.DeleteCarAsync(car.ID);
                this.cars = await carServ.GetCarsAsync();
                StateHasChanged();
            }
        }
    }
}
