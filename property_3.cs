using System;
class abc 
{
	private int v;
	public int pr_nm
	{
		get
		{
			return v;
		}
	}
	public void fun(int x)
	{
		v=x;
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj=new abc();
		int y=Convert.ToInt32(Console.ReadLine());
		obj.fun(y);
		Console.WriteLine("value of v="+obj.pr_nm);
	}
}