namespace итоговое_7.сlass
{
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
                _age = value; 
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
}
