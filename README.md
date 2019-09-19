# UPSAddressValidation
This is a C# .NET wrapper for the UPS street level address validation REST API (Up to date as of August 2018). The UPS street level address validation API is used for verifying that addresses are consistent with those that UPS has on record. If you're shipping packages to people and want to minimize the number of wrong addresses and incorrect deliveries, this is the API for you. If you've ever put in an address into Amazon and it gave you a suggested address variation, this is the same concept. This C# wrapper is here to make your use of the API quick and easy in a .NET Framework application. 

# Configuration
This package is available on nuget at https://www.nuget.org/packages/UPSValidation/
From Visual Studio you can either install it with the package manager console with the command: `Install-Package UPSValidation`

Or you can use the "Manage Nuget Packages for Solution" window and search UPSValidation

Next, go to https://www.ups.com/upsdeveloperkit and follow the instructions for retrieving an API key. 
In your App.config add the following to the appSettings section (if there isn't an appSettings section add `<appSettings> </appSettings>` and put the following in between those tags:
```
<add key="AccessLicenseNumber" value="Your_UPS_API_Key" />
<add key="UPSUsername" value="Your_UPS_Username" />
<add key="UPSPassword" value="Your_UPS_Password" />
<add key="isTesting" value="false" />
```
(isTesting was originally to swap between the two UPS API url's for testing and production but it's not implemented anymore)

# Use
In the file you want to perform validation from, add:
```
using UPSValidation;
    ...
    UPS upsValidator = new UPS(1);
    List<Address> addresses = upsValidator.Validate("Test address", "Test apt #", "City", "ST", "12345");
    ...
```
    
This will give you a list of suggested replacement addresses for the test address submitted to validate(). 

The object hierarchy in this package is accurate to the JSON structure submitted to and returned from the API, so if you want to use more data from the request than just the simple Address object I've created here, it should be pretty easy to do so. 
    
