using System;

namespace CourseApp
{
    public class Pistol : Weapon
    {
        private double kalibr;

        public Pistol()
        : this("No model", 0, true)
        {
        }

        public Pistol(string model, double kalibr, bool fire)
        : base(model, kalibr, fire)
        {
            Model = model;
            Kalibr = kalibr;
            Fire = fire;
        }

        public override double Kalibr
        {
            get
            {
                return this.kalibr;
            }

            set
            {
                if (value >= 0 && value < 20)
                {
                    this.kalibr = value;
                }
                else
                {
                    throw new Exception("Enter correct kalibr");
                }
            }
        }

        public override bool CanShoot
        {
            get { return this.Fire; }
        }

        public override string Shoot(bool canShoot)
        {
            if (canShoot == true)
            {
                return $"Pistol {Model} and {Kalibr} made the shot!";
            }
            else
            {
                return $"Pistol {Model} and {Kalibr} not made the shot!";
            }
        }
    }
}