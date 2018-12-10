using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat_application
{
    public class FileWrapper
    {

        public static Lake GetLakeFromFile()
        {
            Lake lake = null;

            try
            {
                using (StreamReader r = new StreamReader("file.json"))
                {
                    string json = r.ReadToEnd();
                    lake = JsonConvert.DeserializeObject<Lake>(json);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("File not found, create a file named file.json in the folder.");
            }
            finally
            {
                lake = new Lake();
                lake.CreateBoat("dikke lala", 8, BoatType.HARRY_DE_SPEEDBOOT);
                lake.AddCrew(new Crew("Niek", 2));
                lake.AddCrew(new Crew("Jan", 2));
                lake.AddCrew(new Crew("Harry", 2));
                lake.AddCrew(new Crew("Willem", 1));
                lake.AddCrew(new Crew("Piet", 1));
                Clipboard.SetText(JsonConvert.SerializeObject(lake));
            }

            return lake;
        }
    }
}
