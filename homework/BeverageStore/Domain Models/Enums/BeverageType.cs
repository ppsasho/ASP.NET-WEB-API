using System.Runtime.Serialization;

namespace Domain_Models.Enums
{
    public enum BeverageType
    {
        [EnumMember(Value = "Alcohol")]

        Alcohol = 1,
        [EnumMember(Value = "Soft_Drink")]

        Soft_Drink,
        [EnumMember(Value = "Beer")]

        Beer
    }
}
