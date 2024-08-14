using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

public class Nahida
{
    public int x { get; set; }
    public int y { get; set; }

    public Nahida()
	{
        x= 0;
        y= 0;
	}

    public double GetDistancia(Nahida pa, Nahida pb) 
    {
        double distancia = Math.Sqrt(Math.Pow(pb.x - pa.x, 2)+Math.Pow(pb.y - pa.y,2));
        return distancia;
    }
}
