using System;
namespace XUnitFramework.Repository
{
	public class CalculatorRepository: ICalculatorRepository
	{
		public CalculatorRepository()
		{
		}

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}

