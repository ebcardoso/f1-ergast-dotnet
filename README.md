# Description
A C# library containing methods for all available API calls by ErgastF1 API. Check below for documentation and examples.

## Drivers
```cs
// Creating instance for Drivers Services
var driversServices = new DriversServices();

//List of all drivers
var result = await driverServices.List(offset int?, limit int);
//List of all drivers within a season
var result = await driverServices.ListBySeason(year int, offset int?, limit int?)
//List of all drivers within a race
var result = await driverServices.ListByRace(year int, round int, offset int?, limit int?)
//Driver Information
var result = await driverServices.FindByID(driverId string)
```
