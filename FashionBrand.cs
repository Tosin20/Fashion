using System;
namespace Fashion
{
	public abstract class FashionBrand    //abstraction
	{
		public abstract string Formal();
		public abstract string Casual();
	}

	public class Boutique: FashionBrand
    {
		private string sizes;
		public string Size
        {
			get
			{ return sizes; }
        }

		public double CalcSize(double bust, double waist)
        {
			if (bust < 36.0 && waist < 30.00)
			{
				return Small;
			
			}

			if (bust > 36.0 <40.00) && (waist >30.00 < 40.00)
			{ 
				return Medium;
		    }

			if (bust > 40.00 < 46.00) && (waist > 40.00 < 46.00)
					{
				return Large;
			         }
			else
			{
				Console.WriteLine("We do not have your size.")

			}
        }
    }
}