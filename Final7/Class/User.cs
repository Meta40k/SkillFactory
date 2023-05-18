namespace Final7.Class;

abstract class User
{
    public readonly Guid ID;
    public string Name { get; private set; }

    private int _age;
    public int Age 
    { 
        get 
        { 
            return _age; 
        } 
        private set 
        {
            if(value > 16)
            {
                _age = value;
            } 
        } 
    }



    protected void ChangeName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            Name = newName;
        }
    }
}