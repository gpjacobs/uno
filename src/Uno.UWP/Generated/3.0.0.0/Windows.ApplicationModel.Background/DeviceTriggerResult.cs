#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum DeviceTriggerResult 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Allowed,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DeniedByUser,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DeniedBySystem,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		LowBattery,
		#endif
	}
	#endif
}
