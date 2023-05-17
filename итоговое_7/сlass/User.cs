namespace итоговое_7.сlass
{
    abstract class User
    {
        public readonly Guid ID;
        public string Name { get; private set; }



        protected void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
