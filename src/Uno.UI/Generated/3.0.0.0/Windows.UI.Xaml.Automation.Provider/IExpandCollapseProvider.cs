#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IExpandCollapseProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Collapse();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Expand();
		#endif
	}
}
