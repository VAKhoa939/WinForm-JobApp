using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostTagCatalogDAO : AnyDAO<PostTagCatalog>
    {
        public void Update(PostTagCatalog postTag)
        {
            PostTagCatalog postTagToUpdate = GetObject(postTag.Id);
            postTagToUpdate.Tag = postTag.Tag;
            db.SaveChanges();
        }
    }
}
