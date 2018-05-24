#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Preview.Injection
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct InjectedInputPointerInfo 
	{
		// Forced skipping of method Windows.UI.Input.Preview.Injection.InjectedInputPointerInfo.InjectedInputPointerInfo()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint PointerId;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.UI.Input.Preview.Injection.InjectedInputPointerOptions PointerOptions;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.UI.Input.Preview.Injection.InjectedInputPoint PixelLocation;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint TimeOffsetInMilliseconds;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong PerformanceCount;
		#endif
	}
}
