//User enter tow inputs (name , age (nullable))
//if name length less than 2 characters, print "Invalid name"
//if name length eqaul 2 characters, print "name (Too Short)"
//if age is null, print "Age is not provided"
//if age is less than 18, print "Young"
//if age is 18 or above, print "Adult"

//Final result exapmles

// Input: name = "A", age = 25
// Output: "Invalid name, Adult"

// Input: name = "My", age = 25
// Output: "My (Too Short), Adult"

// Input: name = "My", age = null
// Output: "My (Too Short), Age is not provided"    

// Input: name = "Abdallah", age = 16
// Output: "Abdallah, Young"

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
string ageInput = Console.ReadLine();
int? age = string.IsNullOrEmpty(ageInput) ? null : Convert.ToInt16(ageInput.Trim());

string result = "";

if (string.IsNullOrEmpty(name) || name.Length < 2)
{
    result = "Invalid name, ";
}
else if(name.Length == 2)
{
    result = $"{name} (Too Short), ";
}
else
{
    result = $"{name}, ";
}

if (age != null)
{
    if (age < 18)
    {
        result = $"{result} Young";
    }
    else
    {
        result = $"{result} Adult";
    }
}
else
{
    result = $"{result} Age is not provided";
}

Console.WriteLine(result);
