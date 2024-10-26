using System.IO;
using System.Reflection.Metadata;
using ConsoleAppTest.repositories;
using System;
using ConsoleAppTest.Infrastructure.Models;


public interface IUserRepository
{
    User GetSpecificUser(string userName);
    void Add(string userName);
    
}

public class UserRepository 
{
    public User GetSpecificUser(string userName)
    {
        User user = new User();
        
        return user;
    }

    public List<User> GetUsers()
    {
        List<User> allUsers = new List<User>();

        return allUsers;
    }

    public User Add(string userName)
    {
        Guid uuid = Guid.NewGuid();
        User newUser = new User
        {
            name = userName,
            userId = uuid,
            pastEvents = [],
            futureEvents = [],
            unansweredInvites = [],
        };

        return newUser;
    }
}