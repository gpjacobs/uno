using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Windows.Foundation.Collections;

namespace Windows.UI.Xaml.Controls
{
	public partial class RowDefinitionCollection : IList<RowDefinition>, IEnumerable<RowDefinition>
	{
		private readonly DependencyObjectCollection<RowDefinition> _inner = new DependencyObjectCollection<RowDefinition>();

		internal event VectorChangedEventHandler<RowDefinition> CollectionChanged;

		public RowDefinitionCollection()
		{
			_inner.VectorChanged += (s, e) => CollectionChanged?.Invoke(s, e);
		}

		internal RowDefinitionCollection(DependencyObject owner) : this()
		{
			_inner.IsAutoPropertyInheritanceEnabled = false;
			_inner.SetParent(owner);
		}

		public int IndexOf(RowDefinition item) => _inner.IndexOf(item);

		public void Insert(int index, RowDefinition item) => _inner.Insert(index, item);

		public void RemoveAt(int index) => _inner.RemoveAt(index);

		public RowDefinition this[int index]
		{
			get
			{
				return _inner[index];
			}
			set
			{
				_inner[index] = value;
			}
		}

		public void Add(RowDefinition item) => _inner.Add(item);

		public void Clear() => _inner.Clear();

		public bool Contains(RowDefinition item) => _inner.Contains(item);

		public void CopyTo(RowDefinition[] array, int arrayIndex) => _inner.CopyTo(array, arrayIndex);

		public bool Remove(RowDefinition item) => _inner.Remove(item);

		public int Count => _inner.Count;

		public bool IsReadOnly => false;

		/// <summary>
		/// The inner list is exposed in order to get the struct enumerable exposed by List<T> to avoid allocations.
		/// </summary>
		internal List<RowDefinition> InnerList => _inner.Items;

		public global::System.Collections.Generic.IEnumerator<RowDefinition> GetEnumerator() => _inner.GetEnumerator();

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() => _inner.GetEnumerator();
	}
}
