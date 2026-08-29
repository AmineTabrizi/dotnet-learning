throw new Exception();

public class CustomException : Exception
{
    public int StatusCode {get; }

    public CustomException()
    {
        
    }

    public CustomException(int statusCode)
    {
        StatusCode = statusCode;
    }
    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}
// try
// {
//     var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
// }
// catch(HttpRequestException ex) when (ex.Message == "403")
// {
//     Console.WriteLine("It was forbidden to access the resource.");
//     throw;
// }
// catch(HttpRequestException ex) when (ex.Message == "404")
// {
//     Console.WriteLine("The resource was not found.");
//     throw;
// }
// catch(HttpRequestException ex) when (ex.Message.StartsWith("4"))
// {
//     Console.WriteLine("some kind of client error.");
//     throw;
// }



var result = GetFirstElement(new int[0]);

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The Collection can not be empty.");
     
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch(InvalidOperationException ex)
    {
        Console.WriteLine("The Collection is empty!");
        return true;
    }
    catch(NullReferenceException ex)
    {
        Console.WriteLine("Sorry! The application experienced" + "an unexpected error.");
        throw ex;
        // throw new ArgumentNullException("The collection is null!", ex);
    }

}