using Flappy_Bird.Model;
using System;

namespace Flappy_Bird.ViewModel
{
	public class BirdViewModel : ViewModelBase
	{
		private Bird birdModel;

		public double PositionX => birdModel.PositionX;
		public double PositionY => birdModel.PositionY;

		public BirdViewModel()
		{
			birdModel = new Bird();
		}

		public void Flap()
		{
			birdModel.Flap(10); // Adjust flap strength as needed
		}

		public void Update()
		{
			birdModel.Update();
			if (birdModel.IsOutOfBounds(Constants.ScreenHeight))
			{
				// what logic should I add here?
			}

			OnPropertyChanged(nameof(PositionX));
			OnPropertyChanged(nameof(PositionY));
		}
	}
}
