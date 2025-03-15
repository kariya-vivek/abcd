using System;
class abc
{
	public void fun(double a,out double b,out double ta,out double da,out double hra,out double pf)
	{
		if(a>=35000 && a<=45000)
		{
			ta=(a*5)/100;
			da=(a*5)/100;
			hra=(a*15)/100;
			pf=(a*8.5)/100;
			b=a+ta+da+hra-pf;
		}
		else if(a<35000)
		{
			ta=(a*9)/100;
			da=(a*12)/100;
			hra=(a*20)/100;
			pf=(a*8.5)/100;
			b=a+ta+da+hra-pf;
		}
		else
		{
			b=0;
			ta=0;
			da=0;
			hra=0;
			pf=0;
		}
	}
}
class main_cls
{
	public static void Main()
	{
		double gross_s,pf,ta,da,hra;
		double basic_s=Convert.ToDouble(Console.ReadLine());
		abc obj=new abc();
		obj.fun(basic_s,out gross_s,out pf,out ta,out da,out hra);
		Console.WriteLine("your Ta="+ta);
		Console.WriteLine("your Da="+da);
		Console.WriteLine("your HRA="+hra);
		Console.WriteLine("your PF="+pf);
		Console.WriteLine("your gross_s salary="+gross_s);
	}
}