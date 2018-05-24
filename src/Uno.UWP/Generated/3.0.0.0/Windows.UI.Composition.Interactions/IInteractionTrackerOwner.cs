#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInteractionTrackerOwner 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void CustomAnimationStateEntered( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerCustomAnimationStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void IdleStateEntered( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerIdleStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void InertiaStateEntered( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void InteractingStateEntered( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerInteractingStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void RequestIgnored( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerRequestIgnoredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void ValuesChanged( global::Windows.UI.Composition.Interactions.InteractionTracker sender,  global::Windows.UI.Composition.Interactions.InteractionTrackerValuesChangedArgs args);
		#endif
	}
}
