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

    private static List<GameObject> ingredientList;
    public static List<Step> currentRecipe;
    public static int currentStepIndex = 0;
    
    void Start()
    {
        ingredientList = FindObjectOfType<IngredientsManager>().ingredientsPrefabs;
        Debug.Log(ingredientList.Count);
        createNewRandomRecipe();
        Debug.Log(currentRecipe[currentStepIndex]);
    }

    private static void createNewRandomRecipe()
    {
        currentStepIndex = 0;
        currentRecipe = new List<Step>();
        int numSteps = Random.Range(3, 7);
        for (int i = 0; i < numSteps; i++)
        {
            currentRecipe.Add(randomStep());
        }

    }

    private static Step randomStep()
    {
        Ingredient ing = null;
        while (ing == null)
        {
            int i = Random.Range(0, ingredientList.Count);
            ing = ingredientList[i].GetComponent<Ingredient>();
        }
        
        int j = Random.Range(0, ing.validCommands.Count);
        Commands command = ing.validCommands[j];
        return new Step(command, ing);
    }

    public static void nextStep()
    {
        if (currentStepIndex == currentRecipe.Count - 1)
        {
            createNewRandomRecipe();
        }
        else
        {
            currentStepIndex++;
            Debug.Log(currentRecipe[currentStepIndex] + ", " 
                                                      + GameManager.instance.gameState.points);
        }
            
    }


}
