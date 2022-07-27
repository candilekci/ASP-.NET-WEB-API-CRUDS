using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace commentFinder.Entities
{
    public class Comment
    {
       
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            
            public int OtelId { get; set; }
            [StringLength(50)]
            public string CommentX { get; set; }


        
    }
}
