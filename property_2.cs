using System;
class abc 
{
	private int v;
	public int pr_nm
	{
		set
		{
			v=value;
		}
	}
	public void fun()
	{
		Console.WriteLine("value of a="+v);
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj=new abc();
		obj.pr_nm=50;
		obj.fun();
	}
}