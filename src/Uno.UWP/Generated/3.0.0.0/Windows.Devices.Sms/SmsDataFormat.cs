#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sms
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum SmsDataFormat 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Unknown,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		CdmaSubmit,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		GsmSubmit,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		CdmaDeliver,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		GsmDeliver,
		#endif
	}
	#endif
}
