#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IMediaMarkers 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.IMediaMarker> Markers
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.IMediaMarkers.Markers.get
	}
}
