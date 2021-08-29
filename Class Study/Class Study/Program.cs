/*
 * 由SharpDevelop创建。
 * 用户： liyan
 * 日期: 2021/10/4
 * 时间: 18:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Class_Study
{
	class Box
	{
		public double length;
		public double breadth;
		public double height;
		public short sA;
		
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			
			Box Box1=new Box();
			Box Box2=new Box();
			double volume=0.0;
			
			//Box1
			Box1.height=5.0;
			Box1.length=6.0;
			Box1.breadth=7.0;
			
			//Box2
			Box2.height=10.0;
			Box2.length=12.0;
			Box2.breadth=13.0;
			
			//Box1的体积
			volume=Box1.height*Box1.length*Box1.breadth;
			Box1.sA=-1000;
			string str=Convert.ToString(Box1.sA,2);
			Console.WriteLine(str);
			Console.WriteLine("Box1的体积：{0}",volume);
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}