using Class4;

string db = Constants.CONFIG_DB_NAME;

var x = 10.0;
var y = "some string";

dynamic d = new ShiftWorker() { FirstName = "Dynamic", 
    LastName = "Worker" };

//string kid1 = d.Kids[1];
Console.WriteLine(d.FirstName);
