#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct CoreProximityEvaluation 
	{
		// Forced skipping of method Windows.UI.Core.CoreProximityEvaluation.CoreProximityEvaluation()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Score;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Foundation.Point AdjustedPoint;
		#endif
	}
}
