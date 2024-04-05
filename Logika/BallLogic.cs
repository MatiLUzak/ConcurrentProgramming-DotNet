using Dane;

namespace Logika;

public class BallLogic
{
    private const int BallDiameter = 76;
    private const int CanvasWidth = 828;
    private const int CanvasHeight = 457;
    private const int OffsetX = 20;
    private const int OffsetY = 10;

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
}

