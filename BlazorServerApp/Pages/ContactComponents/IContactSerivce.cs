using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.ContactComponents
{
    public interface IContactSerivce //Contact service interface
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}
