using Tirgol_DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        ///Singleton

        //var newClock = Clock.InstanceCreate();
        //var newClock2 = Clock.InstanceCreate();
        //if (newClock == newClock2)
        //{
        //    newClock.GetTime();
        //}
        //else
        //{
        //    Console.WriteLine("Please try again!");
        //}

        ///ChainOfResponsibility

        //GarageWorkerHandler workerHandler = new GarageWorkerHandler();
        //GarageMechanicHandler mechanicHandler = new GarageMechanicHandler();
        //GarageElectricGuyHandler electricGuyHandler = new GarageElectricGuyHandler();
        //GarageDiagnosticCheckHandler diagnosticCheckHandler = new GarageDiagnosticCheckHandler();

        //workerHandler.SetNext(mechanicHandler);
        //mechanicHandler.SetNext(electricGuyHandler);
        //electricGuyHandler.SetNext(diagnosticCheckHandler);
        //diagnosticCheckHandler.SetNext(null);

        //Console.WriteLine("Checking if your car is fixed!");
        //workerHandler.RepairRequestHandler();

        ///Factory

        //ChatingWithDietanic cwd = new ChatingWithDietanic();
        //MeetingWithDietanic mwd = new MeetingWithDietanic(cwd);
        //mwd.PersonSelectedVegDiet(vegMenu.banana, vegMenu.tomato, vegMenu.melon, vegMenu.cucamber);
        //mwd.UserAddToMenu(23, 70, 180);

    }
}
