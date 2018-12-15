public static class StringExtensions
{
    public static string[] Split(this string @this, char separator, int count)
    {
      ` if(@this = null)
        {
            throw new ArgumentNullException(nameof(@this));
        }
        
        return @this.Split(new [] {separator}, count);
        
    }
}
