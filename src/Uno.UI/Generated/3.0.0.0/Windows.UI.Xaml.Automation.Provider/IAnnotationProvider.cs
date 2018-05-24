#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAnnotationProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		int AnnotationTypeId
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string AnnotationTypeName
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Author
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string DateTime
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple Target
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IAnnotationProvider.AnnotationTypeId.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IAnnotationProvider.AnnotationTypeName.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IAnnotationProvider.Author.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IAnnotationProvider.DateTime.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IAnnotationProvider.Target.get
	}
}
