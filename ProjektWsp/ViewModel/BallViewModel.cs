using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Dane;
using Logika;

namespace Project.ViewModel
{
    public class BallViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Ball> Balls { get; set; } = new ObservableCollection<Ball>();
        private BallLogic ballLogic = new BallLogic();
        private DispatcherTimer timer = new DispatcherTimer();
        private Random random = new Random();

        public BallViewModel()
        {
            InitializeBalls(5);
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += (s, e) => MoveBalls();
            timer.Start();
        }

        private void InitializeBalls(int numberOfBalls)
        {
            for (int i = 0; i < numberOfBalls; i++)
            {
                Balls.Add(new Ball
                {
                    X = random.Next(0, 828 - 76), 
                    Y = random.Next(0, 457 - 76),
                    VelocityX = 5 * (random.Next(2) == 0 ? 1 : -1),
                    VelocityY = 5 * (random.Next(2) == 0 ? 1 : -1)
                });
            }
        }

        private void MoveBalls()
        {
            foreach (var ball in Balls)
            {
                ballLogic.Move(ball);
            }
            OnPropertyChanged(nameof(Balls));// to chyba nie jest potrzebne 
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
