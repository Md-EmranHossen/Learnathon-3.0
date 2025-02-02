using Indexers;

var cookie = new HttpCookie();
cookie["name"] = "Mosh";
Console.WriteLine(cookie["name"]);