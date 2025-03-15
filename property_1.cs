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
		get
		{
			return v;
		}
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj=new abc();
		obj.pr_nm=50;
		Console.WriteLine("value of v="+obj.pr_nm);
	}
}