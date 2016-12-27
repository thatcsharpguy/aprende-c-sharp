using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Indizadores
{
	public class Bundle : IEnumerable<Toy>
	{
		public int Size { get; private set; }
		public int ToyCount { get { return _storage.Count; } }

		private List<Toy> _storage;

		public Bundle(int size)
		{
			Size = size;
			_storage = new List<Toy>(Size);
		}

		public bool TryAddToy(Toy t)
		{
			if (ToyCount >= Size) return false;
			_storage.Add(t);
			return true;
		}

		public static Bundle operator +(Bundle bundle, Toy t)
		{
			var newBundle = new Bundle(bundle.Size + 1);
			foreach (var toy in bundle)
			{
				newBundle.TryAddToy(toy);
			}
			newBundle.TryAddToy(t);
			return newBundle;
		}

		public static Bundle operator +(Toy t, Bundle bundle)
		{
			if (!bundle.TryAddToy(t))
				throw new InvalidOperationException("Bundle is already full!");
			return bundle;
		}

		public static Bundle operator +(Bundle a, Bundle b)
		{
			Bundle bundle = new Bundle(a.Size + b.Size);
			foreach (var toy in a)
			{
				bundle.TryAddToy(toy);
			}
			foreach (var toy in b)
			{
				bundle.TryAddToy(toy);
			}
			return bundle;
		}

		public Toy this[int i]
		{ 
			get 
			{
				if (0 < i && i < _storage.Count)
				{
					return _storage[i];
				}
				return null;
			}
		}

		public override string ToString()
		{
			return "Bundle (" + Size + "/" + ToyCount + ") [" + String.Join(", ", _storage.Select(t => t.Name)) + "]";
		}

		public IEnumerator<Toy> GetEnumerator()
		{
			return _storage.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _storage.GetEnumerator();
		}
	}
}
