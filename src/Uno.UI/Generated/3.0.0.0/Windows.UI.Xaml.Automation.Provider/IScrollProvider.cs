#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IScrollProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double HorizontalScrollPercent
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double HorizontalViewSize
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool HorizontallyScrollable
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double VerticalScrollPercent
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double VerticalViewSize
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool VerticallyScrollable
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontallyScrollable.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontalScrollPercent.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontalViewSize.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticallyScrollable.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticalScrollPercent.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticalViewSize.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Scroll( global::Windows.UI.Xaml.Automation.ScrollAmount horizontalAmount,  global::Windows.UI.Xaml.Automation.ScrollAmount verticalAmount);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetScrollPercent( double horizontalPercent,  double verticalPercent);
		#endif
	}
}
