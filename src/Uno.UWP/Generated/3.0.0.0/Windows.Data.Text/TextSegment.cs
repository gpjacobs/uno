#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct TextSegment 
	{
		// Forced skipping of method Windows.Data.Text.TextSegment.TextSegment()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint StartPosition;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint Length;
		#endif
	}
}
