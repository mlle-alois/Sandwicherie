using System.ComponentModel;

namespace Sandwicherie.Model
{
    public enum IngredientElement
    {
        [Description("Bread")]
        Bread,
        [Description("Ham")]
        Ham,
        [Description("Butter")]
        Butter,
        [Description("Salad")]
        Salad,
        [Description("Egg")]
        Egg,
        [Description("Tomato")]
        Tomato,
        [Description("Mayonnaise")]
        Mayonnaise,
        [Description("Tuna")]
        Tuna,
        [Description("Chicken slice")]
        ChickenSlice
    }
}