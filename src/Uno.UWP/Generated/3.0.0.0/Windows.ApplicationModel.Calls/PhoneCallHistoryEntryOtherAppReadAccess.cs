#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum PhoneCallHistoryEntryOtherAppReadAccess 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Full,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SystemOnly,
		#endif
	}
	#endif
}
