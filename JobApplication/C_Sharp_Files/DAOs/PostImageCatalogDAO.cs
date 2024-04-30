using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostImageCatalogDAO : AnyDAO<PostImageCatalog>
    {
        public void Update(PostImageCatalog postImage)
        {
            PostImageCatalog postImageToUpdate = GetObject(postImage.Id);
            postImageToUpdate.Image = postImage.Image;
            db.SaveChanges();
        }
    }
}
