using Dane;
using System;

namespace Logika;

public class BallLogic
{
    private const int BallDiameter = 76;
    private const int CanvasWidth = 828;
    private const int CanvasHeight = 457;
    private const int OffsetX = 0;
    private const int OffsetY = 0;
    private Random random = new Random();
    public Ball Move(Ball ball)
    {
        ball.X += ball.VelocityX;
        ball.Y += ball.VelocityY;

        if (ball.X <= 0 +OffsetX || ball.X >= CanvasWidth - BallDiameter + OffsetX)
        {
            ball.VelocityX = -ball.VelocityX;
        }
        if (ball.Y <= 0 + OffsetY || ball.Y >= CanvasHeight - BallDiameter + OffsetY)
        {
            ball.VelocityY = -ball.VelocityY;
        }

        return ball;
    }
    public Ball CreateBall()
    {
       Ball ball= new Ball
        {
            X = random.Next(0, 828 - 76),
            Y = random.Next(0, 457 - 76),
            VelocityX = 5 * (random.Next(2) == 0 ? 1 : -1),
            VelocityY = 5 * (random.Next(2) == 0 ? 1 : -1)
        };
        return ball;
    }
    public void CheckAndHandleCollision(Ball ball,IList<Ball> balls)
    {
        var rect1 = ball.CollisionRect;
        for(int i = 0;i < balls.Count; i++)
        {
            var b = balls[i];
            if(b==ball) continue;
            var rect2= b.CollisionRect;
            if (rect1.IntersectsWith(rect2))
            {
                ResolveCollision(ball, b);
            }
        }

    }
    private void ResolveCollision(Ball ball1, Ball ball2)
    {
        // Różnica w położeniu na osi X i Y
        double deltaX = ball2.X - ball1.X;
        double deltaY = ball2.Y - ball1.Y;

        // Ustal kierunek kolizji
        bool collisionOnXAxis = Math.Abs(deltaX) > Math.Abs(deltaY);

        // Oblicz overlap (przecięcie)
        double overlap;

        if (collisionOnXAxis)
        {
            // Kolizja bardziej w osi X
            overlap = BallDiameter - Math.Abs(deltaX);

            // Przesuń kule poza siebie
            if (deltaX > 0)
            {
                ball1.X = Math.Max(OffsetX, ball1.X - overlap / 2);
                ball2.X = Math.Min(CanvasWidth - BallDiameter, ball2.X + overlap / 2);
            }
            else
            {
                ball1.X = Math.Min(CanvasWidth - BallDiameter, ball1.X + overlap / 2);
                ball2.X = Math.Max(OffsetX, ball2.X - overlap / 2);
            }

            // Odwróć prędkości w osi X
            ball1.VelocityX = -ball1.VelocityX;
            ball2.VelocityX = -ball2.VelocityX;
        }
        else
        {
            // Kolizja bardziej w osi Y
            overlap = BallDiameter - Math.Abs(deltaY);

            // Przesuń kule poza siebie
            if (deltaY > 0)
            {
                ball1.Y = Math.Max(OffsetY, ball1.Y - overlap / 2);
                ball2.Y = Math.Min(CanvasHeight - BallDiameter, ball2.Y + overlap / 2);
            }
            else
            {
                ball1.Y = Math.Min(CanvasHeight - BallDiameter, ball1.Y + overlap / 2);
                ball2.Y = Math.Max(OffsetY, ball2.Y - overlap / 2);
            }

            // Odwróć prędkości w osi Y
            ball1.VelocityY = -ball1.VelocityY;
            ball2.VelocityY = -ball2.VelocityY;
        }
    }





}

