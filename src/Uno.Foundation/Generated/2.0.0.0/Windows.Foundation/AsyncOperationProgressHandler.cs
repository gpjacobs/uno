#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation
{
	#if false || false || false || false
	public delegate void AsyncOperationProgressHandler<TResult, TProgress>(global::Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> @asyncInfo, TProgress @progressInfo);
	#endif
}
