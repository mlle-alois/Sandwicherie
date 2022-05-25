using System.ComponentModel;

namespace Sandwicherie.Model
{
    public enum IngredientElement
    {
        [Description("Bread")]
        BREAD,
        [Description("Ham")]
        HAM,
        [Description("Butter")]
        BUTTER,
        [Description("Salad")]
        SALAD,
        [Description("Egg")]
        EGG,
        [Description("Tomato")]
        TOMATO,
        [Description("Mayonnaise")]
        MAYONNAISE,
        [Description("Tuna")]
        TUNA,
        [Description("Chicken slice")]
        CHICKEN_SLICE
    }
}