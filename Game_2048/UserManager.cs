using Newtonsoft.Json;

namespace Game_2048
{
    public class UserManager
    {
        private static string path = "results.json";
        public static List<User> GetAll()
        {
            if (FileProvider.Exists(path))
            {
                var jsonData = FileProvider.Get(path);
                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
            return new List<User>();
        }

        public static void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);
            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(path, jsonData);
        }
    }
}
