#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionParticipantAddedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionParticipant Participant
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionParticipant RemoteSystemSessionParticipantAddedEventArgs.Participant is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionParticipantAddedEventArgs.Participant.get
	}
}
