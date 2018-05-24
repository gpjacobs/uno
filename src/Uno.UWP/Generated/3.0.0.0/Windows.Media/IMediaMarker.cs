#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IMediaMarker 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string MediaMarkerType
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Text
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::System.TimeSpan Time
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.IMediaMarker.Time.get
		// Forced skipping of method Windows.Media.IMediaMarker.MediaMarkerType.get
		// Forced skipping of method Windows.Media.IMediaMarker.Text.get
	}
}
