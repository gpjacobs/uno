#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBitmapPropertiesView 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Foundation.IAsyncOperation<global::Windows.Graphics.Imaging.BitmapPropertySet> GetPropertiesAsync( global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve);
		#endif
	}
}
