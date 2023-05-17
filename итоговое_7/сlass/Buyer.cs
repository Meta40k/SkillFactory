using итоговое_7.enums;

namespace итоговое_7.сlass
{
    class Buyer : User
    {
        public override Guid ID => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public BuyerStatus Status { get; set; }

        public string HomeAddress { get; set; }
    }
}
