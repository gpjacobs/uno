#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input.ForceFeedback
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IForceFeedbackEffect 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double Gain
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Gaming.Input.ForceFeedback.ForceFeedbackEffectState State
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Gaming.Input.ForceFeedback.IForceFeedbackEffect.Gain.get
		// Forced skipping of method Windows.Gaming.Input.ForceFeedback.IForceFeedbackEffect.Gain.set
		// Forced skipping of method Windows.Gaming.Input.ForceFeedback.IForceFeedbackEffect.State.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Start();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Stop();
		#endif
	}
}
