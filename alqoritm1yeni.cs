//int num = 48;
//int a = num % 10;
//int b = num / 10;
//if(a > b)
//{
//    Console.WriteLine(a);
//  }
//else
//{
//    Console.WriteLine(b);
//}
//{


int num = 648;
int max = 0;
while (num > 0)
{
	int a = num % 10;
	if (a > max)
	{
		max = a;
	}
	num /= 10;
}
 Console.WriteLine(max);
}
