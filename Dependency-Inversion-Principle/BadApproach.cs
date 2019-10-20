using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Dependency_Inversion_Principle
{
    class BadApproach
    {
        class Post
        {
            private FileLogger errorLogger = new FileLogger();

            void CreatePost( string postMessage)
            {
                try
                {
                    // create post
                }
                catch (Exception ex)
                {
                    errorLogger.Log(ex.ToString());
                }
            }
        }
        class FileLogger
        {
            public bool Log(string message)
            {
                return true;
            }
        }
    }

   
}
