# Description
A C# library containing methods for all available API calls by ErgastF1 API. Check below for documentation and examples.

## Drivers
```cs
// Creating a new instance for Drivers Services
var driversServices = new DriversServices();

// List of all drivers
var result = await driversServices.List(offset int?, limit int?);
// List of all drivers within a season
var result = await driversServices.ListBySeason(year int, offset int?, limit int?)
// List of all drivers within a race
var result = await driversServices.ListByRace(year int, round int, offset int?, limit int?)
// Driver Information
var result = await driversServices.FindByID(driverId string)
```

## Constructors
```cs
// Creating a new instance for Constructors Services
var constructorsServices = new ConstructorsServices();

// List of all drivers
var result = await constructorsServices.List(offset int?, limit int?);
// List of all drivers within a season
var result = await constructorsServices.ListBySeason(year int, offset int?, limit int?)
// List of all drivers within a race
var result = await constructorsServices.ListByRace(year int, round int, offset int?, limit int?)
// Constructor Information
var result = await constructorsServices.FindByID(constructorId string)
```

## Circuits
```cs
// Creating a new instance for Circuits Services
var circuitsServices = new CircuitsServices();

//List of all circuits
var result = await circuitsServices.List(offset int?, limit int?);
//List of all circuits within a season
var result = await circuitsServices.ListBySeason(year int, offset int?, limit int?)
//List of all circuits within a race
var result = await circuitsServices.ListByRace(year int, round int, offset int?, limit int?)
// Circuit Information
var result = await circuitsServices.FindByID(circuitId string)
```

## Seasaon
```cs
// Creating a new instance for Seasons Services
var seasonsServices = new SeasonsServices();

// List of all seasons
var result = await seasonsServices.List(offset int?, limit int?);
```

## Qualifying
```cs
// Creating a new instance for Qualifying Services
var qualiServices = new QualifyingsServices();

// List qualifying by a race
var result = await qualiServices.ListByRace(year int, round int, offset int?, limit int?);
```

## Finishing Status
```cs
// Creating a new instance for Finish Status Services
var finishingStatusServices = new FinishingStatusServices();

//List of all finish status
var result = await finishingStatusServices.List(offset int?, limit int?);
//List of all finish status within a season
var result = await finishingStatusServices.ListBySeason(year int, offset int?, limit int?)
//List of all finish status within a race
var result = await finishingStatusServices.ListByRace(year int, round int, offset int?, limit int?)
```
