﻿using System;

namespace Library.API.Models
{
    /// <summary>
    /// An Author with Id,FirstName and LastName fields
    /// </summary>
    public class Author
    {        
        /// <summary>
        ///  The Id of the author
        /// </summary>
        public Guid Id { get; set; } 
        /// <summary>
        ///  The first name of the author
        /// </summary>
        public string FirstName { get; set; }
      
        /// <summary>
        /// The last name of the author 
        /// </summary>
        public string LastName { get; set; }
    }
}
