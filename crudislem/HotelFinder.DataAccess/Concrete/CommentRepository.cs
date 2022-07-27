using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using hotelFinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelFinder.DataAccess.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        //DbContext _dbSet;
        //public CommentRepository(DbContext dbSet)
        //{
        //    _dbSet = dbSet;
        //}

        public CommentRepository()
        {
        }

        public Comment CreateComment(Comment comment)
        {
            using (var commentDbContext = new HotelDbContext())
            {
                commentDbContext.Comments.Add(comment);
                commentDbContext.SaveChanges();
                return comment;
            }
        }

        public void DeleteComment(int otelId)
        {
            using (var commentDbContext = new HotelDbContext())
            {
                //var deletedComment = GetOneComment(otelId);
                //for(int i = 0; i < deletedComment.Count; i++){
                //    commentDbContext.Comments.Remove(deletedComment[i]);
                //};
                var deletedComment = GetOneComment(otelId);
                commentDbContext.Comments.RemoveRange(deletedComment);
                
                commentDbContext.SaveChanges();
            }
        }

        public List<Comment> GetAllComments()
        {

            using (var commentDbContext = new HotelDbContext())
            {
                return commentDbContext.Comments.ToList();
            }
        }

        public List<Comment> GetOneComment(int otelId)
        {
            using (var commentDbContext = new HotelDbContext())
            {
                return commentDbContext.Comments.Where(x => x.OtelId == otelId).ToList();
            }
        }

        public Comment UpdateComment(Comment comment)
        {
            using (var commentDbContext = new HotelDbContext())
            {
                commentDbContext.Comments.Update(comment);
                commentDbContext.SaveChanges();
                return comment;
            }
        }

        //Comment ICommentRepository.GetOneComment(int otelId)
        //{
        //    throw new NotImplementedException();
        //}

        //Comment ICommentRepository.GetOneComment(int otelId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Comment> GetAll(Expression<Func<Comment, bool>> filter = null, Func<IQueryable<Comment>, IOrderedQueryable<Comment>> orderBy = null, string includeProperties = null)
        //{
        //        IQueryable<Comment> query = (IQueryable<Comment>)_dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    if (includeProperties != null)
        //    {
        //        foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //        {
        //            query = query.Include(includeProp);
        //        }
        //    }

        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList<Comment>();

        //    }

        //    return query.ToList<Comment>();
        //}

    }
}
