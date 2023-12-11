using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    internal class UserProfiles
    {
        private User currentUser;
        private List<User> users;

        public UserProfiles()
        {
            users = new List<User>
        {
            new User { Name = "Aleks", Description = "This is user 1" },
            new User { Name = "User2", Description = "This is user 2" },
            new User { Name = "User3", Description = "This is user 3" }
        };

            currentUser = new User { Name = "MainUser", Description = "This is the main user" };
        }

        public void AddFriend(User friend)
        {
            if (friend != null && !currentUser.Friends.Contains(friend))
            {
                currentUser.Friends.Add(friend);
                Console.WriteLine($"{friend.Name} was added as a friend");
            }
            else
            {
                Console.WriteLine("This person is already in your friend's list");
            }
        }

        public void RemoveFriend(User friend)
        {
            if (friend != null && currentUser.Friends.Contains(friend))
            {
                currentUser.Friends.Remove(friend);
                Console.WriteLine($"{friend.Name} has been removed from friend's list");
            }
            else
            {
                Console.WriteLine("The user is not on your friend's list");
            }
        }

        public void ShowFriends()
        {
            Console.WriteLine("Friends List: ");
            foreach (var friend in currentUser.Friends)
            {
                Console.WriteLine($"{friend.Name}");
            }
        }

        public void ShowFriendProfile(User friend)
        {
            Console.WriteLine($"----------{friend.Name}'s Profile---------");
            Console.WriteLine($"{friend.Description}");
        }

        public void RunProgram()
        {
            Console.WriteLine($"Welcome to FriendFace {currentUser.Name}");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("[1] Add friend ");
                Console.WriteLine("[2] Remove friend ");
                Console.WriteLine("[3] Show Friend's list ");
                Console.WriteLine("[4] View Friend's Profile ");
                Console.WriteLine("[5] Exit ");

                Console.WriteLine("Choose an option");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter friend's name: ");
                            string friendName = Console.ReadLine();
                            if (!users.Any(u => u.Name == friendName)) // lambda operatør
                            {
                                Console.WriteLine("User does not exist");
                                Console.ReadKey();
                                break;
                            }
                            User friendToAdd = users.Find(u => u.Name == friendName); // lambda operatør
                            AddFriend(friendToAdd);
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Write("Enter friend's name: ");
                            string friendToRemoveName = Console.ReadLine();
                            if (!users.Any(u => u.Name == friendToRemoveName)) // lambda operatør
                            {
                                Console.WriteLine("User does not exist");
                                Console.ReadKey();
                                break;
                            }
                            User friendToRemove = users.Find(u => u.Name == friendToRemoveName); // lambda operatør
                            RemoveFriend(friendToRemove);
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            ShowFriends();
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Write("Enter friend's name: ");
                            string friendToViewName = Console.ReadLine();
                            if (!users.Any(u => u.Name == friendToViewName))  // lambda operatør
                            {
                                Console.WriteLine("User does not exist");
                                Console.ReadKey();
                                break;
                            }
                            User friendToView = users.Find(u => u.Name == friendToViewName);   // lambda operatør
                            Console.Clear();
                            ShowFriendProfile(friendToView);
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.WriteLine("Goodbye!");
                            Console.ReadKey();
                            return;

                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    Console.ReadKey();
                }
            }
        }
    }
}