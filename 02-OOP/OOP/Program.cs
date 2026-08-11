// var rectangle1 = new Rectangle(5, 3);
// var calculator = new ShapeMeasurementsCalculator();
// Console.WriteLine("Width is: " + rectangle1.Width);
// Console.WriteLine("Height is: " + rectangle1.Height);
// Console.WriteLine("Area is: " + calculator.CalculateRectangleArea(rectangle1));
// Console.WriteLine("Circumference is: " + calculator.CalculateRectangleCircumference(rectangle1));

// class Rectangle
// {
//     public int Width;
//     public int Height;
//     public Rectangle(int width, int height)
//     {
//         Width = width;
//         Height = height;
//     }
// }
// class ShapeMeasurementsCalculator
// {
//     public int CalculateRectangleCircumference(Rectangle rectangle)
//     {
//         return (rectangle.Width + rectangle.Height) * 2;
//     }
//     public int CalculateCircumference() => (rectangle.Width + rectangle.Height) * 2;
//     public int CalculateRectangleArea(Rectangle rectangle)
//     {
//         return rectangle.Width * rectangle.Height;
//     }
// public int CalculateRectangleArea() => width * height; // Expression
// }



var medicalApointment = new MedicalAppointment("Amin Tabrizi", new DateTime(2021,3,2));
// medicalApointment.OverwriteMonthAndDay(2, 3);
medicalApointment.Reschdule(new DateTime(2021,3,5));



class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on" + medicalAppointment.GetDate());
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }
    public DateTime GetDate() => _date;
    // public MedicalAppointment(string patientName):
    //     this(patientName, 7)
    // {
    // }

    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschdule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
    public void MoveByMonthsAndDays(int monthToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthToAdd, _date.Day + daysToAdd);
    }


}