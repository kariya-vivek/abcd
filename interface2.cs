using System;
interface inter1
{
	void xyz();
}
interface inter2 :inter1
{
	void xyz1();
}

class abc :inter2
{
	public void xyz()
	{
		Console.WriteLine("hello xyz");
	}
	public void xyz1()
	{
		Console.WriteLine("hello xyz1");
	}
}
class demo:abc 
{
	public void fun()
	{
		Console.WriteLine("hello fun");
	}
}
class main_cls
{
	public static void Main()
	{
		demo obj = new demo();
		obj.fun();
		obj.xyz();
		obj.xyz1();
	}
}