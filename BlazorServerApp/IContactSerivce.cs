using BlazorServerApp.Models;

namespace BlazorServerApp
{
	public interface IContactSerivce
	{
		List<Contact> GetContacts();
		void AddContact(Contact contact);
	}
}
