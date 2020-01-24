using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModelValidation.Models;

namespace HandsOnMVCUsingModelValidation.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User(){ Name="Ganesh",Country="ind",Uname="Ganesh27",Pwd="2727"}
        };
        public UserRepository()
        {

        }
        
        
        public void Add(User item)
        {
            list.Add(item);//Add user data into list
        }
        public User Validate(string uname,string pwd)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname && item.Pwd==pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
