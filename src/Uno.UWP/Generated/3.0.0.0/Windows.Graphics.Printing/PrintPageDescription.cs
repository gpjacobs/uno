#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct PrintPageDescription 
	{
		// Forced skipping of method Windows.Graphics.Printing.PrintPageDescription.PrintPageDescription()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Foundation.Size PageSize;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Foundation.Rect ImageableRect;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint DpiX;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint DpiY;
		#endif
	}
}
