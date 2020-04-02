using BudgetModels.Models_V1.BudgetModels.Interfaces;
using Newtonsoft.Json;
using StateControl.States;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.SaveControl
{
    public static class SaveController
	{
        #region - Fields & Properties

        #endregion

        #region - Methods
        public void Save( string path )
        {

        }

		public static void BuildSaveState( IEnumerable<IIncome> incomeData, IEnumerable<IExpense> expenseData )
		{

			SaveState budgetState = new SaveState(new BudgetState(incomeData, expenseData), new PaystubState(), new DebtState());
		}

        private static string ConvertObjectToString<T>( T convertObject ) where T : class
        {
            try
            {
                return JsonConvert.SerializeObject(convertObject, Formatting.Indented);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static T ConvertStringToObject<T>( string input ) where T : new()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void SaveJsonToFolder<T>( string path, string fileName, T input )
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(path, fileName + ".json")))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings()
                    {
                        Formatting = Formatting.Indented
                    };
                    JsonSerializer serializer = JsonSerializer.Create(settings);
                    serializer.Serialize(writer, input, input.GetType());
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static T OpenJsonFile<T>( string path, string name )
        {
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(path, name + ".json")))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings()
                    {
                        Formatting = Formatting.Indented
                    };
                    JsonSerializer serializer = JsonSerializer.Create(settings);
                    JsonTextReader jsonReader = new JsonTextReader(reader);
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region - Full Properties

        #endregion
    }
}
