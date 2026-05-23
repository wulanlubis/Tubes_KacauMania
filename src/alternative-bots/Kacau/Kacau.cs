using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class Kacau : Bot
{
    static void Main(string[] args)
    {
        new Kacau().Start();
    }

    Kacau() : base(BotInfo.FromFile("Kacau.json")) { }

    public override void Run()
    {
        BodyColor = Color.Red;
        TurretColor = Color.Black;
        RadarColor = Color.Yellow;

        while (IsRunning)
        {
            Forward(150);
            TurnRight(25);
            TurnGunRight(360);
            Fire(2);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        Fire(3);

        Forward(80);

        TurnGunRight(20);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(100);
        TurnRight(90);
    }

    public override void OnHitBot(HitBotEvent e)
    {
        Fire(3);
        Forward(50);
    }
}