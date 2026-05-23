using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class Syududu : Bot
{
    double enemyDistance = 9999;

    static void Main(string[] args)
    {
        new Syududu().Start();
    }

    Syududu() : base(BotInfo.FromFile("Syududu.json")) { }

    public override void Run()
    {
        BodyColor = Color.Purple;
        TurretColor = Color.Orange;
        RadarColor = Color.White;

        while (IsRunning)
        {
            TurnGunRight(360);

            if (Energy > 50)
            {
                Forward(120);
            }
            else
            {
                Back(80);
                TurnRight(60);
            }
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        enemyDistance = DistanceTo(e.X, e.Y);

        if (enemyDistance < 150)
        {
            Fire(3);
        }
        else if (enemyDistance < 300)
        {
            Fire(2);
        }
        else
        {
            Fire(1);
        }

        if (Energy < 30)
        {
            Back(100);
        }
        else
        {
            Forward(50);
        }
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        TurnRight(120);

        Forward(100);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(80);

        TurnRight(90);
    }

    double DistanceTo(double x, double y)
    {
        double dx = X - x;
        double dy = Y - y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}