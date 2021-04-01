using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Health_App.HealthApp.Forms;

namespace HealthApp
{
    public class ClientDatabase
    {
        private const string CLIENT_INFO_FILENAME = "..\\clientinfo.txt";
        public int NewClientKey { get; set; }
        public SortedList<int, Client> ClientList { get; set; }
        public Client NewClient { get; set; }
        public bool DoesFileExist { get; set; }
        public static bool IsCreatingClientSuccessful { get; set; }
        public static bool BirthVerified { get; set; }

        public ClientDatabase(List<string> FormValueList)
        {
            try
            {
                ClientList = LoadClientListFromFile();
                CreateNewClientInDatabase(FormValueList);
            }
            catch (Exception e)
            {
                new CustomException("Error loading client dictionary from file.", e);
            }
        }
        public void CreateNewClientInDatabase(List<string> FormValueList)
        {
            try
            {
                IsCreatingClientSuccessful = false;
                BirthVerified = false;
                NewClient = new Client(FormValueList);
                if (IsCreatingClientSuccessful)
                {
                    AddClientToClientList();
                    ShowDialogBox();
                }
            }
            catch (Exception e)
            {
                new CustomException("Error creating a new client in the client database.", e);
            }
        }
        public void CreateNewClientKey()
        {
            try
            {
                NewClientKey = DoesFileExist ? ClientList.Keys.LastOrDefault() + 1 : 0;
            }
            catch (Exception e)
            {
                new CustomException("Error creating new client key.", e);
            }
        }
        public void AddClientToClientList()
        {
            try
            {
                CreateNewClientKey();
                ClientList.Add(NewClientKey, NewClient);
                WriteClientListToFile();
            }
            catch (Exception e)
            {
                new CustomException("Error adding client to client list.", e);
            }
        }
        public void WriteClientListToFile()
        {
            try
            {
                File.WriteAllText(CLIENT_INFO_FILENAME, JsonConvert.SerializeObject(ClientList));
            }
            catch (Exception e)
            {
                new CustomException("Error saving client data to file.", e);
            }
        }

        public SortedList<int, Client> LoadClientListFromFile()
        {
            SortedList<int, Client> json_deserialized_client_data = new SortedList<int, Client>();

            try
            {

                if (File.Exists(CLIENT_INFO_FILENAME))
                {
                    string raw_json_client_data = File.ReadAllText(CLIENT_INFO_FILENAME);
                    json_deserialized_client_data = JsonConvert.DeserializeObject<SortedList<int, Client>>(raw_json_client_data);
                    DoesFileExist = true;
                    return json_deserialized_client_data;
                }
                else 
                {
                    DoesFileExist = false;    
                }
            }
            catch (Exception e)
            {
                new CustomException("Error loading client data", e);
            }

            return json_deserialized_client_data;
        }
        public void ShowDialogBox()
        {
            new SuccessDialog().Show();
        }
        public static void CloseMainForm()
        {

        }
    }
}
