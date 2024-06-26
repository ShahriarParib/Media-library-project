using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    public class MEDIA<T>//using generic class
    {
        public T Title { get; set; }
        public T Author { get; set; }
        public T Releaseyear { get; set; }
        public T Producer { get; set; }
        public T Editor { get; set; }
        public T Singer { get; set; }

        public MEDIA(T title, T author, T releaseyear)
        {
            this.Title = title;
            this.Author = author;
            this.Releaseyear = releaseyear;
        }
        public MEDIA()
        {
        }
    }
    public class BOOKs : MEDIA<string>
    {
        public string Editor { get; set; }
        public BOOKs(string title, string author, string releaseyear, string editor) : base(title, author, releaseyear)
        {
            Editor = editor;
        }
        public BOOKs()
        {

        }
    }
    public class DVDs : MEDIA<string>
    {
        public string Producer { get; set; }
        public DVDs(string title, string author, string releaseyear, string producer) : base(title, author, releaseyear)
        {
            this.Producer = producer;
        }

        public DVDs()
        {

        }
    }
    public class CDs : MEDIA<string>
    {
        public string Singer { get; set; }
        public CDs(string title, string author, string releaseyear, string singer) : base(title, author, releaseyear)
        {
            Singer = singer;
        }

        public CDs()
        {

        }
    }
    public delegate void Modified_details(List<MEDIA<string>> media);//using delegate
    public partial class labratory//using partial classes
    {
        public void showdetails(List<MEDIA<string>> media)

        {
            int counter = 1;

            foreach (MEDIA<string> mediaItem in media)
            {
                if (mediaItem is BOOKs)
                {

                    Console.WriteLine($"ID:{counter} Type:BOOK Title: {((BOOKs)mediaItem).Title} Author: {((BOOKs)mediaItem).Author} Release Year: {((BOOKs)mediaItem).Releaseyear} Editor: {((BOOKs)mediaItem).Editor}\n");

                }

                else if (mediaItem is DVDs)
                {
                    Console.WriteLine($"ID:{counter} Type:DVD Title: {((DVDs)mediaItem).Title} Author: {((DVDs)mediaItem).Author} Release Year: {((DVDs)mediaItem).Releaseyear} Producer: {((DVDs)mediaItem).Producer}\n");

                }
                else if (mediaItem is CDs)
                {
                    Console.WriteLine($"ID:{counter} TYPE:CD Title: {((CDs)mediaItem).Title} Author: {((CDs)mediaItem).Author} Release Year: {((CDs)mediaItem).Releaseyear} Singer: {((CDs)mediaItem).Singer}\n");

                }
                counter++;
            }
        }
        public void showdetailsb(List<MEDIA<string>> media)

        {
            

            foreach (MEDIA<string> mediaItem in media)
            {
                if (mediaItem is BOOKs)
                {

                    Console.WriteLine($"Type:BOOK Title: {((BOOKs)mediaItem).Title} Author: {((BOOKs)mediaItem).Author} Release Year: {((BOOKs)mediaItem).Releaseyear} Editor: {((BOOKs)mediaItem).Editor}\n");

                }
            }
        }
        public void showdetailsd(List<MEDIA<string>> media)

        {
            

            foreach (MEDIA<string> mediaItem in media)
            {


                if (mediaItem is DVDs)
                {
                    Console.WriteLine($"Type:DVD Title: {((DVDs)mediaItem).Title} Author: {((DVDs)mediaItem).Author} Release Year: {((DVDs)mediaItem).Releaseyear} Producer: {((DVDs)mediaItem).Producer}\n");

                }
            }
        }
        public void showdetailsc(List<MEDIA<string>> media)

        {
            

            foreach (MEDIA<string> mediaItem in media)
            {
                   if (mediaItem is CDs)
                {
                    Console.WriteLine($"TYPE:CD Title: {((CDs)mediaItem).Title} Author: {((CDs)mediaItem).Author} Release Year: {((CDs)mediaItem).Releaseyear} Singer: {((CDs)mediaItem).Singer}\n");

                }

            }
        }
    }

    public partial class labratory//using partial classes
    {
        public void Bookcount(List<MEDIA<string>> list)
        {
            {
                int bookcount = list.OfType<BOOKs>().Count();//using linq
                Console.WriteLine($"Number of BOOKS:{bookcount}\n");
            }
        }
        public void Dvdcount(List<MEDIA<string>> list)
        {
            {
                int dvdcount = list.OfType<DVDs>().Count();//using linq expressions
                Console.WriteLine($"Number of BOOKS:{dvdcount}\n");
            }
        }
        public void Cdcount(List<MEDIA<string>> list)
        {
            {
                int cdcount = list.OfType<CDs>().Count();//using linq
                Console.WriteLine($"Number of CDS:{cdcount}\n");
            }
        }
        public void tcount(List<MEDIA<string>> list)
        {
            {
                int tcount = list.Count();
                Console.WriteLine($"Number of Medias:{tcount}\n");
            }
        }

    }

    public class program
    {
        static void Main(string[] args)
        {
            List<MEDIA<string>> list = new List<MEDIA<string>>();//list of media objects

            list.Add(new BOOKs("1984", "George orwell", "1949", "Toy hahaoff"));
            list.Add(new BOOKs("The Catcher in the Rye", "Salinger", "1951", "Maxwell"));
            list.Add(new BOOKs("Pride and Prejudice", "Jane Austen", "1813", "Shawn"));
            list.Add(new BOOKs("The Habbit", "Tolkien", "1937", "Stanley"));
            list.Add(new BOOKs("The Da VInci Code", "Dan Brawn", "2003", "Kaufman"));
            list.Add(new DVDs("Inception", "Nolan", "2010", "Thomas"));
            list.Add(new DVDs("The Shawshank redemption", "Frank Darabont", "1994", "Marvin"));
            list.Add(new DVDs("Titanic", "James Cameron", "1997", "Landau"));
            list.Add(new DVDs("The Godfther", "Ford Coppola", "1972", "Ruddy"));
            list.Add(new DVDs("Avatar", "James Cameron", "2009", "Landau"));
            list.Add(new DVDs("The Dark Knight", "Nolan", "2008", "Roven"));
            list.Add(new CDs("Thriller", "MIchael Jackson", "1982", "Michael Jackson"));
            list.Add(new CDs("Abbey Road", "The Beatles", "1969", "John Lennon"));
            list.Add(new CDs("Back to Black", "Amy Winehouse", "2006", "Amy Winehouse"));
            list.Add(new CDs("The Dark Side of the Moon", "Pink floyd", "1973", "Richard Wright"));
            list.Add(new CDs("21", "Adele", "2011", "Adele"));
            list.Add(new DVDs("Forrest Grumph", "", "1994", "Steve Tisch"));
            list.Add(new DVDs("The Matrix", "", "1999", "Joel Silver"));
            list.Add(new DVDs("Jurassic Park", "", "1993", "R.Molen"));
            list.Add(new DVDs("Inglorious Basterds", "", "2009", "Lawrence Bender"));
            List<MEDIA<string>> list2 = new List<MEDIA<string>>(list);




        portion1:
            {

                Console.WriteLine("1.ADD A MEDIA ITEM\n2.SHOW THE LIST\n3.UPDATE THE EXISTINGS\n4.REMOVE A MEDIA\n5.STATISTICS\n6.SEARCH A MEDIA OBJECT\n7.EXIT\n");

                while (true)
                {
                    int f = int.Parse(Console.ReadLine());
                    switch (f)
                    {
                        case 1:

                            {
                                Console.WriteLine("1.BOOK\n2.DVD\n3.CD\n4.Back");
                                int n = int.Parse(Console.ReadLine());
                                if (n == 1)
                                {
                                    BOOKs book = new BOOKs();
                                    Console.WriteLine("Title is:");
                                    string title = Console.ReadLine();
                                    Console.WriteLine("Author is:");
                                    string author = Console.ReadLine();
                                    Console.WriteLine("Releaseyear is:");
                                    string releaseyear = Console.ReadLine();
                                    Console.WriteLine("Editor is:");
                                    string editor = Console.ReadLine();

                                    book.Title = title;
                                    book.Author = author;
                                    book.Releaseyear = releaseyear;
                                    book.Editor = editor;
                                    list.Add(book);
                                    list2.Add(book);

                                    goto portion1;

                                }
                                else if (n == 2)
                                {

                                    DVDs dvd = new DVDs();
                                    Console.WriteLine("Title is:");
                                    string title = Console.ReadLine();
                                    Console.WriteLine("Author is:");
                                    string author = Console.ReadLine();
                                    Console.WriteLine("Releaseyear is:");
                                    string releaseyear = Console.ReadLine();
                                    Console.WriteLine("Producer is:");
                                    string producer = Console.ReadLine();
                                    dvd.Title = title;
                                    dvd.Author = author;
                                    dvd.Releaseyear = releaseyear;
                                    dvd.Producer = producer;
                                    list.Add(dvd);
                                    list2.Add(dvd);

                                    goto portion1;
                                }
                                else if (n == 3)
                                {

                                    CDs cd = new CDs();
                                    Console.WriteLine("Title is:");
                                    string title = Console.ReadLine();
                                    Console.WriteLine("Author is:");
                                    string author = Console.ReadLine();
                                    Console.WriteLine("Releaseyear is:");
                                    string releaseyear = Console.ReadLine();
                                    Console.WriteLine("Singer is:");
                                    string singer = Console.ReadLine();
                                    cd.Title = title;
                                    cd.Author = author;
                                    cd.Releaseyear = releaseyear;
                                    cd.Singer = singer;
                                    list.Add(cd);
                                    list2.Add(cd);


                                    goto portion1;

                                }
                                else if (n == 4)
                                {
                                    goto portion1;
                                }
                                break;
                            }
                        case 2:

                            {
                                labratory myobj = new labratory();
                                Console.WriteLine("1.SHOW ALL MEDIAS\n2.SHOW BOOKS\n3.SHOW DVDS\n4.SHOW CDS\n5.BACK\n");
                                int g=int.Parse(Console.ReadLine());
                                if (g == 1)
                                {
                                    myobj.showdetails(list);
                                    goto portion1;

                                }
                                else if(g == 2) 
                                {
                                    myobj.showdetailsb(list);
                                    goto portion1;
                                }
                               else if (g == 3)
                                {
                                    myobj.showdetailsd(list);
                                    goto portion1;
                                }
                                else if (g == 4)
                                {
                                    myobj.showdetailsc(list);
                                    goto portion1;
                                }
                                else if(g==5)
                                {
                                    goto portion1;
                                }


                                break;
                            }

                        case 3:
                        portion2:
                            {
                                {
                                    Console.WriteLine("1.BOOK\n2.DVD\n3.CD\n4.Back");
                                    int x = int.Parse(Console.ReadLine());
                                    if (x == 1)
                                    {
                                        Console.WriteLine("What is the Id number of the BOOK?");
                                        int y = int.Parse(Console.ReadLine());

                                        Console.WriteLine("What do u want to edit?\n1.Title\n2.Author\n3.ReleaseYear\n4.Editor");
                                        int z = int.Parse(Console.ReadLine());
                                        if (z == 1)
                                        {
                                            Console.WriteLine("New Title:");
                                            string ntitle = Console.ReadLine();
                                            list[y - 1].Title = ntitle;
                                            goto portion1;

                                        }
                                        else if (z == 2)
                                        {
                                            Console.WriteLine("New Author:");
                                            string nauthor = Console.ReadLine();
                                            list[y - 1].Author = nauthor;
                                            goto portion1;
                                        }
                                        else if (z == 3)
                                        {
                                            Console.WriteLine("New ReleaseYear:");
                                            string nreleaseyear = Console.ReadLine();
                                            list[y - 1].Releaseyear = nreleaseyear;
                                            goto portion1;

                                        }
                                        else if (z == 4)
                                        {
                                            Console.WriteLine("New Editor:");
                                            string neditor = Console.ReadLine();
                                            ((BOOKs)list[y - 1]).Editor = neditor;
                                            goto portion1;
                                        }
                                    }
                                    else if (x == 2)
                                    {
                                        Console.WriteLine("What is the ID number of the DVD?");
                                        int m = int.Parse(Console.ReadLine());

                                        Console.WriteLine("What do u want to edit?\n1.Title\n2.Author\n3.ReleaseYear\n4.Producer");
                                        int k = int.Parse(Console.ReadLine());
                                        if (k == 1)
                                        {
                                            Console.WriteLine("New Title:");
                                            string ntitle = Console.ReadLine();
                                            list[m - 1].Title = ntitle;
                                            goto portion1;

                                        }
                                        else if (k == 2)
                                        {
                                            Console.WriteLine("New Author:");
                                            string nauthor = Console.ReadLine();
                                            list[m - 1].Author = nauthor;
                                            goto portion1;
                                        }
                                        else if (k == 3)
                                        {
                                            Console.WriteLine("New ReleaseYear:");
                                            string nreleaseyear = Console.ReadLine();
                                            list[m - 1].Releaseyear = nreleaseyear;
                                            goto portion1;
                                        }
                                        else if (k == 4)
                                        {
                                            Console.WriteLine("New Producer:");
                                            string nproducer = Console.ReadLine();
                                            ((DVDs)list[m - 1]).Producer = nproducer;
                                            goto portion1;
                                        }

                                    }
                                    else if (x == 3)
                                    {
                                        Console.WriteLine("What is the ID number of the CD?");
                                        int p = int.Parse(Console.ReadLine());

                                        Console.WriteLine("What do u want to edit?\n1.Title\n2.Author\n3.ReleaseYear\n4.Singer\n");
                                        int r = int.Parse(Console.ReadLine());
                                        if (r == 1)
                                        {
                                            Console.WriteLine("New Title:");
                                            string ntitle = Console.ReadLine();
                                            list[p - 1].Title = ntitle;
                                            goto portion1;
                                        }
                                        else if (r == 2)
                                        {
                                            Console.WriteLine("New Author:");
                                            string nauthor = Console.ReadLine();
                                            list[p - 1].Author = nauthor;
                                            goto portion1;
                                        }
                                        else if (r == 3)
                                        {
                                            Console.WriteLine("New ReleaseYear:");
                                            string nreleaseyear = Console.ReadLine();
                                            ((CDs)list[p - 1]).Releaseyear = nreleaseyear;
                                            goto portion1;
                                        }
                                        else if (r == 4)
                                        {
                                            Console.WriteLine("New Singer:");
                                            string nsinger = Console.ReadLine();
                                            list[p - 1].Singer = nsinger;
                                            goto portion1;
                                        }

                                    }
                                    else if (x == 4)
                                    {
                                        goto portion1;
                                    }
                                }
                                break;
                            }
                        case 4:
                            {

                                Console.WriteLine("1.BOOK\n2.DVD\n3.CD\n4.Back");
                                int x = int.Parse(Console.ReadLine());
                                if (x == 1)
                                {
                                    Console.WriteLine("Want to delete by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int e = int.Parse(Console.ReadLine());
                                    if (e == 1)
                                    {
                                        Console.WriteLine("What is the Title of the BOOK?");
                                        string sr = Console.ReadLine();
                                        list = list.Where(b => b.Title != sr).ToList();//using linq
                                        goto portion1;
                                    }
                                    else if (e == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the BOOK?");
                                        string ar = Console.ReadLine();
                                        list = list.Where(b => b.Author != ar).ToList();
                                        goto portion1;
                                    }
                                    else if (e == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the BOOK?");
                                        string rr = Console.ReadLine();
                                        list = list.Where(b => b.Releaseyear != rr).ToList();
                                        goto portion1;
                                    }

                                }

                                if (x == 2)
                                {
                                    Console.WriteLine("Want to delete by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int l = int.Parse(Console.ReadLine());
                                    if (l == 1)
                                    {
                                        Console.WriteLine("What is the Title of the DVD?");
                                        string sr = Console.ReadLine();
                                        list = list.Where(b => b.Title != sr).ToList();
                                        goto portion1;
                                    }
                                    else if (l == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the DVD?");
                                        string ar = Console.ReadLine();
                                        list = list.Where(b => b.Author != ar).ToList();//using linq
                                        goto portion1;
                                    }
                                    else if (l == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the DVD?");
                                        string rr = Console.ReadLine();
                                        list = list.Where(b => b.Releaseyear != rr).ToList();//using linq
                                        goto portion1;
                                    }

                                }
                                if (x == 3)
                                {
                                    Console.WriteLine("Want to delete by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int l = int.Parse(Console.ReadLine());
                                    if (l == 1)
                                    {
                                        Console.WriteLine("What is the Title of the CD?");
                                        string sr = Console.ReadLine();
                                        list = list.Where(b => b.Title != sr).ToList();//using linq 
                                        goto portion1;
                                    }
                                    else if (l == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the CD?");
                                        string ar = Console.ReadLine();
                                        list = list.Where(b => b.Author != ar).ToList();//using linqq
                                        goto portion1;
                                    }
                                    else if (l == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the CD?");
                                        string rr = Console.ReadLine();
                                        list = list.Where(b => b.Releaseyear != rr).ToList();
                                        goto portion1;
                                    }

                                }
                                if (x == 4)
                                {
                                    goto portion1;
                                }
                                break;

                            }


                        case 5:
                        portion4:
                            {
                                {
                                    Console.WriteLine("1.Number of BOOKS\n2.Number of DVDs\n3.Number of CDS\n4.Total Number of Media\n5.Back");
                                    int w = int.Parse(Console.ReadLine());
                                    labratory myobj1 = new labratory();
                                    if (w == 1)
                                    {
                                        myobj1.Bookcount(list);
                                        goto portion4;
                                    }
                                    else if (w == 2)
                                    {
                                        myobj1.Dvdcount(list);
                                        goto portion4;
                                    }
                                    else if (w == 3)
                                    {
                                        myobj1.Cdcount(list);
                                        goto portion4;
                                    }
                                    else if(w==4)
                                    {
                                        myobj1.tcount(list);
                                        goto portion4;
                                    }
                                    else if (w == 5)
                                    {
                                        goto portion1;
                                    }

                                }
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("1.BOOK\n2.DVD\n3.CD\n4.Back");
                                int x = int.Parse(Console.ReadLine());
                                if (x == 1)
                                {
                                    Console.WriteLine("Want to Search by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int e = int.Parse(Console.ReadLine());
                                    if (e == 1)
                                    {
                                       
                                        Console.WriteLine("What is the Title of the BOOK?");
                                        string sr = Console.ReadLine();
                                       
                                            list2 = list2.Where(b => b.Title == sr).ToList();//using linq
                                            labratory myobj1 = new labratory();
                                            myobj1.showdetails(list2);
                                            goto portion1;
                                        
                                        
                                       

                                    }
                                    else if (e == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the BOOK?");
                                        string ar = Console.ReadLine();
                                        list2= list2.Where(b => b.Author == ar).ToList();
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }
                                    else if (e == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the BOOK?");
                                        string rr = Console.ReadLine();
                                        list2 = list2.Where(b => b.Releaseyear == rr).ToList();
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }

                                }

                                if (x == 2)
                                {
                                    Console.WriteLine("Want to Search by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int l = int.Parse(Console.ReadLine());
                                    if (l == 1)
                                    {
                                        Console.WriteLine("What is the Title of the DVD?");
                                        string sr = Console.ReadLine();
                                        list2 = list2.Where(b => b.Title == sr).ToList();
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }
                                    else if (l == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the DVD?");
                                        string ar = Console.ReadLine();
                                        list2 = list2.Where(b => b.Author == ar).ToList();//using linq
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }
                                    else if (l == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the DVD?");
                                        string rr = Console.ReadLine();
                                        list2 = list2.Where(b => b.Releaseyear == rr).ToList();//using linq
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }

                                }
                                if (x == 3)
                                {
                                    Console.WriteLine("Want to Search by?\n1.Title\n2.Author\n3.Releaseyear\n");
                                    int l = int.Parse(Console.ReadLine());
                                    if (l == 1)
                                    {
                                        Console.WriteLine("What is the Title of the CD?");
                                        string sr = Console.ReadLine();
                                        list2 = list2.Where(b => b.Title == sr).ToList();//using linq 
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }
                                    else if (l == 2)
                                    {
                                        Console.WriteLine("Who is the Author of the CD?");
                                        string ar = Console.ReadLine();
                                        list2 = list2.Where(b => b.Author == ar).ToList();//using linqq
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }
                                    else if (l == 3)
                                    {
                                        Console.WriteLine("When is the Releaseyear of the CD?");
                                        string rr = Console.ReadLine();
                                        list2 = list2.Where(b => b.Releaseyear == rr).ToList();
                                        labratory myobj1 = new labratory();
                                        myobj1.showdetails(list2);
                                        goto portion1;
                                    }

                                }
                                if (x == 4)
                                {
                                    goto portion1;
                                }

                                
                                break;

                            }
                        case 7:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }


        }


    }
}
    

   

    

