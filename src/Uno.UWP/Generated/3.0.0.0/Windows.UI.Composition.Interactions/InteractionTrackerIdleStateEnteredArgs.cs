#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerIdleStateEnteredArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  int RequestId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int InteractionTrackerIdleStateEnteredArgs.RequestId is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionTrackerIdleStateEnteredArgs.RequestId.get
	}
}
