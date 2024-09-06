# Description
A C# library containing methods for all available API calls by ErgastF1 API. Check below for documentation and examples.

## Drivers
```cs
// Creating a new instance for Drivers Services
var driversServices = new DriversServices();

//List of all drivers
var result = await driversServices.List(offset int?, limit int);
//List of all drivers within a season
var result = await driversServices.ListBySeason(year int, offset int?, limit int?)
//List of all drivers within a race
var result = await driversServices.ListByRace(year int, round int, offset int?, limit int?)
//Driver Information
var result = await driversServices.FindByID(driverId string)
```

## Constructors
```cs
// Creating a new instance for Constructors Services
var constructorsServices = new ConstructorsServices();

//List of all drivers
var result = await constructorsServices.List(offset int?, limit int);
//List of all drivers within a season
var result = await constructorsServices.ListBySeason(year int, offset int?, limit int?)
//List of all drivers within a race
var result = await constructorsServices.ListByRace(year int, round int, offset int?, limit int?)
//Driver Information
var result = await constructorsServices.FindByID(driverId string)
```
