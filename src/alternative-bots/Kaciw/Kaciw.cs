using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class Kaciw : Bot
{
    Random random = new Random();

    static void Main(string[] args)
    {
        new Kaciw().Start();
    }

    Kaciw() : base(BotInfo.FromFile("Kaciw.json")) { }

    public override void Run()
    {
        BodyColor = Color.Blue;
        TurretColor = Color.White;
        RadarColor = Color.Cyan;

        while (IsRunning)
        {
            // Gerakan random
            Forward(100);

            TurnRight(random.Next(30, 90));

            // Scan musuh
            TurnGunRight(360);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        // Tembak musuh
        Fire(1);
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        // Dodge saat kena peluru
        TurnRight(random.Next(90, 180));

        Forward(120);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        // Hindari tembok
        Back(80);

        TurnRight(random.Next(45, 135));
    }
}