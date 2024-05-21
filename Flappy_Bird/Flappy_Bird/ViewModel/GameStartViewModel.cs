using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Flappy_Bird.Model;
using static System.Formats.Asn1.AsnWriter;

namespace Flappy_Bird.ViewModel
{
    public class GameStartViewModel : ViewModelBase
    {
        private Bird bird;
        private PipeGenerator pipeGenerator;
        private int score;

        public Bird Bird
        {
            get => bird;
            set => Set(ref bird, value);
        }

        public ObservableCollection<TopPipe> TopPipes => new ObservableCollection<TopPipe>(pipeGenerator.TopPipes);
        public ObservableCollection<BottomPipe> BottomPipes => new ObservableCollection<BottomPipe>(pipeGenerator.BottomPipes);

        public int Score
        {
            get => score;
            set => Set(ref score, value);
        }
        public ICommand FlapCommand { get; }

        public GameStartViewModel()
        {
            bird = new Bird(Constants.ScreenHeight / 2); // Initial bird position in the middle
            pipeGenerator = new PipeGenerator();
            score = 0;

            FlapCommand = new RelayCommand(Flap);

            StartGame();
        }

        private void StartGame()
        {
            // Start generating pipes
            var pipeGenerationTimer = new DispatcherTimer();
            pipeGenerationTimer.Interval = TimeSpan.FromSeconds(1);
            pipeGenerationTimer.Tick += (sender, e) => pipeGenerator.GenerateRandomPipe(Constants.GapSize);
            pipeGenerationTimer.Start();

            // Start game loop
            var gameLoopTimer = new DispatcherTimer();
            gameLoopTimer.Interval = TimeSpan.FromMilliseconds(50); // 20 FPS
            gameLoopTimer.Tick += (sender, e) =>
            {
                Bird.Update();
                pipeGenerator.Update();

                foreach (var pipe in pipeGenerator.BottomPipes)
                {
                    if (pipe.PositionX + Constants.PipeWidth < Bird.PositionX)
                    {
                        score++;
                        // Update the score whenever the bird passes a pipe
                        RaisePropertyChanged(nameof(Score));
                    }
                }
            };
            gameLoopTimer.Start();
        }

        private void Flap()
        {
            Bird.Flap(5);
        }

        //private BirdViewModel birdViewModel;
        //private PipeGenerator pipeGenerator;

        //public BirdViewModel BirdViewModel => birdViewModel;
        //public ObservableCollection<PipeViewModel> Pipes { get; }

        //public GameStartViewModel()
        //{
        //	birdViewModel = new BirdViewModel();
        //	pipeGenerator = new PipeGenerator();

        //	Pipes = new ObservableCollection<PipeViewModel>();

        //	// Initialize game setup logic here (e.g., generating initial pipes)
        //	GeneratePipes();
        //}

        //public void UpdateGame()
        //{
        //	birdViewModel.Update();
        //	foreach (var pipeViewModel in Pipes)
        //	{
        //		pipeViewModel.Update();
        //	}

        //	// Check for collisions or other game logic here
        //}

        //private void GeneratePipes()
        //{
        //	pipeGenerator.GenerateRandomPipe(Constants.GapSize);
        //	foreach (var topPipe in pipeGenerator.TopPipes)
        //	{
        //		var bottomPipe = pipeGenerator.BottomPipes.FirstOrDefault(p => p.PositionX == topPipe.PositionX);
        //		if (bottomPipe != null)
        //		{
        //			var pipeViewModel = new PipeViewModel(topPipe, bottomPipe);
        //			Pipes.Add(pipeViewModel);
        //		}
        //	}
        //}

        //public void FlapBird()
        //{
        //	birdViewModel.Flap();
        //}

        //test commit
    }
}