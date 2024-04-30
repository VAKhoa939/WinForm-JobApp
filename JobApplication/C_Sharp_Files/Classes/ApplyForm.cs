using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public partial class FApplyForm
    {
        private string id;
        private int seekFormId;
        private int postFormId;
        private byte[] cv;
        private string coverLetter;
        private string status;
        private DateTime timeSent;

        public FApplyForm(int seekFormId, int postFormId, byte[] cv, string coverLetter, string status, DateTime timeSent)
        {
            this.seekFormId = seekFormId;
            this.postFormId = postFormId;
            id = seekFormId.ToString() + postFormId.ToString();
            this.cv = cv;
            this.coverLetter = coverLetter;
            this.status = status;
            this.timeSent = timeSent;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int SeekFormId
        {
            get { return seekFormId; }
            set { seekFormId = value; }
        }

        public int PostFormId
        {
            get { return postFormId; }
            set { seekFormId = value; }
        }

        public byte[] Cv
        { 
            get { return cv; }
            set { cv = value; }
        }

        public string CoverLetter
        { 
            get { return coverLetter; } 
            set { coverLetter = value; } 
        }

        public string Status
        { 
            get { return status; } 
            set { status = value; } 
        }

        public DateTime TimeSent
        { 
            get { return timeSent; }
            set { timeSent = value; } 
        }
    }
}
