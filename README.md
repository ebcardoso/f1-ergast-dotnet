# Description
A C# library containing methods for all available API calls by ErgastF1 API. Check below for documentation and examples.

## Drivers
```cs
// Creating a new instance for Drivers Services
var driversServices = new DriversServices();

// List of all drivers
var result = await driversServices.List(int? offset=0, int? limit=10);
// List of all drivers within a season
var result = await driversServices.ListBySeason(int year, int? offset=0, int? limit=10);
// List of all drivers within a race
var result = await driversServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
// Driver Information
var result = await driversServices.FindByID(string driverId);
```

## Constructors
```cs
// Creating a new instance for Constructors Services
var constructorsServices = new ConstructorsServices();

// List of all constructors
var result = await constructorsServices.List(int? offset=0, int? limit=10);
// List of all constructors within a season
var result = await constructorsServices.ListBySeason(int year, int? offset=0, int? limit=10);
// List of all constructors within a race
var result = await constructorsServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
// Constructor Information
var result = await constructorsServices.FindByID(string constructorId);
```

## Circuits
```cs
// Creating a new instance for Circuits Services
var circuitsServices = new CircuitsServices();

// List of all circuits
var result = await circuitsServices.List(int? offset=0, int? limit=10);
// List of all circuits within a season
var result = await circuitsServices.ListBySeason(int year, int? offset=0, int? limit=10);
// List of all circuits within a race
var result = await circuitsServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
// Circuit Information
var result = await circuitsServices.FindByID(string circuitId);
```

## Season
```cs
// Creating a new instance for Seasons Services
var seasonsServices = new SeasonsServices();

// List of all seasons
var result = await seasonsServices.List(int? offset=0, int? limit=10);
```

## Qualifying
```cs
// Creating a new instance for Qualifying Services
var qualiServices = new QualifyingsServices();

// List qualifying by a race
var result = await qualiServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
```

## Schedules
```cs
// Creating a new instance for Schedule Services
var scheduleServices = new ScheduleServices();

// List schedules by current season
var result = await scheduleServices.ListByCurrentSeason(int? offset=0, int? limit=10);
// List schedules by season
var result = await scheduleServices.ListBySeason(int season, int? offset=0, int? limit=10);
// List schedules by a race
var result = await scheduleServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
```

## Race Results
```cs
// Creating a new instance for Result Services
var resultServices = new ResultServices();

// List most recent result
var result = await resultServices.MostRecent();
// List result by a race
var result = await resultServices.ListByRace(int year, int round);
```

## Laps
```cs
// Creating a new instance for Lap Services
LapServices lapServices = new LapServices();

// Results of a lap
var result = await lapServices.ListLapTimes(int year, int round, int lap, int? offset=0, int? limit=10);
```

## Finishing Status
```cs
// Creating a new instance for Finish Status Services
var finishingStatusServices = new FinishingStatusServices();

// List of all finish status
var result = await finishingStatusServices.List(int? offset=0, int? limit=10);
// List of all finish status within a season
var result = await finishingStatusServices.ListBySeason(int year, int? offset=0, int? limit=10);
// List of all finish status within a race
var result = await finishingStatusServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
```

## Pitstops
```cs
// Creating a new instance for Pitstop Services
var pitstopServices = new PitstopServices();

// List of all pitstops within a race
var result = await pitstopServices.ListByRace(int year, int round, int? offset=0, int? limit=10);
// List of all pitstops by stop number
var result = await pitstopServices.ListByNumber(int year, int round, int number, int? offset=0, int? limit=10);
```

## Standings - Drivers & Constructors
```cs
// Creating a new instance for Standing Services
var standingServices = new StangingServices();

// List current drivers' current standings
var result = await standingServices.DriversCurrentStanding();
// List standings by a season
var result = await standingServices.DriversBySeason(int year, int? offset=0, int? limit=10);
// List drivers standings after a race
var result = await standingServices.DriversAfterRace(int year, int round, int? offset=0, int? limit=10);
// List standings history of a driver
var result = await standingServices.StandingHistoryByDriver(string driverId, int? offset=0, int? limit=10);
// List champions by drivers
var result = await standingServices.ChampionsHistoryByDrivers(int? offset=0, int? limit=10);
// List current constructors' current standings
var result = await standingServices.ConstructorsCurrentStanding();
// List constructors standings by a season
var result = await standingServices.ConstructorsBySeason(int year, int? offset=0, int? limit=10);
// List standings after a race
var result = await standingServices.ConstructorsAfterRace(int year, int round, int? offset=0, int? limit=10);
// List standings history of a constructor
var result = await standingServices.StandingHistoryByConstructor(string constructorId, int? offset=0, int? limit=10);
// List champions by constructors
var result = await standingServices.ChampionsHistoryByConstructors(int? offset=0, int? limit=10);
```
