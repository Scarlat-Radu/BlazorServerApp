using BlazorServerApp.Models;

namespace BlazorServerApp
{
    public class ContactService : IContactSerivce
    {
        public List<Contact> contactList =new List<Contact>();

        public List<Contact> GetContacts() { return contactList; }
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }
    }
}
