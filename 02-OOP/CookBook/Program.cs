using System.Text.Json;
using CookBook.DataAccess;
using CookBook.FileAccess;
using CookBook.Recipes;
using CookBook.Recipes.Ingredients;

using CookBook.App;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();

var ingredientsRegister = new IngredientsRegister();

const string FileName = "recipes";
var fileMetaData = new FileMetadata(FileName, Format);

var cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(stringsRepository,
 ingredientsRegister), new RecipesConsoleUserInteraction(ingredientsRegister));
cookiesRecipesApp.Run(fileMetaData.ToPath());

