using System;
class ArrayExercise {
  static void Main() {
    PrintFunc();
  }

  public static void PrintFunc(int i = 1) {
    Console.WriteLine(i);
    if (i < 100)
      PrintFunc(++i);
  }
}
