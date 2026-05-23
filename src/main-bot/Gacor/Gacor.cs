using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class Gacor : Bot
{
    static void Main(string[] args)
    {
        new Gacor().Start();
    }

    Gacor() : base(BotInfo.FromFile("Gacor.json")) { }

    public override void Run()
    {
        BodyColor = Color.Black;
        TurretColor = Color.Green;
        RadarColor = Color.Lime;

        while (IsRunning)
        {
            TurnGunRight(360);

            Forward(50);

            TurnRight(20);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        if (DistanceTo(e.X, e.Y) < 150)
        {
            Fire(3);
        }
        else if (DistanceTo(e.X, e.Y) < 300)
        {
            Fire(2);
        }
        else
        {
            Fire(1);
        }
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(50);

        TurnRight(90);
    }

    double DistanceTo(double x, double y)
    {
        double dx = X - x;
        double dy = Y - y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}