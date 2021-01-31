using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{

    public class Step
    {
        public Commands command;
        public Ingredient ingredient;

        public override string ToString()
        {
            return command + " a " + ingredient.name;
        }

        public Step(Commands command, Ingredient ingredient)
        {
            this.command = command;
            this.ingredient = ingredient;
        }
    }

    private Ingredient[] ingredientList;
    public static List<Step> currentRecipe;
    public static int currentStepIndex = 0;
    
    void Start()
    {
        ingredientList = FindObjectsOfType<Ingredient>();
        createNewRandomRecipe();
    }

    private void createNewRandomRecipe()
    {
        currentStepIndex = 0;
        currentRecipe = new List<Step>();
            int numSteps = Random.Range(3, 7);
        for (int i = 0; i < numSteps; i++)
        {
            currentRecipe.Add(randomStep());
        }

    }

    private Step randomStep()
    {
        int i = Random.Range(0, ingredientList.Length);
        Ingredient ing = ingredientList[i];
        int j = Random.Range(0, ing.validCommands.Count);
        Commands command = ing.validCommands[j];
        return new Step(command, ing);
    }

    public void nextStep()
    {
        if (currentStepIndex == currentRecipe.Count)
        {
            createNewRandomRecipe();
        }
        else
        {
            currentStepIndex++;
        }
            
    }


}
