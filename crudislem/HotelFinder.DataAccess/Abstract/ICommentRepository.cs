using hotelFinder.entities;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface ICommentRepository
    {
        List<Comment> GetAllComments();

        List<Comment> GetOneComment(int otelId);

        Comment CreateComment(Comment comment);

        Comment UpdateComment(Comment comment);

        //public IEnumerable<Comment> GetAll(Expression<Func<Comment, bool>> filter = null, Func<IQueryable<Comment>, IOrderedQueryable<Comment>> orderBy = null, string includeProperties = null);

        void DeleteComment(int otelId);
    }
}
