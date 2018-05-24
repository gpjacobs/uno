#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITransformProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanMove
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanResize
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanRotate
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.ITransformProvider.CanMove.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.ITransformProvider.CanResize.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.ITransformProvider.CanRotate.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Move( double x,  double y);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Resize( double width,  double height);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Rotate( double degrees);
		#endif
	}
}
