
//App<Worker> app = new App<Worker>(new ListRepository());

App<Worker> app = new App<Worker>(new PostgresRepository("db17042023"));

app.Create(new Worker("Василий Иванов", 22, 3312));
app.Create(new("Василий Петров", 44, 4562));
app.Create(new("Иван Васильев", 33, 1245));
app.Create(new("sdfsd sdvsdvв", 33, 1245));
app.Create(new("Иsdvsdv Вsdvsdvев", 33, 1245));
app.Create(new("Иsdvsd Вsdvsdv", 33, 1245));
app.Create(new("sdvsdv Вsdvsdv", 33, 1245));
app.Create(new("sdvsdv Вsdvsdv", 33, 1245));

app.Print();

Console.WriteLine("=========================");
app.PPrint();

// app.Print(); Console.WriteLine();

// app.Remove(2);

// app.Print(); Console.WriteLine();

// app.Update(1, new("Segey Kam", 122, 31312));

// app.Print(); Console.WriteLine();

