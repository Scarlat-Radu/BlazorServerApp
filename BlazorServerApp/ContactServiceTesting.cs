using BlazorServerApp.Models;

namespace BlazorServerApp
{
	public class ContactServiceTesting : IContactSerivce //reimplemtent for a new class
	{
		public List<Contact> Contacts = new List<Contact>();
		public void AddContact(Contact contact)
		{
			Contacts.Add(contact);
		}

		public List<Contact> GetContacts()
		{
			return new List<Contact>
			{
				new Contact
				{
					Name = "Marley", 
					Email= "None",
				}
			};
		}
	}
}
