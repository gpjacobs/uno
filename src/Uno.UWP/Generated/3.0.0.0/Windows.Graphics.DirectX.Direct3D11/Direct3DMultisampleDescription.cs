#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.DirectX.Direct3D11
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct Direct3DMultisampleDescription 
	{
		// Forced skipping of method Windows.Graphics.DirectX.Direct3D11.Direct3DMultisampleDescription.Direct3DMultisampleDescription()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Count;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Quality;
		#endif
	}
}
