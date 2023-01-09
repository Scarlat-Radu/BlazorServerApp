using BlazorServerApp.Models;

namespace BlazorServerApp
{
	public interface IContactSerivce //Contact service interface
	{
		List<Contact> GetContacts();
		void AddContact(Contact contact);
	}
}
