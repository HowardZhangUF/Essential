using System;

public class Program
{
	delegate bool IsTeenAger(Student stud);//可以替以她為型別的變數(IsTeenAger)指派一個方法(Student)or類別
	//此處delegate有點像函式宣告

	public static void Main()
	{
		IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };
		//此處delegate有點像函式定義。定義了接收外部傳輸進來的的類別變數為s。
		//
		Student stud = new Student() { Age = 25 };//類別實體化同時指派變數值

		Console.WriteLine(isTeenAger(stud));//呼叫delegate方法同時傳入參數
		Console.ReadKey();


	}
}

public class Student
{

	public int Id { get; set; }
	public string Name { get; set; }
    public int Age { get ; set ; }

    
}