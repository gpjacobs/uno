#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum EmailQuerySearchFields 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Subject,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Sender,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Preview,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Recipients,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		All,
		#endif
	}
	#endif
}
