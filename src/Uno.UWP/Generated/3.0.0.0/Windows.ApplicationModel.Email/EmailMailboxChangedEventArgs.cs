#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Email.EmailMailboxChangedDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member EmailMailboxChangedDeferral EmailMailboxChangedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
