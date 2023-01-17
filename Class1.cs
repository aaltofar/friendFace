namespace friendFace
{
    internal class User
    {
        public string userName;
        public int age;
        public bool isLoggedIn;
        public bool isFriend;
        public User[] friendList;
        public User(string userName, int age, bool isLoggedIn)
        {
            this.userName = userName;
            this.age = age;
            this.isLoggedIn = isLoggedIn;
        }
    }


}
