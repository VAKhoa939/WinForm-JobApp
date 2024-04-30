using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostDAO : AnyDAO<Post>
    {
        public void Update(Post post)
        {
            Post postToUpdate = GetObject(post.Id);
            postToUpdate.Name = post.Name;
            postToUpdate.Salary = post.Salary;
            postToUpdate.Others = post.Others;
            postToUpdate.Timeposted = post.Timeposted;
            postToUpdate.Status = post.Status;
            db.SaveChanges();
        }
    }
}
