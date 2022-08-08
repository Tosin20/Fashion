using System;
namespace Fashion
{
	public abstract class FashionBrand    //abstraction
	{
		public abstract string CalcSize(double bust, double waist);      
		public abstract string Price(float distance);
	}

	public class Boutique: FashionBrand   //inheritance
	{
		private string sizes;    //encapsulation
		public string Size
		{
			get
			{ return sizes; }
		}

		

		public override string CalcSize(double bust, double waist)      //use of override 
		{
			if (bust < 36.0 && waist < 30.00)          //size calculator
			{
				sizes = " Small";

			}

			if ((bust > 36.0 || bust < 40.00) && (waist > 30.00 || waist < 40.00))
			{
				sizes= "Medium";
			}

			if ((bust > 40.00 || bust < 46.00) && (waist > 40.00 || waist < 46.00))
					{
				sizes= "Large";
			}
			
			else
			{
				sizes = "We do not have your size.";

			}
                return sizes;
		}

        public override string Price(float distance)  //polymorphism
        {
			int costPrice = 95000;                        // In Nigeria price
            float newPrice = costPrice* distance;
			return " The price is: " + newPrice;
        }

		public string Price()
        {

			int costPrice = 95000;                          // outside Nigeria price
			int currency = 450;
			float newPrice = costPrice * currency;
			return " The price is: " + newPrice;
		}
    }
}