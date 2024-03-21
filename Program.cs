using new_oop_pattern;

BookHandler bookHandler = new BookHandler();
BookReport bookReport = new BookReport(bookHandler);

bookReport.PrintAllBooks();

bookHandler.AddBook();

bookReport.PrintCountByGenre();

bookHandler.AddBook();

bookReport.PrintCountByGenre();

bookReport.PrintAllBooks();
