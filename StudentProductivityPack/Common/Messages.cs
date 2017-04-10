using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProductivityPack.Common
{
    public static class Messages
    {
        public static class Error
        {
            public const string CANNOT_CREATE_SOLUTION_TITLE = "Cannot create solution";
            public const string SOLUTION_MUST_HAVE_NAME = "Solution must have a name";
            public const string SOLUTION_MUST_HAVE_FOLDER = "You must select a folder for the solution";
        }

        public static class Warning
        {
            public const string EMPTY_SOLUTION_CREATION_TITLE = "Empty solution creation";
            public const string EMPTY_SOLUTION_CREATION_MESSAGE = "The created solution will be empty. Do you want to proceed anyway?";
        }
    }
}
