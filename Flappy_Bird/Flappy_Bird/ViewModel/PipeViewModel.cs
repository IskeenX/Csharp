using Flappy_Bird.Model;
using System;

namespace Flappy_Bird.ViewModel
{
	public class PipeViewModel : ViewModelBase
	{
		private TopPipe topPipe;
		private BottomPipe bottomPipe;

		public double TopPipePositionX => topPipe.PositionX;
		public double TopPipeGapPositionY => topPipe.GapPositionY;
		public double BottomPipePositionX => bottomPipe.PositionX;
		public double BottomPipeGapPositionY => bottomPipe.GapPositionY;


		public PipeViewModel(TopPipe topPipe, BottomPipe bottomPipe)
		{
			this.topPipe = topPipe;
			this.bottomPipe = bottomPipe;
		}

		public void Update()
		{
			topPipe.Move();
			bottomPipe.Move();

			if (topPipe.IsOutOfScreen(Constants.ScreenWidth))
			{
				// what code should I implements for this case?
			}

			OnPropertyChanged(nameof(TopPipePositionX));
			OnPropertyChanged(nameof(TopPipeGapPositionY));
			OnPropertyChanged(nameof(BottomPipePositionX));
			OnPropertyChanged(nameof(BottomPipeGapPositionY));
		}
	}
}
