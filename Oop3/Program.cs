using Oop3;

PersonalCreditManager personalCreditManager1 = new PersonalCreditManager();

TransportCreditManager transportCreditManager1 = new TransportCreditManager();

HomeLoanManager homeLoanManager1 = new HomeLoanManager();

//interfaceler onu implemente eden classin referansini tutabilir.
ICreditManager personalCreditManager = new PersonalCreditManager();
ICreditManager transportCreditManager = new TransportCreditManager();
ICreditManager homeLoanManager = new HomeLoanManager();
ICreditManager companyCreditManager1 = new CompanyCreditManager();

ILoggerService databaseLoggerService1 = new DatabaseLoggerService();
ILoggerService fileLoggerService1 = new FileLoggerService();
ILoggerService smsLoggerService1 = new SmsLoggerService();



//ApplyManager applyManager = new ApplyManager();
List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService1, smsLoggerService1, databaseLoggerService1 };

new ApplyManager().ToApply(companyCreditManager1, loggers);

List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager, transportCreditManager, companyCreditManager1 };
//applyManager.LoanPreInformation(credits); 
