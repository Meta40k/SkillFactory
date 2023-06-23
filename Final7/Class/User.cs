namespace Final7.Class;

abstract class User //абстрактный класс. Все типы пользователей наследуются от него.
{
    public readonly Guid ID; // id пользователя доступен из любого места с правом только для чтения. Нельзя переписать ID пользователя
    public string Name { get; private set; } //ограничение на уровне свойств. Я могу получить информацию о имени пользователя, но поменять смогу только из кода самого класса.

    private int _age; // тут просто приватное поле возраста пользователя.
    public int Age //При помощи свойств реализовывается проверка "старше 16 лет" 
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