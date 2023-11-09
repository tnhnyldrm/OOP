using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();

BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLogerService);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

