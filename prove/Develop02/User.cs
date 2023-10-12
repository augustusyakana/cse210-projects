public class User {
    public string _firstName;
    public string _occupation;

    public string displayName(){
        return $"{_firstName} ({_occupation})";
    }
}