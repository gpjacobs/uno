#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDragProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string DropEffect
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string[] DropEffects
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool IsGrabbed
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IDragProvider.IsGrabbed.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IDragProvider.DropEffect.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IDragProvider.DropEffects.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple[] GetGrabbedItems();
		#endif
	}
}
