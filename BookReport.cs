
namespace new_oop_pattern{
    public class BookReport{

        private BookHandler bookHandler;
        public BookReport(BookHandler bookHandler){
            this.bookHandler = bookHandler;
        }

        public void PrintAllBooks(){
            Book[] myBooks = bookHandler.GetAllBooks();
            for(int i = 0; i < Book.GetCount(); i++){
                System.Console.WriteLine(myBooks[i].ToString());
            }
        }

        public void PrintCountByGenre(){
            bookHandler.SortByGenre();
            Book[] myBooks = bookHandler.GetAllBooks();

            string curr = myBooks[0].GetGenre();
            int count = 1;

            for(int i = 1; i < Book.GetCount(); i++){
                if(curr == myBooks[i].GetGenre()){
                    count++;
                } else{
                    ProcessCountByGenreBreak(ref curr, ref count, myBooks, i);
                }
            }

            ProcessCountByGenreBreak(curr, count);
        }

        private void ProcessCountByGenreBreak(ref string curr, ref int count, Book[] myBooks, int i){
            System.Console.WriteLine($"{curr} has {count} books");
            curr = myBooks[i].GetGenre();
            count = 1;
        }

        private void ProcessCountByGenreBreak(string curr, int count){
            System.Console.WriteLine($"{curr} has {count} books");
        }
    }
}