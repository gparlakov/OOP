using System;
using System.Linq;


namespace School
{
    internal class BaseSchoolClass
    {
        private string textComment;

        //will return something even if empty
        public string TextComment
        {
            get
            {
                if (string.IsNullOrEmpty(this.textComment))
                {
                    return "--Empty--";
                }
                return this.textComment;
            }
        }

        //will add(or create if none) text commenton a new line
        public void AddComment(String commment)
        {
            if (string.IsNullOrEmpty(this.textComment))
            {
                this.textComment = commment;
            }
            else
            {
                this.textComment +="\n" + commment;
            }
        }
    }
}
