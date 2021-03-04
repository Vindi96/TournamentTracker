using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// represent first name of the person
        /// </summary>
        public String FirstName { get; set; }
        /// <summary>
        /// represent last name of the person 
        /// </summary>
        public String LastName { get; set; }
        /// <summary>
        /// represent email address of the person
        /// </summary>
        public String EmailAddress { get; set; }
        /// <summary>
        /// represent cell phone number of the persion
        /// </summary>
        public String CellphoneNumber { get; set; }

    }
}
