using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostDAO : AnyDAO
    {
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();
        private EmpPostCatalogDAO empPostDAO = new EmpPostCatalogDAO();
        private PostFormCatalogDAO postFormDAO = new PostFormCatalogDAO();
        private PostImgCatalogDAO postImgDAO = new PostImgCatalogDAO();
        private PostDescCatalogDAO postDescDAO = new PostDescCatalogDAO();
        private PostTagCatalogDAO postTagDAO = new PostTagCatalogDAO();

        public List<Post> GetList()
        {
            List<Post> posts = new List<Post>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = Convert.ToInt32(dataRow[0]);
                string name = dataRow[1].ToString();
                decimal salary = Convert.ToDecimal(dataRow[2]);
                string others = dataRow[3].ToString();
                DateTime timePosted = (DateTime)dataRow[4];
                Post post = new Post(id, name, salary, others, timePosted);
                foreach (string jobDesc in postDescDAO.GetJobDescs(post.Id))
                {
                    post.JobDescs.Add(jobDesc);
                }
                foreach (Image image in postImgDAO.GetImages(post.Id))
                {
                    post.Images.Add(image);
                }
                foreach (string tag in postTagDAO.GetTags(post.Id))
                {
                    post.Tags.Add(tag);
                }
                foreach (int formId in postFormDAO.GetFormIds(post.Id))
                {
                    post.ApplyForms.Add(applyFormDAO.GetApplyFormPostId(formId));
                }
                posts.Add(post);
            }
            return posts;
        }

        public Post GetPost(int id)
        {
            sqlStr = string.Format("SELECT * FROM Post WHERE Id = '{0}'", id);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            string name = dataRow[1].ToString();
            decimal salary = Convert.ToDecimal(dataRow[2]);
            string others = dataRow[3].ToString();
            DateTime timePosted = (DateTime)dataRow[4];
            Post post = new Post(id, name, salary, others, timePosted);
            foreach (string jobDesc in postDescDAO.GetJobDescs(post.Id))
            {
                post.JobDescs.Add(jobDesc);
            }
            foreach (Image image in postImgDAO.GetImages(post.Id))
            {
                post.Images.Add(image);
            }
            foreach (string tag in postTagDAO.GetTags(post.Id))
            {
                post.Tags.Add(tag);
            }
            foreach (int formId in postFormDAO.GetFormIds(post.Id))
            {
                post.ApplyForms.Add(applyFormDAO.GetApplyFormPostId(formId));
            }
            return post;
        }
        public void Insert_1(Post post)
        {
            sqlStr = string.Format("INSERT INTO Post (Id, Name, Salary, Others, Timeposted) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", post.Id, post.Name, post.Salary, post.Others, post.TimePosted.ToString("yyyy-MM-dd HH:mm:ss"));
            dBConn.Execute(sqlStr, "Insert");
            foreach (Image postImage in post.Images)
            {
                postImgDAO.Insert(post.Id, postImage);
            }
        }


        public void Insert(Post post, Employer employer)
        {
            int id = GetList().Count;

            sqlStr = string.Format("INSERT INTO Post (Id, Name, Salary, Others, Timeposted) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", id, post.Name, post.Salary, post.Others, post.TimePosted.ToString("yyyy-MM-dd HH:mm:ss"));
            dBConn.Execute(sqlStr, "Insert");

            foreach (string jobDesc in post.JobDescs)
            {
                postDescDAO.Insert(post.Id, jobDesc);
            }
            foreach (Image postImage in post.Images)
            {
                postImgDAO.Insert(post.Id, postImage);
            }
            foreach (string tag in post.Tags)
            {
                postTagDAO.Insert(post.Id, tag);
            }
            foreach (FApplyForm applyForm in post.ApplyForms)
            {
                postFormDAO.Insert(post.Id, applyForm.PostFormId);
            }
            empPostDAO.Insert(employer.UserName, post.Id);
        }

        public void Delete(Post post)
        {
            sqlStr = string.Format("DELETE FROM Post WHERE Id = '{0}'", post.Id);
            dBConn.Execute(sqlStr, "Delete");

            postDescDAO.DeletePostId(post.Id);
            postImgDAO.DeletePostId(post.Id);
            postTagDAO.DeletePostId(post.Id);
            postFormDAO.DeletePostId(post.Id);
            foreach (FApplyForm applyForm in post.ApplyForms)
            {
                applyFormDAO.Delete(applyForm);
            }
            empPostDAO.DeletePostId(post.Id);
        }

        public void Update(Post post)
        {
            sqlStr = string.Format("UPDATE Post SET Name = '{0}', Salary = '{1}', Others = '{2}', Timeposted = '{3}' WHERE Id = '{4}'", post.Name, post.Salary, post.Others, post.TimePosted.ToString("yyyy-MM-dd HH:mm:ss"), post.Id);
            dBConn.Execute(sqlStr, "Update");

            postDescDAO.DeletePostId(post.Id);
            foreach (string jobDesc in post.JobDescs)
            {
                postDescDAO.Insert(post.Id, jobDesc);
            }
            postImgDAO.DeletePostId(post.Id);
            foreach (Image image in post.Images)
            {
                postImgDAO.Insert(post.Id, image);
            }
            postTagDAO.DeletePostId(post.Id);
            foreach (string tag in post.Tags)
            {
                postTagDAO.Insert(post.Id, tag);
            }
            postFormDAO.DeletePostId(post.Id);
            foreach (FApplyForm applyForm in post.ApplyForms)
            {
                postFormDAO.Insert(post.Id, applyForm.PostFormId);
            }
        }
    }
}
