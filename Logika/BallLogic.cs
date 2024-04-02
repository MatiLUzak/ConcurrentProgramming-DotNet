using Dane;

namespace Logika;

public class BallLogic
{
    public Ball Move(Ball ball)
    {
        ball.X += ball.VelocityX;
        ball.Y += ball.VelocityY;

        if(ball.X < 0 || ball.X > 748 - 76)
        {
            ball.VelocityX = -ball.VelocityX;
        }
        if(ball.Y<0 || ball.Y > 406 - 76)
        {
            ball.VelocityY = -ball.VelocityY;
        }
        return ball;
    }
}
