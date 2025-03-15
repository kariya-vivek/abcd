using System;
class abc
{
	private string[] a =new string[3];
	public string this[int index]
	{
		set
		{
			a[index]=value;
		}
		get
		{
			return a[index];
		}
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj = new abc();
		int i;
		string y;
		for(i=0;i<3;i++)
		{
			Console.Write("enter value of a[{0}]=",i);
			y=Console.ReadLine();
			obj[i]=y;
		}
		
		for(i=0;i<3;i++)
		{
			Console.Write("your enter value is a[{0}]=",i);
			Console.WriteLine(obj[i]);
		}
	}
}
