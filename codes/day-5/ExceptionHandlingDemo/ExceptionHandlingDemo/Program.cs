namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static int Divide(int x, int y)
        {
            int result = 0;
            try
            {                
                result = x / y;
                return result;
            }
            catch(DivideByZeroException)
            {
                throw;
            }
        }
        static void Main()
        {
            int result = 0;
            try
            {
                //result = Divide(10, 0);
                LicenseApplication application = new LicenseApplication();
                application.Name = "Test";
                application.Age = 17;
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine($"Exception: {e.GetType().Name}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Method: {e.TargetSite}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"Information: {e.StackTrace}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}
