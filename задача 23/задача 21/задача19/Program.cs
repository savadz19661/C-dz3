// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if(N >=10000&& N < 100000){
int n1 = N /10000;
int n2 = N / 1000 % 10;
int n4 = N / 10 % 10;
int n5 = N % 10;
  if(n1==n5 && n2==n4){
  Console.Write("Число является палиндромом");
  }
  else{
  Console.Write("Число не является палиндромом");
  }}

else{
   Console.Write("Введите пятизначное число");
}  