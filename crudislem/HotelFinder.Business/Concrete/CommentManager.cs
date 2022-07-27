using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Business.Abstract;
using System.Linq.Expressions;
using HotelFinder.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.Business.Concrete
{
    public class CommentManager : IcommentService
    {
        //DbContext _dbSet;
        //public CommentManager(DbContext dbSet)
        //{
        //    _dbSet = dbSet;
        //}

        private ICommentRepository _commentRepository;
        public CommentManager()
        {

            _commentRepository = new CommentRepository();
        }
        
        public Comment CreateComment(Comment comment)
        {
            return _commentRepository.CreateComment(comment);
        }

        public Comment CreateHotel(Comment comment)
        {
            return _commentRepository.CreateComment(comment);
        }

        public void DeleteComment(int otelId)
        {
            _commentRepository.DeleteComment(otelId);
        }

        //public IEnumerable<Comment> GetAll(Expression<Func<Comment, bool>> filter = null, Func<IQueryable<Comment>, IOrderedQueryable<Comment>> orderBy = null, string includeProperties = null)
        //{
        //    IQueryable<Comment> query = (IQueryable<Comment>)_dbSet;

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

        public List<Comment> GetAllComments()
        {
            //return _commentRepository.GetAll(null, null,includeProperties: "Hotels").ToList();
            return _commentRepository.GetAllComments();
        }



        public List<Comment> GetOneComment(int otelId)
        {
            return _commentRepository.GetOneComment(otelId);

        }



        public Comment UpdateComment(Comment comment)
        {
            return _commentRepository.UpdateComment(comment);
        }
    }
}
