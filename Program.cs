// class User
// metode AddFriend
// RemoveFriend
// info (navn, alder, description etc)
// loggedin

// 3 extra users

// commands
// see users = 
// -add friend
// -back
// see friends =
// -view info
// -remove friend
// -back
// sign out = 

//User user1 = new User("John", 30, true);
//User user2 = new User("Marius", 28, false);
//User user3 = new User("Vanja", 26, false);
//User user4 = new User("Oliver", 14, false);

//availableUsers[0].friendList[0] = availableUsers[1];
//Console.WriteLine(availableUsers[0].friendList[0]);

using friendFace;
using System.Runtime.Intrinsics.X86;



User[] availableUsers = { new User("John", 30, true, false), new User("Marius", 28, false, false), new User("Vanja", 26, false, false), new User("Oliver", 14, false, false) };



Console.WriteLine($"Welcome to FriendFace, {availableUsers[0].userName}!");
Console.WriteLine(@$"Here is your profile:
Name: {availableUsers[0].userName}
Age: {availableUsers[0].age}
");

Console.WriteLine(@$"Available commands: 
    [L]ist users
    [F]riend list
    [E]xit
");
Console.Write("Type a command: ");

string choice = Console.ReadLine().ToUpper();
Console.WriteLine();

while (choice != "E")
{
    Console.WriteLine(@$"Available commands: 
    [L]ist users
    [F]riend list
    [E]xit
");
    while (choice == "L")
    {
        Console.WriteLine("Other FriendFace users: ");
        for (int i = 1; i < availableUsers.Length; i++)
        {
            Console.WriteLine(availableUsers[i].userName + $" [{i}]");
        }

        Console.WriteLine();
        Console.WriteLine(@"To add a user as a friend, type the number next to their name.
To go back, type [B]");

        var cmd = Console.ReadLine();
        bool isNum = int.TryParse(cmd, out var userNum);
        while (!isNum)
        {
            Console.WriteLine("Invalid command, you didn't write a proper number, try again");
        }

        while (isNum)
        {
            availableUsers[0].AddFriend(availableUsers, userNum);

            Console.WriteLine(availableUsers[userNum].userName + " is now your friend!");
            cmd = Console.ReadLine();
            isNum = int.TryParse(cmd, out userNum);

            if (cmd == "B")
            {
                break;
            }

        }

        choice = Console.ReadLine().ToUpper();

    }
    while (choice == "F")
    {
        Console.WriteLine("Your friends: ");
    }
}
//Oppgave Social Media

//    Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),

//Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

//Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

//    Lag et kommandbasert meny i konsollen der du kan:

//Legge til forskjellige brukere som venn (på den som er innlogget)
//Fjerne brukere som venn
//Printe ut en liste av alle man har lagt til som venn
//Velge en av vennene og printe ut profilinformasjonen deres.