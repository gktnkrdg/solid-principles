using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Dependency_Inversion_Principle
{
    class NiceApproach
    {
        class Post
        {
            private ILogger _logger;

            public Post(ILogger logger)
            {
                _logger = logger;
            }

            void CreatePost(string postMessage)
            {
                try
                {
                    //create post
                }
                catch (Exception ex)
                {
                    _logger.Log(ex.ToString());
                }
            }
        }
        interface ILogger
        {
            bool Log(string message);
        }

        class FileLogger : ILogger
        {
            public bool Log(string message)
            {
                return true;
            }
        }
      
    }

   
}
