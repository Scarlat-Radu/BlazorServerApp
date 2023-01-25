using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.ContactComponents
{
    public class ContactService : IContactSerivce //added inteface for contacts
    {
        public List<Contact> contactList = new List<Contact>();

        public List<Contact> GetContacts() { return contactList; }
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }
    }
}
