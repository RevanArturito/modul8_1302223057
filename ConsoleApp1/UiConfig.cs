using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UiConfig
    {
        public BankTransferConfig config;

        public const String filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\KONSTRUKSI PERANGKAT LUNAK\\JURNAL 8\\ConsoleApp1\\ConsoleApp1\\BankTransferConfig.json";
    
        public UiConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch(Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        public BankTransferConfig ReadConfigFile()
        {
            String configJSonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJSonData);
            return config;
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void SetDefault()
        {
            List<string> method = new List<string>() {"RTO (Real-Time)", "SKN", "RTGS", "BI FAST"};
            Confirmation confirmation = new Confirmation("yes", "ya");
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            config = new BankTransferConfig("en",transfer,method,confirmation);
        }
    }
}
