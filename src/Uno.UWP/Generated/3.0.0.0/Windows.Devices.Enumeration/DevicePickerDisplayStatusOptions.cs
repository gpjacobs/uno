#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum DevicePickerDisplayStatusOptions 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ShowProgress,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ShowDisconnectButton,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ShowRetryButton,
		#endif
	}
	#endif
}
