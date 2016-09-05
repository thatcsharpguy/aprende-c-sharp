using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Async.Movil
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			Padding = new Thickness(20,40);

			normalButton.Clicked += (svm, a) =>
			{
				PerformTask();
			};

			asyncButton.Clicked += async (sender, e) =>
			{
				await PerformTaskAsync();
			};

			int i = 0;
			countButton.Clicked += (sender, e) =>
			{
				countLabel.Text = (i++).ToString();
			};
		}

		public void PerformTask()
		{
			descLabel.Text = "Normal presionado";
			progressBar.Progress = 0;
			for (int i = 1; i <= 10; i++)
			{
				Task.Delay(TimeSpan.FromSeconds(1)).Wait();
				progressBar.Progress = (double)i / (double)10;
				secondsLabel.Text = i + " seg";
			}
		}


		public async Task PerformTaskAsync()
		{
			descLabel.Text = "Async presionado";
			progressBar.Progress = 0;
			for (int i = 1; i <= 10; i++)
			{
				await Task.Delay(TimeSpan.FromSeconds(1));
				progressBar.Progress = (double)i / (double)10;
				secondsLabel.Text = i + " seg";
			}
		}
	}
}

