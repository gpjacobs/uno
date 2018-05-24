#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDataTemplateComponent 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Recycle();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void ProcessBindings( object item,  int itemIndex,  int phase, out int nextPhase);
		#endif
	}
}
