using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    class JobSeekerDAO : AnyDAO<JobSeeker>
    {
        public JobSeeker GetJobSeeker(string userName)
        {
            return query.First(jobSeeker => jobSeeker.Username == userName);
        }

        public void Update(JobSeeker jobSeeker)
        {
            JobSeeker jobSeekerToUpdate = GetObject(jobSeeker.Id);
            jobSeekerToUpdate.Password = jobSeeker.Password;
            jobSeekerToUpdate.Email = jobSeeker.Email;
            jobSeekerToUpdate.Phonenumber = jobSeeker.Phonenumber;
            jobSeekerToUpdate.Fullname = jobSeeker.Fullname;
            jobSeekerToUpdate.Portraitimage = jobSeeker.Portraitimage;
            jobSeekerToUpdate.Address = jobSeeker.Address;
            jobSeekerToUpdate.Birthdate = jobSeeker.Birthdate;
            db.SaveChanges();
        }
        public bool ApplyingChecked(JobSeeker jobSeeker, Post post)
        {
            foreach (var applyForm in post.ApplyForms)
            {
                if (applyForm.JobSeekerId == jobSeeker.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
