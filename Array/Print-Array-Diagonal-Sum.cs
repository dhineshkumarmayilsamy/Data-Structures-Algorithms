using System;
class ArrayExercise {
  static void Main() {
    ArrayDiagonalSum();
  }

  public static void ArrayDiagonalSum() {
     int[,] arr1 = new int[5,5]{
          {1,2,3,4,5},
          {1,2,3,4,5},
          {1,2,3,4,5},
          {1,2,3,4,5},
          {1,2,3,4,5}
      };

    int sum = 0;
    for (int i = 0; i < 5; i++) {
      sum += arr1[i, i];
    }

    Console.WriteLine(sum);
  }
}
