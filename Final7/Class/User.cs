namespace Final7.Class;

public abstract class User //абстрактный класс. Все типы пользователей наследуются от него.
{
    public readonly Guid ID; // id пользователя доступен из любого места с правом только для чтения. Нельзя переписать ID пользователя
    public string Name { get; set; } 
    
    private int _age; // тут просто приватное поле возраста пользователя.
    public int Age //При помощи свойств реализовывается проверка "старше 16 лет" 
    { 
        get 
        { 
            return _age; 
        } 
        set 
        {
            if(value > 16)
            {
                _age = value;
            } 
        } 
    }

    public object RaiseStatus { get; set; }


    protected void ChangeName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            Name = newName;
        }
    }
}