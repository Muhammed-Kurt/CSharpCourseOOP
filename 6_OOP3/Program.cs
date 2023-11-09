namespace _6_OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface'lerde, interface'i implemente eden class'ın referansını tutabiliyor.
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager housingCreditManager = new HousingCreditManager();

            ICreditManager tradesmanCreditManager = new TradesmanCreditManager();
            //Loglama İşlemi
            ILoggerService databaseLoggerService = new DatabaseLoggerSevice();
            ILoggerService fileLoggerService = new FileLoggerSevice();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ApplicationManager applicationManager = new ApplicationManager();

            List<ILoggerService> loggerServices =new List<ILoggerService>() 
            {databaseLoggerService,smsLoggerService };
            applicationManager.MakeApplication(tradesmanCreditManager,loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>()
            {vehicleCreditManager,personalFinanceCreditManager};

            //applicationManager.ProvideCreditPreliminaryInformation(credits);


        }
    }
}