#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaStreamSourceStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Core.MediaStreamSourceStartingRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaStreamSourceStartingRequest MediaStreamSourceStartingEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.MediaStreamSourceStartingEventArgs.Request.get
	}
}
