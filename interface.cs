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
	public void fun()
	{
		Console.WriteLine("hello fun");
	}
	public void xyz()
	{
		Console.WriteLine("hello xyz");
	}
	public void xyz1()
	{
		Console.WriteLine("hello xyz1");
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj = new abc();
		obj.fun();
		obj.xyz();
		obj.xyz1();
	}
}