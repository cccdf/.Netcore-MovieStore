using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models.Response
{
    //view models, we are creating these model classes just for the views. they will have only properties that are required 
    //by the view. no more no less.
    //view models are also useful when you want to combine multiple models, like different from different classes. 
    //they are called view models in mvc
    //dto, data transfer objects in API's
    public class UserRegisterResponseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }


    }
}
