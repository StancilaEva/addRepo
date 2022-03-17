// See https://aka.ms/new-console-template for more information


using ExceptionsAssignment;




bool isValid(string s)
{
    if (s == null)
    {
        throw new StringIsNullException("string is null");
    }
    else
        if(s.Length == 0)
    {
        throw new StringIsEmptyException("string is empty");
    }
    return s.Length > 6;
}

try
{
    try
    {
        if (isValid(null))
        {
            Console.WriteLine("is Valid");
        }
    }
    catch (StringIsNullException ex)
    {
        Console.WriteLine(ex.Message);
        throw new Exception("null string exception", ex);
    }
    catch (StringIsEmptyException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("execution of finally");
    }
}catch(Exception ex)
{
    Console.WriteLine(ex.Message+" exception message: "+ex.InnerException.Message);
}

#if DEBUG
Console.WriteLine("debug");
#endif
