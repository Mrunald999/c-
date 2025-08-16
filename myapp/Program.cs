int A=20;
int B=11;
char Name='M';
Console.WriteLine("My name is mrunal");
Console.WriteLine("I am Manual Tester");
Console.WriteLine("I need to be Automation test enginner");
Console.WriteLine(Name);
int C=A+B; 
Console.WriteLine(C);
Console.WriteLine( " Expression  : {0} ={1} + {2}",C,A,B);
if (C==31)
{
Console.WriteLine("App is live");
}
else
{Console.WriteLine("App crashed");
}
//Menu options
Console.WriteLine("Please select an option:");
Console.WriteLine("1. Start Application");
Console.WriteLine("2. stay ideal");
Console.WriteLine("3. Exit Application");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice) 
{
    case 1:
    Console.WriteLine(A);
    break;
    case 2:
    Console.WriteLine(B);
    break;
    case 3:
    Console.WriteLine(C);
    break;
    default:
    Console.WriteLine("no output");
    break;




}







 
