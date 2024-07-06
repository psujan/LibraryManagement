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
                { "Id", 1 },
                { "Name", "To Kill a Mockingbird" },
                { "Author", "Harper Lee" },
                { "Pages", 281 },
                { "PublishedYear", 1960 },
                { "Category", "Fiction" }
            },
             new Dictionary<string, object>
            {
                { "Id", 2 },
                { "Name", "1984" },
                { "Author", "George Orwell" },
                { "Pages", 328 },
                { "PublishedYear", 1949 },
                { "Category", "Dystopian" }
            },
             new Dictionary<string, object>
        {
            { "Id", 3 },
            { "Name", "Moby Dick" },
            { "Author", "Herman Melville" },
            { "Pages", 635 },
            { "PublishedYear", 1851 },
            { "Category", "Adventure" }
        },
             new Dictionary<string, object>
        {
            { "Id", 4 },
            { "Name", "PrIde and Prejudice" },
            { "Author", "Jane Austen" },
            { "Pages", 279 },
            { "PublishedYear", 1813 },
            { "Category", "Romance" }
        },
             new Dictionary<string, object>
        {
            { "Id", 5 },
            { "Name", "The Great Gatsby" },
            { "Author", "F. Scott Fitzgerald" },
            { "Pages", 180 },
            { "PublishedYear", 1925 },
            { "Category", "Fiction" }
        },
             new Dictionary<string, object>
        {
            { "Id", 6 },
            { "Name", "War and Peace" },
            { "Author", "Leo Tolstoy" },
            { "Pages", 1225 },
            { "PublishedYear", 1869 },
            { "Category", "Historical Fiction" }
        },
             new Dictionary<string, object>
            {
                { "Id", 7 },
                { "Name", "The Catcher in the Rye" },
                { "Author", "J.D. Salinger" },
                { "Pages", 214 },
                { "PublishedYear", 1951 },
                { "Category", "Fiction" }
            },
             new Dictionary<string, object>
             {
                 { "Id", 8 },
                 { "Name", "The Hobbit" },
                 { "Author", "J.R.R. Tolkien" },
                 { "Pages", 310 },
                 { "PublishedYear", 1937 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 9 },
                 { "Name", "Brave New World" },
                 { "Author", "Aldous Huxley" },
                 { "Pages", 268 },
                 { "PublishedYear", 1932 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 10 },
                 { "Name", "Crime and Punishment" },
                 { "Author", "Fyodor Dostoevsky" },
                 { "Pages", 671 },
                 { "PublishedYear", 1866 },
                 { "Category", "Psychological Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 11 },
                 { "Name", "Jane Eyre" },
                 { "Author", "Charlotte Brontë" },
                 { "Pages", 500 },
                 { "PublishedYear", 1847 },
                 { "Category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 12 },
                 { "Name", "Wuthering Heights" },
                 { "Author", "Emily Brontë" },
                 { "Pages", 416 },
                 { "PublishedYear", 1847 },
                 { "Category", "Gothic Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 13 },
                 { "Name", "Great Expectations" },
                 { "Author", "Charles Dickens" },
                 { "Pages", 505 },
                 { "PublishedYear", 1861 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 14 },
                 { "Name", "The Odyssey" },
                 { "Author", "Homer" },
                 { "Pages", 541 },
                 { "PublishedYear", -800 },
                 { "Category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 15 },
                 { "Name", "Ulysses" },
                 { "Author", "James Joyce" },
                 { "Pages", 730 },
                 { "PublishedYear", 1922 },
                 { "Category", "Modernist Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 16 },
                 { "Name", "The Divine Comedy" },
                 { "Author", "Dante Alighieri" },
                 { "Pages", 798 },
                 { "PublishedYear", 1320 },
                 { "Category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 17 },
                 { "Name", "The Brothers Karamazov" },
                 { "Author", "Fyodor Dostoevsky" },
                 { "Pages", 796 },
                 { "PublishedYear", 1880 },
                 { "Category", "Philosophical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 18 },
                 { "Name", "Les Misérables" },
                 { "Author", "Victor Hugo" },
                 { "Pages", 1232 },
                 { "PublishedYear", 1862 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 19 },
                 { "Name", "Anna Karenina" },
                 { "Author", "Leo Tolstoy" },
                 { "Pages", 864 },
                 { "PublishedYear", 1878 },
                 { "Category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 20 },
                 { "Name", "One Hundred Years of Solitude" },
                 { "Author", "Gabriel Garcia Marquez" },
                 { "Pages", 417 },
                 { "PublishedYear", 1967 },
                 { "Category", "Magic Realism" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 21 },
                 { "Name", "Don Quixote" },
                 { "Author", "Miguel de Cervantes" },
                 { "Pages", 1072 },
                 { "PublishedYear", 1615 },
                 { "Category", "Satire" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 22 },
                 { "Name", "The Iliad" },
                 { "Author", "Homer" },
                 { "Pages", 704 },
                 { "PublishedYear", -750 },
                 { "Category", "Epic Poetry" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 23 },
                 { "Name", "The Picture of Dorian Gray" },
                 { "Author", "Oscar Wilde" },
                 { "Pages", 254 },
                 { "PublishedYear", 1890 },
                 { "Category", "Philosophical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 24 },
                 { "Name", "Frankenstein" },
                 { "Author", "Mary Shelley" },
                 { "Pages", 280 },
                 { "PublishedYear", 1818 },
                 { "Category", "Gothic Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 25 },
                 { "Name", "Dracula" },
                 { "Author", "Bram Stoker" },
                 { "Pages", 418 },
                 { "PublishedYear", 1897 },
                 { "Category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 26 },
                 { "Name", "Heart of Darkness" },
                 { "Author", "Joseph Conrad" },
                 { "Pages", 122 },
                 { "PublishedYear", 1899 },
                 { "Category", "Novella" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 27 },
                 { "Name", "The Metamorphosis" },
                 { "Author", "Franz Kafka" },
                 { "Pages", 201 },
                 { "PublishedYear", 1915 },
                 { "Category", "Absurdist Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 28 },
                 { "Name", "The Trial" },
                 { "Author", "Franz Kafka" },
                 { "Pages", 255 },
                 { "PublishedYear", 1925 },
                 { "Category", "Existential Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 29 },
                 { "Name", "MIddlemarch" },
                 { "Author", "George Eliot" },
                 { "Pages", 904 },
                 { "PublishedYear", 1871 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 30 },
                 { "Name", "The Count of Monte Cristo" },
                 { "Author", "Alexandre Dumas" },
                 { "Pages", 1276 },
                 { "PublishedYear", 1844 },
                 { "Category", "Adventure" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 31 },
                 { "Name", "Madame Bovary" },
                 { "Author", "Gustave Flaubert" },
                 { "Pages", 329 },
                 { "PublishedYear", 1857 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 32 },
                 { "Name", "The Old Man and the Sea" },
                 { "Author", "Ernest Hemingway" },
                 { "Pages", 127 },
                 { "PublishedYear", 1952 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 33 },
                 { "Name", "A Tale of Two Cities" },
                 { "Author", "Charles Dickens" },
                 { "Pages", 489 },
                 { "PublishedYear", 1859 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 34 },
                 { "Name", "Fahrenheit 451" },
                 { "Author", "Ray Bradbury" },
                 { "Pages", 194 },
                 { "PublishedYear", 1953 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 35 },
                 { "Name", "The Catch-22" },
                 { "Author", "Joseph Heller" },
                 { "Pages", 453 },
                 { "PublishedYear", 1961 },
                 { "Category", "Satire" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 36 },
                 { "Name", "Lolita" },
                 { "Author", "Vladimir Nabokov" },
                 { "Pages", 336 },
                 { "PublishedYear", 1955 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 37 },
                 { "Name", "Beloved" },
                 { "Author", "Toni Morrison" },
                 { "Pages", 324 },
                 { "PublishedYear", 1987 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 38 },
                 { "Name", "Invisible Man" },
                 { "Author", "Ralph Ellison" },
                 { "Pages", 581 },
                 { "PublishedYear", 1952 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 39 },
                 { "Name", "The Grapes of Wrath" },
                 { "Author", "John Steinbeck" },
                 { "Pages", 464 },
                 { "PublishedYear", 1939 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 40 },
                 { "Name", "Gone with the Wind" },
                 { "Author", "Margaret Mitchell" },
                 { "Pages", 1037 },
                 { "PublishedYear", 1936 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 41 },
                 { "Name", "The Sun Also Rises" },
                 { "Author", "Ernest Hemingway" },
                 { "Pages", 251 },
                 { "PublishedYear", 1926 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 42 },
                 { "Name", "East of Eden" },
                 { "Author", "John Steinbeck" },
                 { "Pages", 601 },
                 { "PublishedYear", 1952 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 43 },
                 { "Name", "Slaughterhouse-Five" },
                 { "Author", "Kurt Vonnegut" },
                 { "Pages", 275 },
                 { "PublishedYear", 1969 },
                 { "Category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 44 },
                 { "Name", "The HandmaId's Tale" },
                 { "Author", "Margaret Atwood" },
                 { "Pages", 311 },
                 { "PublishedYear", 1985 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 45 },
                 { "Name", "Of Mice and Men" },
                 { "Author", "John Steinbeck" },
                 { "Pages", 107 },
                 { "PublishedYear", 1937 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 46 },
                 { "Name", "The Road" },
                 { "Author", "Cormac McCarthy" },
                 { "Pages", 287 },
                 { "PublishedYear", 2006 },
                 { "Category", "Post-Apocalyptic" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 47 },
                 { "Name", "The Catcher in the Rye" },
                 { "Author", "J.D. Salinger" },
                 { "Pages", 214 },
                 { "PublishedYear", 1951 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 48 },
                 { "Name", "The Lord of the Rings" },
                 { "Author", "J.R.R. Tolkien" },
                 { "Pages", 1216 },
                 { "PublishedYear", 1954 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 49 },
                 { "Name", "The Bell Jar" },
                 { "Author", "Sylvia Plath" },
                 { "Pages", 244 },
                 { "PublishedYear", 1963 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 50 },
                 { "Name", "The Shining" },
                 { "Author", "Stephen King" },
                 { "Pages", 447 },
                 { "PublishedYear", 1977 },
                 { "Category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 51 },
                 { "Name", "The Alchemist" },
                 { "Author", "Paulo Coelho" },
                 { "Pages", 208 },
                 { "PublishedYear", 1988 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 52 },
                 { "Name", "Harry Potter and the Sorcerer's Stone" },
                 { "Author", "J.K. Rowling" },
                 { "Pages", 309 },
                 { "PublishedYear", 1997 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 53 },
                 { "Name", "Life of Pi" },
                 { "Author", "Yann Martel" },
                 { "Pages", 319 },
                 { "PublishedYear", 2001 },
                 { "Category", "Adventure" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 54 },
                 { "Name", "The Fault in Our Stars" },
                 { "Author", "John Green" },
                 { "Pages", 313 },
                 { "PublishedYear", 2012 },
                 { "Category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 55 },
                 { "Name", "The Da Vinci Code" },
                 { "Author", "Dan Brown" },
                 { "Pages", 689 },
                 { "PublishedYear", 2003 },
                 { "Category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 56 },
                 { "Name", "A Game of Thrones" },
                 { "Author", "George R.R. Martin" },
                 { "Pages", 694 },
                 { "PublishedYear", 1996 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 57 },
                 { "Name", "The Girl with the Dragon Tattoo" },
                 { "Author", "Stieg Larsson" },
                 { "Pages", 465 },
                 { "PublishedYear", 2005 },
                 { "Category", "Mystery" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 58 },
                 { "Name", "The Hunger Games" },
                 { "Author", "Suzanne Collins" },
                 { "Pages", 374 },
                 { "PublishedYear", 2008 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 59 },
                 { "Name", "Gone Girl" },
                 { "Author", "Gillian Flynn" },
                 { "Pages", 432 },
                 { "PublishedYear", 2012 },
                 { "Category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 60 },
                 { "Name", "The Book Thief" },
                 { "Author", "Markus Zusak" },
                 { "Pages", 552 },
                 { "PublishedYear", 2005 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 61 },
                 { "Name", "The Kite Runner" },
                 { "Author", "Khaled Hosseini" },
                 { "Pages", 371 },
                 { "PublishedYear", 2003 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 62 },
                 { "Name", "The Girl on the Train" },
                 { "Author", "Paula Hawkins" },
                 { "Pages", 395 },
                 { "PublishedYear", 2015 },
                 { "Category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 63 },
                 { "Name", "Me Before You" },
                 { "Author", "Jojo Moyes" },
                 { "Pages", 369 },
                 { "PublishedYear", 2012 },
                 { "Category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 64 },
                 { "Name", "The Night Circus" },
                 { "Author", "Erin Morgenstern" },
                 { "Pages", 387 },
                 { "PublishedYear", 2011 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 65 },
                 { "Name", "The Help" },
                 { "Author", "Kathryn Stockett" },
                 { "Pages", 464 },
                 { "PublishedYear", 2009 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 66 },
                 { "Name", "The Road" },
                 { "Author", "Cormac McCarthy" },
                 { "Pages", 287 },
                 { "PublishedYear", 2006 },
                 { "Category", "Post-Apocalyptic" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 67 },
                 { "Name", "The Secret History" },
                 { "Author", "Donna Tartt" },
                 { "Pages", 559 },
                 { "PublishedYear", 1992 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 68 },
                 { "Name", "Big Little Lies" },
                 { "Author", "Liane Moriarty" },
                 { "Pages", 460 },
                 { "PublishedYear", 2014 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 69 },
                 { "Name", "The Maze Runner" },
                 { "Author", "James Dashner" },
                 { "Pages", 375 },
                 { "PublishedYear", 2009 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 70 },
                 { "Name", "Divergent" },
                 { "Author", "Veronica Roth" },
                 { "Pages", 487 },
                 { "PublishedYear", 2011 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 71 },
                 { "Name", "The Lovely Bones" },
                 { "Author", "Alice Sebold" },
                 { "Pages", 328 },
                 { "PublishedYear", 2002 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 72 },
                 { "Name", "The Time Traveler's Wife" },
                 { "Author", "Audrey Niffenegger" },
                 { "Pages", 518 },
                 { "PublishedYear", 2003 },
                 { "Category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 73 },
                 { "Name", "Memoirs of a Geisha" },
                 { "Author", "Arthur Golden" },
                 { "Pages", 428 },
                 { "PublishedYear", 1997 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 74 },
                 { "Name", "The Perks of Being a Wallflower" },
                 { "Author", "Stephen Chbosky" },
                 { "Pages", 213 },
                 { "PublishedYear", 1999 },
                 { "Category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 75 },
                 { "Name", "The Giver" },
                 { "Author", "Lois Lowry" },
                 { "Pages", 240 },
                 { "PublishedYear", 1993 },
                 { "Category", "Dystopian" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 76 },
                 { "Name", "Water for Elephants" },
                 { "Author", "Sara Gruen" },
                 { "Pages", 335 },
                 { "PublishedYear", 2006 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 77 },
                 { "Name", "The Poisonwood Bible" },
                 { "Author", "Barbara Kingsolver" },
                 { "Pages", 546 },
                 { "PublishedYear", 1998 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 78 },
                 { "Name", "Room" },
                 { "Author", "Emma Donoghue" },
                 { "Pages", 321 },
                 { "PublishedYear", 2010 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 79 },
                 { "Name", "A Thousand SplendId Suns" },
                 { "Author", "Khaled Hosseini" },
                 { "Pages", 372 },
                 { "PublishedYear", 2007 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 80 },
                 { "Name", "Shantaram" },
                 { "Author", "Gregory DavId Roberts" },
                 { "Pages", 936 },
                 { "PublishedYear", 2003 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 81 },
                 { "Name", "The Stand" },
                 { "Author", "Stephen King" },
                 { "Pages", 1153 },
                 { "PublishedYear", 1978 },
                 { "Category", "Horror" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 82 },
                 { "Name", "The Goldfinch" },
                 { "Author", "Donna Tartt" },
                 { "Pages", 771 },
                 { "PublishedYear", 2013 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 83 },
                 { "Name", "The Shadow of the Wind" },
                 { "Author", "Carlos Ruiz Zafón" },
                 { "Pages", 487 },
                 { "PublishedYear", 2001 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 84 },
                 { "Name", "Cloud Atlas" },
                 { "Author", "DavId Mitchell" },
                 { "Pages", 509 },
                 { "PublishedYear", 2004 },
                 { "Category", "Science Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 85 },
                 { "Name", "The Nightingale" },
                 { "Author", "Kristin Hannah" },
                 { "Pages", 440 },
                 { "PublishedYear", 2015 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 86 },
                 { "Name", "The Secret Life of Bees" },
                 { "Author", "Sue Monk KIdd" },
                 { "Pages", 336 },
                 { "PublishedYear", 2001 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 87 },
                 { "Name", "The Light Between Oceans" },
                 { "Author", "M.L. Stedman" },
                 { "Pages", 362 },
                 { "PublishedYear", 2012 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 88 },
                 { "Name", "The Guernsey Literary and Potato Peel Pie Society" },
                 { "Author", "Mary Ann Shaffer & Annie Barrows" },
                 { "Pages", 274 },
                 { "PublishedYear", 2008 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 89 },
                 { "Name", "The Rosie Project" },
                 { "Author", "Graeme Simsion" },
                 { "Pages", 295 },
                 { "PublishedYear", 2013 },
                 { "Category", "Romance" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 90 },
                 { "Name", "All the Light We Cannot See" },
                 { "Author", "Anthony Doerr" },
                 { "Pages", 531 },
                 { "PublishedYear", 2014 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 91 },
                 { "Name", "The Hate U Give" },
                 { "Author", "Angie Thomas" },
                 { "Pages", 444 },
                 { "PublishedYear", 2017 },
                 { "Category", "Young Adult" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 92 },
                 { "Name", "Educated" },
                 { "Author", "Tara Westover" },
                 { "Pages", 334 },
                 { "PublishedYear", 2018 },
                 { "Category", "Memoir" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 93 },
                 { "Name", "Where the Crawdads Sing" },
                 { "Author", "Delia Owens" },
                 { "Pages", 370 },
                 { "PublishedYear", 2018 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 94 },
                 { "Name", "Becoming" },
                 { "Author", "Michelle Obama" },
                 { "Pages", 426 },
                 { "PublishedYear", 2018 },
                 { "Category", "Memoir" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 95 },
                 { "Name", "Little Fires Everywhere" },
                 { "Author", "Celeste Ng" },
                 { "Pages", 338 },
                 { "PublishedYear", 2017 },
                 { "Category", "Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 96 },
                 { "Name", "Circe" },
                 { "Author", "Madeline Miller" },
                 { "Pages", 393 },
                 { "PublishedYear", 2018 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 97 },
                 { "Name", "The Silent Patient" },
                 { "Author", "Alex MichaelIdes" },
                 { "Pages", 325 },
                 { "PublishedYear", 2019 },
                 { "Category", "Thriller" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 98 },
                 { "Name", "The Night Watchman" },
                 { "Author", "Louise Erdrich" },
                 { "Pages", 464 },
                 { "PublishedYear", 2020 },
                 { "Category", "Historical Fiction" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 99 },
                 { "Name", "The Invisible Life of Addie LaRue" },
                 { "Author", "V.E. Schwab" },
                 { "Pages", 442 },
                 { "PublishedYear", 2020 },
                 { "Category", "Fantasy" }
             },
             new Dictionary<string, object>
             {
                 { "Id", 100 },
                 { "Name", "The Vanishing Half" },
                 { "Author", "Brit Bennett" },
                 { "Pages", 352 },
                 { "PublishedYear", 2020 },
                 { "Category", "Fiction" }
             }
        };

    }
}
