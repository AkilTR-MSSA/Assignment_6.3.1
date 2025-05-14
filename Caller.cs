using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

public class Caller
{
	public Caller(string name, string phoneNumber)
	{
		Name = name;
		PhoneNumber = phoneNumber;
	}
	public string Name { get; set; }
	public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Phone Number: {PhoneNumber}";
    }
}
