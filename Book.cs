namespace new_oop_pattern
{
    public class Book{
        private string title;

        private string author;
        private int pageCount;
        private string genre;

        static private int count;

        public Book() {}

        public Book(string title, string author, int pageCount, string genre){
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.genre = genre;
        }

        public string GetTitle(){
            return title;
        }

        public void SetTitle(string title){
            this.title = title;
        }

        public void SetAuthor(string author){
            this.author = author;
        }

        public void SetPageCount(int pageCount){
            this.pageCount = pageCount;
        }

        public string GetGenre(){
            return genre;
        }

        public void SetGenre(string genre){
            this.genre = genre;
        }

        static public int GetCount(){
            return Book.count;
        }

        public override string ToString(){
            return $"{title}\t{author}\t{pageCount}\t{genre}";
        }

        public string ToFile(){
            return $"{title}#{author}#{pageCount}#{genre}";
        }

        static public void SetCount(int count){
            Book.count = count;
        }

        static public void IncCount(){
            Book.count++;
        }

    
    }   
}