// Get user Info
Console.Write("Enter your First name: ");
string firstname = Console.ReadLine();
Console.Write("Enter your Last Name: ");
string lastname = Console.ReadLine();
Console.Write("Enter your Student Number: ");
string stdnumberdisplay = Console.ReadLine();
int stdnumber = Convert.ToInt32(stdnumberdisplay);
int stdnumbera = stdnumber;
Console.WriteLine($"Hi {firstname} {lastname}, Your Student number is:{stdnumber}");
int counter = 0, arraysize = 0;
// Get array size
for (int i = 0; stdnumber > 0; i++)
{
    int extractdigit = stdnumber % 10;
    stdnumber = stdnumber / 10;
    counter++;
    if (extractdigit == 0)
    { continue; }
    else
    {
        arraysize++;
    }
}
int[] myintArray = new int[arraysize]; // Declare Array
Console.WriteLine("The array elements are:");
for (int i = 0, j = 0; i < counter; i++) // For Loop to assign elements
{
    int extractdigita = stdnumbera % 10;
    stdnumbera = stdnumbera / 10;
    if (extractdigita != 0)
    {
        myintArray[j] = extractdigita;
        j++;
    }
    else { continue; }
}
Array.Reverse(myintArray); // Reverse to display
foreach (int i in myintArray)
{
    Console.WriteLine();
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------------------------------");//Part 2
// Display menu
Console.WriteLine("Operation Menu");
Console.WriteLine("1. Integer addition");
Console.WriteLine("2. Double addition");
Console.WriteLine("3. String concentration");
// Declaration
int firstNumber, secondNumber;
double firstDblNo, secondDblNo;
// User Prompt
Console.Write("Enter first integer number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second integer number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first double number: ");
firstDblNo = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second double number: ");
secondDblNo = Convert.ToDouble(Console.ReadLine());
// Method creating
int Add_int(int firstNumber, int secondNumber)
{
    int intsum = firstNumber + secondNumber;
    return intsum;
}
double Add_dbl(double firstDblNo, double secondDblNo)
{
    double doublesum = firstDblNo + secondDblNo;
    return doublesum;
}
void concentrate_name(string firstname, string lastname)
{
    string stringconcentration = firstname + " " + lastname;
    Console.WriteLine(stringconcentration);
}
// Loop to perform
do
{
    Console.WriteLine("Select the operation:");
    Console.WriteLine("Integer addition (I or i)");
    Console.WriteLine("Double addition (D or d)");
    Console.WriteLine("String concentration (S or s)");
    Console.Write("Enter the first character of the operation: ");
    string input = Console.ReadLine();
    switch (input.ToLower())
    {
        case "i":
            int intsum = Add_int(firstNumber, secondNumber);
            Console.WriteLine(intsum);
            break;
        case "d":
            double doublesum = Add_dbl(firstDblNo, secondDblNo);
            Console.WriteLine(doublesum);
            break;
        case "s":
            concentrate_name(firstname, lastname);
            break;
    }
    Console.Write("Do you want to continue? (Y/N): ");
    string continueoption = Console.ReadLine();
    if (continueoption.ToUpper() == "Y")
    {
        continue;
    }
    else if (continueoption.ToUpper() == "N")
    {
        Console.WriteLine($"Program ends Thank you {firstname} {lastname}");
        break;
    }
}
while (true);