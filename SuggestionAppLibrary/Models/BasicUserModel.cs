namespace SuggestionAppLibrary.Models
{
    public class BasicUserModel
    {
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public BasicUserModel()
        {
                
        }

        public BasicUserModel(UserModel User)
        {
            Id = User.Id;
            DisplayName = User.DisplayName;
        }
    }
}
