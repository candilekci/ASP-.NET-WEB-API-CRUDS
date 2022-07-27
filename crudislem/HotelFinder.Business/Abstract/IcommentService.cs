using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IcommentService
    {
        List<Comment> GetAllComments();

        List<Comment> GetOneComment(int otelId);

        Comment CreateComment(Comment comment);

        Comment UpdateComment(Comment comment);

        void DeleteComment(int otelId);

        //public IEnumerable<Comment> GetAll(Expression<Func<Comment, bool>> filter = null, Func<IQueryable<Comment>, IOrderedQueryable<Comment>> orderBy = null, string includeProperties = null);
    }
}
