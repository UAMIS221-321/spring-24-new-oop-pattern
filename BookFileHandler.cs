namespace new_oop_pattern{
    public class BookFileHandler{
        private Book[] myBooks;

        public BookFileHandler(Book[] myBooks){
            this.myBooks = myBooks;
        } 

        public void ReadFromFile(){
            Book.SetCount(0);

            StreamReader inFile = new StreamReader("books.txt");

            string line = inFile.ReadLine();

            while(line != null){
                string[] temp = line.Split("#");
                myBooks[Book.GetCount()] = new Book(temp[0], temp[1], int.Parse(temp[2]), temp[3]);

                line = inFile.ReadLine();

                Book.IncCount();
            }

            inFile.Close();
        }

        public void SaveToFile(){
            StreamWriter outFile = new StreamWriter("books.txt");

            for(int i = 0; i < Book.GetCount(); i++){
                outFile.WriteLine(myBooks[i].ToFile());
            }

            outFile.Close();
        }
    }
}
