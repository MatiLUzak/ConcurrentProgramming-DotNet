using System;
using System.Collections.Generic;
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

        private Ball ball;
        private BallLogic ballLogic = new BallLogic();
        private DispatcherTimer timer = new DispatcherTimer();

        public BallViewModel()
        {
            ball = new Ball { X = 50, Y = 50, VelocityX = 10, VelocityY = 10 };
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += (s, e) => MoveBall();
            timer.Start();
        }
        public double X
        {
            get { return ball.X; }
            set
            {
                if (ball.X != value)
                {
                    ball.X = value;
                    OnPropertyChanged(nameof(X));
                }
            }
        }
        public double Y
        {
            get { return ball.Y; }
            set
            {
                if (ball.Y != value)
                {
                    ball.Y = value;
                    OnPropertyChanged(nameof(Y));
                }
            }
        }
        private void MoveBall()
        {
            ball=ballLogic.Move(ball);
            OnPropertyChanged(nameof(X));
            OnPropertyChanged(nameof(Y));

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
