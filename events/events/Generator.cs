using System;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{


	public class Generator 
	{

		Random r;

		public bool IsRunning { get; private set; }

		public string Name { get; set; }

		public Generator(string name)
		{
			Name = name;
			r = new Random(name.GetHashCode());
		}


		public delegate void GeneratingNumberEventHandler(Generator sender);

		public event GeneratingNumberEventHandler GeneratingNumber; 

		public event EventHandler GeneratingNumber1;

		public event EventHandler<int> EvenNumberGenerated;

		public Action<int> EvenNumberGeneratedAction;

		public void Start()
		{
			var t = new Thread(() =>
			{
			IsRunning = true;
			while (IsRunning)
			{
				Thread.Sleep(500);

					if (GeneratingNumber != null)
					{
						GeneratingNumber(this);
					}

					if (GeneratingNumber1 != null)
					{
						GeneratingNumber1(this, EventArgs.Empty);
					}

					var generated = r.Next();

					if (generated % 2 == 0)
					{
						if (EvenNumberGenerated != null)
						{
							EvenNumberGenerated(this, generated);
						}

						//if (EvenNumberGeneratedAction != null)
						//{
						//	EvenNumberGeneratedAction(generated);
						//}
					}
					//Console.WriteLine(generated);
				}
			});

			t.Start();
		}


		public void Stop()
		{
			IsRunning = false;
		}
	}
}


