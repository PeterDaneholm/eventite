
using System.Net.Mime;

public class CLIManager
{
    private UserRepository _userRepository = new UserRepository();
    private string response = "";

    public void StartInterface()
    {
        Console.WriteLine("-----------------\n" +
                          "Welcome to Eventite. \n" +
                          "-----------------\n" +
                          "What would you like to do? \n" +
                          "Type '1' for New Event. \n" +
                          "Type '2' to check user profile \n" +
                          "Type '3' to exit");
        switch (Console.ReadLine())
        {
            case "1":
                AddEventFlow();
                break;
            case "2":
                FindUserProfile();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("That's an invalid option. Choose again:");
                break;
        }
    }

    private void WrongInput()
    {
        Console.WriteLine("That's not the right input format, try again");
    }

    private void ConfirmInput()
    {
        string confirm = Console.ReadLine();
        if (confirm == "Yes")
        {
            return;
        }
        else
        {
            Console.WriteLine("Input not confirmed, enter value(s) for your event");
        }
    }

    private void AddEventFlow()
    {
        Event newEvent = new Event();
        Console.WriteLine("What is the title of your event?");
        string input = Console.ReadLine();
        Console.WriteLine($"You've entered: ${input} as the title. Enter 'Yes' to confirm");
        
        newEvent.title = input;
    }

    private User FindUserProfile()
    {
        Console.WriteLine("What's the username and name of the user?");
        string userName = Console.ReadLine();
        User foundUser = _userRepository.getUnique(userName);
        return foundUser;
    }
}