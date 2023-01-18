namespace friendFace
{
    internal class User
    {
        public string userName;
        public int age;
        public bool isLoggedIn;
        public bool isFriend;
        public User[] friendList;
        public User(string userName, int age, bool isLoggedIn, bool isFriend)
        {
            this.userName = userName;
            this.age = age;
            this.isLoggedIn = isLoggedIn;
            this.isFriend = isFriend;
        }

        public void AddFriend(User[] availableUsers, int userIndex)
        {
            availableUsers[userIndex].isFriend = true;
        }
        public void RemoveFriend(User[] availableUsers, int userIndex)
        {
            availableUsers[userIndex].isFriend = false;
        }
    }
}
