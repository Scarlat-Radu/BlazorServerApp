using BlazorServerApp.Models;
using BlazorServerApp.Pages.ContactComponents;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    public partial class Index
    {
        [Inject]
        IContactSerivce contactService { get; set; } //Depency injection
        [Inject]
        NavigationManager navigationManager { get; set; }

        private int _currentCount;
        private string userName = "Radu";

        private bool isContactVisible = true;
        private List<Contact> contacts;
        private ContactList contactList;

        private DateTime dateTimeNow = new DateTime();
        private readonly PeriodicTimer _periodicTimer = new(TimeSpan.FromSeconds(5));
        private Dictionary<string, object> SimpleTextBoxAttributes = new Dictionary<string, object>
        {
           {"placeholder","Text..."},
        };

        protected async override Task OnInitializedAsync()
		{   
            Initialize();

			await Task.Delay(2000);
            contacts = contactService.GetContacts();
            /*contacts = new List<Contact>
        {
            new Contact
            {
                Name = "ABC",
                Email = "CBA",
            },
             new Contact
            {
                Name = "ABC",
                Email = "CBA",
            },
            new Contact
            {
                Name = "ABC",
                Email = "CBA",
            },
        };*/
            base.OnInitializedAsync();
        }
        private void Initialize()
        {
            var timer = new Timer(new TimerCallback(_ =>
            {
                _currentCount++;
                InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            }), null, 1000, 1000);
        }
        private string GetUsesName() => userName;

        private DateTime GetTimeNow() => DateTime.Now;
        private void ChangeName()
        {
            userName = "Marley";
        }

        private void HideContacts()
        {
            isContactVisible = !isContactVisible;

            if (isContactVisible)
                contactList.ShowContacts();
            else
                contactList.HideContacts();
        }

        private void NavigateTo()
        {
            navigationManager.NavigateTo("./testnavigation");
        }
    }
}
