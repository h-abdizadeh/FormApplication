using BookStore.Database;
using BookStore.Models;
using BookStore.ViewModels;

namespace BookStore;

public class Manage
{
    private static DatabaseContext context = new DatabaseContext();

    public bool AddBook(Book book)
    {
        try
        {
            context.Books.Add(book);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            //throw;
            return false;
        }

    }

    //public List<BookViewModel> GetBooks()
    public dynamic GetBooks()
    {
        var books = context.Books.Select(b => new BookViewModel()
        {
            Id = b.Id,
            Name = b.Name,
            Writer = b.Writer,
            Publisher = b.Publisher,
            GroupName = GetGroupName(b.GroupId),
            Status = b.NotExists ? "ناموجود" : "موجود"
        }).ToList();
        return books;
    }

    public List<BookViewModel> GetBooks(string search)
    {
        var books = context.Books.Where(b => b.Name.Contains(search) ||
                                             b.Writer.Contains(search) ||
                                             b.Publisher.Contains(search))
            .Select(b => new BookViewModel()
            {
                Id = b.Id,
                Name = b.Name,
                Writer = b.Writer,
                Publisher = b.Publisher,
                GroupName = GetGroupName(b.GroupId),
                Status = b.NotExists ? "ناموجود" : "موجود"
            }).ToList();

        return books;
    }
    public List<Group> GetGroups()
    {
        var groups = context.Groups.ToList();

        return groups;
    }
    public int GetGroupId(string groupName)
    {
        var group = context.Groups.FirstOrDefault(g => g.Name == groupName);

        return group.Id;
    }

    public static string GetGroupName(int groupId)
    {
        var groupName = context.Groups.Find(groupId).Name;
        return groupName;
    }
    
    public string GetGroup(int groupId)
    {
        var groupName = context.Groups.Find(groupId).Name;
        return groupName;
    }

    public bool DeleteBook(int bookId)
    {
        var book = context.Books.Find(bookId);//base on primary key

        //if book null
        if (book == null) return false;

        //if book not null
        context.Books.Remove(book);
        context.SaveChanges();
        return true;
    }

    public Book GetBook(int bookId)
    {
        var book = context.Books.Find(bookId);
        return book;
    }


   public bool EditBook(Book book)
    {
        try
        {
            //context.Books.Update(book);

            var myBook = context.Books.FirstOrDefault(b=>b.Id==book.Id);

            myBook.Name=book.Name;
            myBook.Writer = book.Writer;
            myBook.Publisher= book.Publisher;
            myBook.NotExists= book.NotExists;
            myBook.GroupId= book.GroupId;

            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {

            throw;
            return false;
        }
    }
}
