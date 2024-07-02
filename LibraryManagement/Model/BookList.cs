using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class BookList
    {
        public static Dictionary<string, object>[] bookList = new Dictionary<string, object>[]
        {
             new Dictionary<string, object>
            {
                { "id", 1 },
                { "name", "To Kill a Mockingbird" },
                { "author", "Harper Lee" },
                { "pages", 281 },
                { "published_year", 1960 },
                { "category", "Fiction" }
            },
             new Dictionary<string, object>
            {
                { "id", 2 },
                { "name", "1984" },
                { "author", "George Orwell" },
                { "pages", 328 },
                { "published_year", 1949 },
                { "category", "Dystopian" }
            },
             new Dictionary<string, object>
        {
            { "id", 3 },
            { "name", "Moby Dick" },
            { "author", "Herman Melville" },
            { "pages", 635 },
            { "published_year", 1851 },
            { "category", "Adventure" }
        },
             new Dictionary<string, object>
        {
            { "id", 4 },
            { "name", "Pride and Prejudice" },
            { "author", "Jane Austen" },
            { "pages", 279 },
            { "published_year", 1813 },
            { "category", "Romance" }
        },
             new Dictionary<string, object>
        {
            { "id", 5 },
            { "name", "The Great Gatsby" },
            { "author", "F. Scott Fitzgerald" },
            { "pages", 180 },
            { "published_year", 1925 },
            { "category", "Fiction" }
        },
             new Dictionary<string, object>
        {
            { "id", 6 },
            { "name", "War and Peace" },
            { "author", "Leo Tolstoy" },
            { "pages", 1225 },
            { "published_year", 1869 },
            { "category", "Historical Fiction" }
        },
             new Dictionary<string, object>
            {
                { "id", 7 },
                { "name", "The Catcher in the Rye" },
                { "author", "J.D. Salinger" },
                { "pages", 214 },
                { "published_year", 1951 },
                { "category", "Fiction" }
            },
             new Dictionary<string, object>
             {
                 { "id", 8 },
                 { "name", "The Hobbit" },
                 { "author", "J.R.R. Tolkien" },
                 { "pages", 310 },
                 { "published_year", 1937 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 9 },
                 { "name", "Brave New World" },
                 { "author", "Aldous Huxley" },
                 { "pages", 268 },
                 { "published_year", 1932 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 10 },
                 { "name", "Crime and Punishment" },
                 { "author", "Fyodor Dostoevsky" },
                 { "pages", 671 },
                 { "published_year", 1866 },
                 { "category", "Psychological Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 11 },
                 { "name", "Jane Eyre" },
                 { "author", "Charlotte Brontë" },
                 { "pages", 500 },
                 { "published_year", 1847 },
                 { "category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "id", 12 },
                 { "name", "Wuthering Heights" },
                 { "author", "Emily Brontë" },
                 { "pages", 416 },
                 { "published_year", 1847 },
                 { "category", "Gothic Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 13 },
                 { "name", "Great Expectations" },
                 { "author", "Charles Dickens" },
                 { "pages", 505 },
                 { "published_year", 1861 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 14 },
                 { "name", "The Odyssey" },
                 { "author", "Homer" },
                 { "pages", 541 },
                 { "published_year", -800 },
                 { "category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "id", 15 },
                 { "name", "Ulysses" },
                 { "author", "James Joyce" },
                 { "pages", 730 },
                 { "published_year", 1922 },
                 { "category", "Modernist Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 16 },
                 { "name", "The Divine Comedy" },
                 { "author", "Dante Alighieri" },
                 { "pages", 798 },
                 { "published_year", 1320 },
                 { "category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "id", 17 },
                 { "name", "The Brothers Karamazov" },
                 { "author", "Fyodor Dostoevsky" },
                 { "pages", 796 },
                 { "published_year", 1880 },
                 { "category", "Philosophical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 18 },
                 { "name", "Les Misérables" },
                 { "author", "Victor Hugo" },
                 { "pages", 1232 },
                 { "published_year", 1862 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 19 },
                 { "name", "Anna Karenina" },
                 { "author", "Leo Tolstoy" },
                 { "pages", 864 },
                 { "published_year", 1878 },
                 { "category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "id", 20 },
                 { "name", "One Hundred Years of Solitude" },
                 { "author", "Gabriel Garcia Marquez" },
                 { "pages", 417 },
                 { "published_year", 1967 },
                 { "category", "Magic Realism" }
             },
             new Dictionary<string, object>
             {
                 { "id", 21 },
                 { "name", "Don Quixote" },
                 { "author", "Miguel de Cervantes" },
                 { "pages", 1072 },
                 { "published_year", 1615 },
                 { "category", "Satire" }
             },
             new Dictionary<string, object>
             {
                 { "id", 22 },
                 { "name", "The Iliad" },
                 { "author", "Homer" },
                 { "pages", 704 },
                 { "published_year", -750 },
                 { "category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "id", 23 },
                 { "name", "The Picture of Dorian Gray" },
                 { "author", "Oscar Wilde" },
                 { "pages", 254 },
                 { "published_year", 1890 },
                 { "category", "Philosophical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 24 },
                 { "name", "Frankenstein" },
                 { "author", "Mary Shelley" },
                 { "pages", 280 },
                 { "published_year", 1818 },
                 { "category", "Gothic Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 25 },
                 { "name", "Dracula" },
                 { "author", "Bram Stoker" },
                 { "pages", 418 },
                 { "published_year", 1897 },
                 { "category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "id", 26 },
                 { "name", "Heart of Darkness" },
                 { "author", "Joseph Conrad" },
                 { "pages", 122 },
                 { "published_year", 1899 },
                 { "category", "Novella" }
             },
             new Dictionary<string, object>
             {
                 { "id", 27 },
                 { "name", "The Metamorphosis" },
                 { "author", "Franz Kafka" },
                 { "pages", 201 },
                 { "published_year", 1915 },
                 { "category", "Absurdist Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 28 },
                 { "name", "The Trial" },
                 { "author", "Franz Kafka" },
                 { "pages", 255 },
                 { "published_year", 1925 },
                 { "category", "Existential Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 29 },
                 { "name", "Middlemarch" },
                 { "author", "George Eliot" },
                 { "pages", 904 },
                 { "published_year", 1871 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 30 },
                 { "name", "The Count of Monte Cristo" },
                 { "author", "Alexandre Dumas" },
                 { "pages", 1276 },
                 { "published_year", 1844 },
                 { "category", "Adventure" }
             },
             new Dictionary<string, object>
             {
                 { "id", 31 },
                 { "name", "Madame Bovary" },
                 { "author", "Gustave Flaubert" },
                 { "pages", 329 },
                 { "published_year", 1857 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 32 },
                 { "name", "The Old Man and the Sea" },
                 { "author", "Ernest Hemingway" },
                 { "pages", 127 },
                 { "published_year", 1952 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 33 },
                 { "name", "A Tale of Two Cities" },
                 { "author", "Charles Dickens" },
                 { "pages", 489 },
                 { "published_year", 1859 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 34 },
                 { "name", "Fahrenheit 451" },
                 { "author", "Ray Bradbury" },
                 { "pages", 194 },
                 { "published_year", 1953 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 35 },
                 { "name", "The Catch-22" },
                 { "author", "Joseph Heller" },
                 { "pages", 453 },
                 { "published_year", 1961 },
                 { "category", "Satire" }
             },
             new Dictionary<string, object>
             {
                 { "id", 36 },
                 { "name", "Lolita" },
                 { "author", "Vladimir Nabokov" },
                 { "pages", 336 },
                 { "published_year", 1955 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 37 },
                 { "name", "Beloved" },
                 { "author", "Toni Morrison" },
                 { "pages", 324 },
                 { "published_year", 1987 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 38 },
                 { "name", "Invisible Man" },
                 { "author", "Ralph Ellison" },
                 { "pages", 581 },
                 { "published_year", 1952 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 39 },
                 { "name", "The Grapes of Wrath" },
                 { "author", "John Steinbeck" },
                 { "pages", 464 },
                 { "published_year", 1939 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 40 },
                 { "name", "Gone with the Wind" },
                 { "author", "Margaret Mitchell" },
                 { "pages", 1037 },
                 { "published_year", 1936 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 41 },
                 { "name", "The Sun Also Rises" },
                 { "author", "Ernest Hemingway" },
                 { "pages", 251 },
                 { "published_year", 1926 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 42 },
                 { "name", "East of Eden" },
                 { "author", "John Steinbeck" },
                 { "pages", 601 },
                 { "published_year", 1952 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 43 },
                 { "name", "Slaughterhouse-Five" },
                 { "author", "Kurt Vonnegut" },
                 { "pages", 275 },
                 { "published_year", 1969 },
                 { "category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 44 },
                 { "name", "The Handmaid's Tale" },
                 { "author", "Margaret Atwood" },
                 { "pages", 311 },
                 { "published_year", 1985 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 45 },
                 { "name", "Of Mice and Men" },
                 { "author", "John Steinbeck" },
                 { "pages", 107 },
                 { "published_year", 1937 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 46 },
                 { "name", "The Road" },
                 { "author", "Cormac McCarthy" },
                 { "pages", 287 },
                 { "published_year", 2006 },
                 { "category", "Post-Apocalyptic" }
             },
             new Dictionary<string, object>
             {
                 { "id", 47 },
                 { "name", "The Catcher in the Rye" },
                 { "author", "J.D. Salinger" },
                 { "pages", 214 },
                 { "published_year", 1951 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 48 },
                 { "name", "The Lord of the Rings" },
                 { "author", "J.R.R. Tolkien" },
                 { "pages", 1216 },
                 { "published_year", 1954 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 49 },
                 { "name", "The Bell Jar" },
                 { "author", "Sylvia Plath" },
                 { "pages", 244 },
                 { "published_year", 1963 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 50 },
                 { "name", "The Shining" },
                 { "author", "Stephen King" },
                 { "pages", 447 },
                 { "published_year", 1977 },
                 { "category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "id", 51 },
                 { "name", "The Alchemist" },
                 { "author", "Paulo Coelho" },
                 { "pages", 208 },
                 { "published_year", 1988 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 52 },
                 { "name", "Harry Potter and the Sorcerer's Stone" },
                 { "author", "J.K. Rowling" },
                 { "pages", 309 },
                 { "published_year", 1997 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 53 },
                 { "name", "Life of Pi" },
                 { "author", "Yann Martel" },
                 { "pages", 319 },
                 { "published_year", 2001 },
                 { "category", "Adventure" }
             },
             new Dictionary<string, object>
             {
                 { "id", 54 },
                 { "name", "The Fault in Our Stars" },
                 { "author", "John Green" },
                 { "pages", 313 },
                 { "published_year", 2012 },
                 { "category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "id", 55 },
                 { "name", "The Da Vinci Code" },
                 { "author", "Dan Brown" },
                 { "pages", 689 },
                 { "published_year", 2003 },
                 { "category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "id", 56 },
                 { "name", "A Game of Thrones" },
                 { "author", "George R.R. Martin" },
                 { "pages", 694 },
                 { "published_year", 1996 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 57 },
                 { "name", "The Girl with the Dragon Tattoo" },
                 { "author", "Stieg Larsson" },
                 { "pages", 465 },
                 { "published_year", 2005 },
                 { "category", "Mystery" }
             },
             new Dictionary<string, object>
             {
                 { "id", 58 },
                 { "name", "The Hunger Games" },
                 { "author", "Suzanne Collins" },
                 { "pages", 374 },
                 { "published_year", 2008 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 59 },
                 { "name", "Gone Girl" },
                 { "author", "Gillian Flynn" },
                 { "pages", 432 },
                 { "published_year", 2012 },
                 { "category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "id", 60 },
                 { "name", "The Book Thief" },
                 { "author", "Markus Zusak" },
                 { "pages", 552 },
                 { "published_year", 2005 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 61 },
                 { "name", "The Kite Runner" },
                 { "author", "Khaled Hosseini" },
                 { "pages", 371 },
                 { "published_year", 2003 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 62 },
                 { "name", "The Girl on the Train" },
                 { "author", "Paula Hawkins" },
                 { "pages", 395 },
                 { "published_year", 2015 },
                 { "category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "id", 63 },
                 { "name", "Me Before You" },
                 { "author", "Jojo Moyes" },
                 { "pages", 369 },
                 { "published_year", 2012 },
                 { "category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "id", 64 },
                 { "name", "The Night Circus" },
                 { "author", "Erin Morgenstern" },
                 { "pages", 387 },
                 { "published_year", 2011 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 65 },
                 { "name", "The Help" },
                 { "author", "Kathryn Stockett" },
                 { "pages", 464 },
                 { "published_year", 2009 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 66 },
                 { "name", "The Road" },
                 { "author", "Cormac McCarthy" },
                 { "pages", 287 },
                 { "published_year", 2006 },
                 { "category", "Post-Apocalyptic" }
             },
             new Dictionary<string, object>
             {
                 { "id", 67 },
                 { "name", "The Secret History" },
                 { "author", "Donna Tartt" },
                 { "pages", 559 },
                 { "published_year", 1992 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 68 },
                 { "name", "Big Little Lies" },
                 { "author", "Liane Moriarty" },
                 { "pages", 460 },
                 { "published_year", 2014 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 69 },
                 { "name", "The Maze Runner" },
                 { "author", "James Dashner" },
                 { "pages", 375 },
                 { "published_year", 2009 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 70 },
                 { "name", "Divergent" },
                 { "author", "Veronica Roth" },
                 { "pages", 487 },
                 { "published_year", 2011 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 71 },
                 { "name", "The Lovely Bones" },
                 { "author", "Alice Sebold" },
                 { "pages", 328 },
                 { "published_year", 2002 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 72 },
                 { "name", "The Time Traveler's Wife" },
                 { "author", "Audrey Niffenegger" },
                 { "pages", 518 },
                 { "published_year", 2003 },
                 { "category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 73 },
                 { "name", "Memoirs of a Geisha" },
                 { "author", "Arthur Golden" },
                 { "pages", 428 },
                 { "published_year", 1997 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 74 },
                 { "name", "The Perks of Being a Wallflower" },
                 { "author", "Stephen Chbosky" },
                 { "pages", 213 },
                 { "published_year", 1999 },
                 { "category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "id", 75 },
                 { "name", "The Giver" },
                 { "author", "Lois Lowry" },
                 { "pages", 240 },
                 { "published_year", 1993 },
                 { "category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "id", 76 },
                 { "name", "Water for Elephants" },
                 { "author", "Sara Gruen" },
                 { "pages", 335 },
                 { "published_year", 2006 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 77 },
                 { "name", "The Poisonwood Bible" },
                 { "author", "Barbara Kingsolver" },
                 { "pages", 546 },
                 { "published_year", 1998 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 78 },
                 { "name", "Room" },
                 { "author", "Emma Donoghue" },
                 { "pages", 321 },
                 { "published_year", 2010 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 79 },
                 { "name", "A Thousand Splendid Suns" },
                 { "author", "Khaled Hosseini" },
                 { "pages", 372 },
                 { "published_year", 2007 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 80 },
                 { "name", "Shantaram" },
                 { "author", "Gregory David Roberts" },
                 { "pages", 936 },
                 { "published_year", 2003 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 81 },
                 { "name", "The Stand" },
                 { "author", "Stephen King" },
                 { "pages", 1153 },
                 { "published_year", 1978 },
                 { "category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "id", 82 },
                 { "name", "The Goldfinch" },
                 { "author", "Donna Tartt" },
                 { "pages", 771 },
                 { "published_year", 2013 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 83 },
                 { "name", "The Shadow of the Wind" },
                 { "author", "Carlos Ruiz Zafón" },
                 { "pages", 487 },
                 { "published_year", 2001 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 84 },
                 { "name", "Cloud Atlas" },
                 { "author", "David Mitchell" },
                 { "pages", 509 },
                 { "published_year", 2004 },
                 { "category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 85 },
                 { "name", "The Nightingale" },
                 { "author", "Kristin Hannah" },
                 { "pages", 440 },
                 { "published_year", 2015 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 86 },
                 { "name", "The Secret Life of Bees" },
                 { "author", "Sue Monk Kidd" },
                 { "pages", 336 },
                 { "published_year", 2001 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 87 },
                 { "name", "The Light Between Oceans" },
                 { "author", "M.L. Stedman" },
                 { "pages", 362 },
                 { "published_year", 2012 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 88 },
                 { "name", "The Guernsey Literary and Potato Peel Pie Society" },
                 { "author", "Mary Ann Shaffer & Annie Barrows" },
                 { "pages", 274 },
                 { "published_year", 2008 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 89 },
                 { "name", "The Rosie Project" },
                 { "author", "Graeme Simsion" },
                 { "pages", 295 },
                 { "published_year", 2013 },
                 { "category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "id", 90 },
                 { "name", "All the Light We Cannot See" },
                 { "author", "Anthony Doerr" },
                 { "pages", 531 },
                 { "published_year", 2014 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 91 },
                 { "name", "The Hate U Give" },
                 { "author", "Angie Thomas" },
                 { "pages", 444 },
                 { "published_year", 2017 },
                 { "category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "id", 92 },
                 { "name", "Educated" },
                 { "author", "Tara Westover" },
                 { "pages", 334 },
                 { "published_year", 2018 },
                 { "category", "Memoir" }
             },
             new Dictionary<string, object>
             {
                 { "id", 93 },
                 { "name", "Where the Crawdads Sing" },
                 { "author", "Delia Owens" },
                 { "pages", 370 },
                 { "published_year", 2018 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 94 },
                 { "name", "Becoming" },
                 { "author", "Michelle Obama" },
                 { "pages", 426 },
                 { "published_year", 2018 },
                 { "category", "Memoir" }
             },
             new Dictionary<string, object>
             {
                 { "id", 95 },
                 { "name", "Little Fires Everywhere" },
                 { "author", "Celeste Ng" },
                 { "pages", 338 },
                 { "published_year", 2017 },
                 { "category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 96 },
                 { "name", "Circe" },
                 { "author", "Madeline Miller" },
                 { "pages", 393 },
                 { "published_year", 2018 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 97 },
                 { "name", "The Silent Patient" },
                 { "author", "Alex Michaelides" },
                 { "pages", 325 },
                 { "published_year", 2019 },
                 { "category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "id", 98 },
                 { "name", "The Night Watchman" },
                 { "author", "Louise Erdrich" },
                 { "pages", 464 },
                 { "published_year", 2020 },
                 { "category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "id", 99 },
                 { "name", "The Invisible Life of Addie LaRue" },
                 { "author", "V.E. Schwab" },
                 { "pages", 442 },
                 { "published_year", 2020 },
                 { "category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "id", 100 },
                 { "name", "The Vanishing Half" },
                 { "author", "Brit Bennett" },
                 { "pages", 352 },
                 { "published_year", 2020 },
                 { "category", "Fiction" }
             }
        };

    }
}
