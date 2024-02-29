// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Threading.Channels;
using System.Xml;

class Menu
{
    //variables for the menu
    private string menu = "MENU:\n1 - Enter new recipe\n2 - View a recipe\n3 - Edit a recipe\n4 - Delete a recipe\n5 - Exit";
    private int choice;

    //Variables for new recipe info
    string ingredientName;
    string recipeName;
    string quant;
    string measure;
    string measureInstrument;
    string description;
    int stepNum, ingredientNum, recipeCount = 0;


    string editName;
    string displayPiece;


    //arraylists to save the recipe info
    ArrayList nameArr = new();
    ArrayList quantArr = new();
    ArrayList measureArr = new();
    ArrayList instrumentArr = new();
    ArrayList descriptionArr = new();

    //variable to exit program
    int exitValue = 0;

    //Displays the menu and waits for user input
    public void MenuChoice()
    {
        do
        {

            Console.WriteLine(menu);
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                //NewRecipe
                case 1:
                    NewRecipe();

                    break;

                //EditRecipe
                case 2:
                    EditRecipe();

                    break;

                //ViewRecipe
                case 3:
                    ViewRecipe();

                    break;

                //DeleteRecipe
                case 4:
                    DeleteRecipe();

                    break;

                //Exit
                case 5:
                    exitValue = 1;
                    Console.WriteLine("See you again :)");

                    break;

                default:

                    Console.WriteLine("Please select one of the available options!");

                    break;
            }

        }while(exitValue != 1);

    }

    //Runs the code to add a new recipe to the program
    public void NewRecipe()
    {
        recipeCount++;

        Console.WriteLine("Creating a new recipe!");
        Console.WriteLine("Enter the new recipe name");
        recipeName = Console.ReadLine();

        Console.WriteLine("How many ingredients are used to make: " + recipeName);
        ingredientNum = int.Parse(Console.ReadLine());

        Console.WriteLine("How many steps are needed to make: " + recipeName);
        stepNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the following for the ingredients!");

        for (int i = 0; i < ingredientNum; i++)
        {
            Console.WriteLine("Name of ingredient: " + (i + 1) + " of " + ingredientNum);
            ingredientName = Console.ReadLine();
            nameArr.Add(ingredientName);

            Console.WriteLine("What quantity of " + ingredientName + " is needed?");
            quant = Console.ReadLine();
            quantArr.Add(quant);

            Console.WriteLine("What is the form of measurement used for " + ingredientName);
            Console.WriteLine("Example: ml, kg, cups, teaspoons");
            measureInstrument = Console.ReadLine();
            instrumentArr.Add(measureInstrument);

            Console.WriteLine("How many " + measureInstrument + " of " + ingredientName + " is used?");
            measure = Console.ReadLine();
            measureArr.Add(measure);

        }

        Console.WriteLine("Ingredients have been captured!");
        Console.WriteLine("Moving on to steps");

        for (int i = 0; i < stepNum; i++)
        {
            Console.WriteLine("Please describe step: " + (i + 1) + " of " + stepNum);
            description = Console.ReadLine();
            descriptionArr.Add(description);
        }

        Console.WriteLine("Recipe capture complete! :)");
    }

    //Allows the user to edit and existing recipe identified by the recipe name
    public void EditRecipe()
    {
        Console.WriteLine("Editing a recipe");
        Console.WriteLine("Enter the name of the recipe you want to edit:");
        editName = Console.ReadLine();

        for (int i = 0; i < recipeCount; i++)
        {
            if (editName.Equals(nameArr[i])) 
            { 

            }
            
        }
    }

    //Allows the user to view an existing recipe identified by the recipe name
    //Display all the recipe names allowing the user to choose one
    public void ViewRecipe()
    {

    }

    //Deletes a recipe after the user confirms the deletion
    public void DeleteRecipe()
    {

    }

}