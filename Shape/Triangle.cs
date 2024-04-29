namespace ExampleLibrary;

public class Triangle : Shape
{
    public double SideAb { get; }
    public double SideBc { get; }
    public double SideCa { get; }

    public Triangle(double sideAb, double sideBc, double sideCa)
    {
        if (sideAb <= 0 || sideBc <= 0 || sideCa <= 0)
            throw new ArgumentException("Sides must be positive numbers.");

        if (!IsValidTriangle(sideAb, sideBc, sideCa))
            throw new ArgumentException("Sides do not form a valid triangle.");

        this.SideAb = sideAb;
        this.SideBc = sideBc;
        this.SideCa = sideCa;
    }

    public override double CalculateArea()
    {
        double semiPerimeter = (SideAb + SideBc + SideCa) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideAb)
                                       * (semiPerimeter - SideBc)
                                       * (semiPerimeter - SideCa));
    }
    
    public bool IsRightAngled()
    {
        double cosA = (Math.Pow(SideAb, 2) + Math.Pow(SideCa, 2) - Math.Pow(SideBc, 2)) 
                      / (2 * SideAb * SideCa);
        double cosB = (Math.Pow(SideAb, 2) + Math.Pow(SideBc, 2) - Math.Pow(SideCa, 2)) 
                      / (2 * SideAb * SideBc);
        double cosC = (Math.Pow(SideBc, 2) + Math.Pow(SideCa, 2) - Math.Pow(SideAb, 2)) 
                      / (2 * SideBc * SideCa);

        return Math.Abs(cosA) < 0.001 || Math.Abs(cosB) < 0.001 || Math.Abs(cosC) < 0.001;
    }

    private bool IsValidTriangle(double sideAb, double sideBc, double sideCa)
    {
        return sideAb + sideBc >  sideCa 
               && sideAb + sideCa > sideBc 
               && sideBc + sideCa > sideAb;
    }

}