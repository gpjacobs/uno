#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts.DataProvider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactDataProviderTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactDataProviderConnection ContactDataProviderTriggerDetails.Connection is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails.Connection.get
	}
}
