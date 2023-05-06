// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Source source = new Source("None were with him","https://www.churchofjesuschrist.org" );

// Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland","Because Jesus walked such a long, lonely path utterly alone, we do not have to do so", source);

// Console.WriteLine(holland.GetQUote());

Board quoteborad = new Board();
quoteboard.AddQuote(holland);
quoteboard.FindQuotesByAuthor("holland");
