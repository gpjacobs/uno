#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IItemContainerMapping 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		object ItemFromContainer( global::Windows.UI.Xaml.DependencyObject container);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.DependencyObject ContainerFromItem( object item);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		int IndexFromContainer( global::Windows.UI.Xaml.DependencyObject container);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.DependencyObject ContainerFromIndex( int index);
		#endif
	}
}
