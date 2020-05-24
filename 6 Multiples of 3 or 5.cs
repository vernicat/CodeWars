public static class Kata
{
  public static int Solution(int value)
  {
    int sum=0, i=0;
    for (;i < value; i++)
      if ((i%5==0)||(i%3==0))
        sum += i;
    return sum;
  }
}