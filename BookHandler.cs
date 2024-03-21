namespace new_oop_pattern{
    public class BookHandler{
        private Book[] myBooks;
        private BookFileHandler bookFileHandler;

        public BookHandler(){
            myBooks = new Book[100];
            bookFileHandler = new BookFileHandler(myBooks);
            bookFileHandler.ReadFromFile();

        }

        public Book[] GetAllBooks(){
            return myBooks;
        }

        public void AddBook(){
            Book newBook = new Book();

            System.Console.WriteLine("What is the title?");    
            newBook.SetTitle(Console.ReadLine());

            System.Console.WriteLine("What is the author");
            newBook.SetAuthor(Console.ReadLine());

            System.Console.WriteLine("How many pages?");
            newBook.SetPageCount(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("What is the genre");
            newBook.SetGenre(Console.ReadLine());

            myBooks[Book.GetCount()] = newBook;

            Book.IncCount();
            bookFileHandler.SaveToFile();
        }

        public void SortByGenre(){
            for(int i = 0; i < Book.GetCount() - 1; i++){
                int min = i;
                for(int j = i + 1; j < Book.GetCount(); j++){

                    if(myBooks[min].GetGenre().ToLower().CompareTo(myBooks[j].GetGenre().ToLower()) > 0){
                        min = j;
                    }
                }

                if(min != i){
                    Swap(min, i);
                }
            }
        }

        private void Swap(int x, int y){
            Book temp = myBooks[x];
            myBooks[x] = myBooks[y];
            myBooks[y] = myBooks[x];
        }
    }
}