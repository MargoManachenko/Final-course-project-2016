using System.Collections.Generic;

namespace DHB.Model
{
    //класс, хранящий информацию о названии болезни, процедурах и списке лекарст
    //используется для формы формирования рецепта
    class RecipeMaker
    {
        public List<string> MedsRecipe { get; set; }
        public string ProceduresRecipe { get; set; }
        public string DiseaseTitle { get; set; }

        public RecipeMaker(List<string> medsRecipe, string proceduresRecipe, string diseaseTitle)
        {
            MedsRecipe = medsRecipe;
            ProceduresRecipe = proceduresRecipe;
            DiseaseTitle = diseaseTitle;
        }
    }
}

