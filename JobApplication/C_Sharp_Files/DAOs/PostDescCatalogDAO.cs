using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostDescCatalogDAO : AnyDAO<PostDescCatalog>
    {
        public void Update(PostDescCatalog postDesc)
        {
            PostDescCatalog postDescToUpdate = GetObject(postDesc.Id);
            postDescToUpdate.JobDesc = postDesc.JobDesc;
            db.SaveChanges();
        }
    }
}
