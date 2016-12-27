using System;
using System.Collections.Generic;

namespace Indizadores
{
	public class Indexer
	{
		public int get_this(string position)
		{
			return 0;
		}

		public int this[string position]
		{
			get
			{
				Console.WriteLine("Accediendo a {0}", position);
				return 0; // Importante regresar un dato
			}
			set
			{
				// value contiene el dato que se va a establecer
				Console.WriteLine("Estableciendo {0} en la posición {1}", value, position);
			}
		}

		public int Value { get; set; }


		public string this[Indexer indexer]
		{
			get { return indexer.ToString(); }
		}


		public Indexer this[double position]
		{
			set { Console.WriteLine("\"Insertando\" {1} en {0}", position, value); }
		}

		public string this[int i, bool b, double d]
		{
			get { return String.Format("I'm an indexer: {0} {1} {2}", i, b, d); }
		}

		Dictionary<int, Indexer> _indexers = new Dictionary<int, Indexer>();

		public Indexer this[int id]
		{
			get
			{
				if (_indexers.ContainsKey(id))
				{
					return _indexers[id];
				}
				return null;
			}

			set
			{
				if (!_indexers.ContainsKey(id))
				{
					_indexers.Add(id, value);
				}
			}
		}

	}
}
