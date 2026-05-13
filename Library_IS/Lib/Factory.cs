using Library_IS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Lib
{
    public class Factory
    {
        Repository repo = new Repository(new LibraryEntities());
        //:) :)
        public User InsertUser(User user)
        {
            try
            {
                return repo.InsertEntity(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool IsUserNameTaken(string username)
        {
            try
            {
                return repo.GetEntities<User>().Any(u => u.UserName == username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User AuthenticateUser(string username, string password)
        {
            try
            {
                User user = repo.GetEntityByFilter<User>(p => p.UserName == username);
                if (user != null && user.Password == password)
                {
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
        public List<BookView> GetAvailableBooks()
        {
            try
            {
                return repo.GetEntities<Book>().Where(b => b.UserBook == null).Select(b => new BookView
                {
                    ID_Book = b.ID_Book,
                    Book_Name = b.Book_Name,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    AuthorName = b.Author != null ? b.Author.Name + " " + b.Author.Surname : string.Empty
                    //UserBook = b.UserBook
                }).ToList();
            }
            catch { throw; }

        }

        public List<BookView> GetUserBooks(string username)
        {
            try
            {
                return repo.GetEntities<Book>().Where(b => b.UserBook != null && b.UserBook.UserName == username)
                    .Select(b => new BookView
                    {
                        ID_Book = b.ID_Book,
                        Book_Name = b.Book_Name,
                        ISBN = b.ISBN,
                        Year = b.Year,
                        AuthorName = b.Author != null ? b.Author.Name + " " + b.Author.Surname : string.Empty
                    }).ToList();
            }
            catch { throw; }
        }
        public List<BookView> GetAllBooks()
        {
            try
            {
                return repo.GetEntities<Book>().Select(b => new BookView
                {
                    ID_Book = b.ID_Book,
                    Book_Name = b.Book_Name,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    AuthorName = b.Author != null ? b.Author.Name + " " + b.Author.Surname : string.Empty
                }).ToList();
            }
            catch { throw; }
        }
        public List<UserView> GetAllUsers()
        {
            try
            {
                return repo.GetEntities<User>().Select(u => new UserView
                {
                    UserName = u.UserName,
                    Name = u.Name,
                    Surname = u.Surname,
                    Role = u.Role,
                    Email = u.Email,
                    Phone = u.Phone,
                }).ToList();
            }
            catch { throw; }
        }

        public bool TakeBook(string username, long bookId)
        {
            try
            {
                Book book = repo.GetEntityByFilter<Book>(b => b.ID_Book == bookId);
                if (book != null && book.UserBook == null)
                {
                    UserBook userBook = new UserBook
                    {
                        UserName = username,
                        Id_Book = bookId,
                        PickDate = DateTime.Now
                    };
                    repo.InsertEntity(userBook);
                    return true;
                }
                return false;
            }
            catch { throw; }
        }
        public bool ReturnBook(string username, long bookId)
        {
            try
            {
                UserBook userBook = repo.GetEntityByFilter<UserBook>(ub => ub.UserName == username && ub.Id_Book == bookId);
                if (userBook != null)
                {
                    repo.DeleteEntity(userBook);
                    return true;
                }
                return false;
            }
            catch { throw; }
        }
        public bool DeleteBook(long bookId)
        {
            try
            {
                Book book = repo.GetEntityByFilter<Book>(b => b.ID_Book == bookId);
                if (book != null)
                {
                    repo.DeleteEntity<Book>(book);
                    return true;
                }
                return false;
            }
            catch { throw; }
        }

        public bool DeleteUser(string username)
        {
            try
            {
                User user = repo.GetEntityByFilter<User>(u => u.UserName == username);
                if (user != null)
                {
                    repo.DeleteEntity<User>(user);
                    return true;
                }
                return false;
            }
            catch { throw; }
        }
        public List<AuthorView> GetAllAuthors()
        {
            try
            {
                return repo.GetEntities<Author>().Select(a => new AuthorView
                {
                    ID_Author = a.ID_Author,
                    Name = a.Name,
                    Surname = a.Surname

                }).ToList();
            }
            catch { throw; }
        }

        public Book InsertBook(Book book)
        {
            try
            {
                return repo.InsertEntity(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Author InsertAuthor(Author author)
        {
            try
            {
                return repo.InsertEntity(author);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BookReviewsView> GetBookReviewsById(long reviewId)
        {
            try
            {
                return repo.GetEntities<BookReview>().Where(br => br.ID_Review == reviewId)
                          .Select(br => new BookReviewsView
                          {
                              Id_Review = br.ID_Review,
                              BookName = br.Book.Book_Name,
                              ReviewText = br.ReviewText,
                              UserFullName = br.User.Name + " " + br.User.Surname,
                              DateTime = br.Date_Time
                          }).ToList();
            }
            catch (Exception ex)
            {
                // Ieteikums: Log kļūdu šeit, ja nepieciešams
                throw;
            }
        }

        public List<BookReviewsView> GetAllBooksReview()
        {
            try
            {
                return repo.GetEntities<BookReview>()
                          .Select(br => new BookReviewsView
                          {
                              Id_Review = br.ID_Review,
                              BookName = br.Book.Book_Name,
                              ReviewText = br.ReviewText,
                              UserFullName = br.User.Name + " " + br.User.Surname,
                              DateTime = br.Date_Time
                          }).ToList();
            }
            catch
            {
                throw;

            }
        }



    }
}
