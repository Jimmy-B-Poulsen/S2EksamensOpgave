using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EksamensProject.Classes;

namespace EksamensProject.Classes
{
    public class Biz
    {

        // Inserts the Player Object to Database
        public void PlayerInfoTransfer(Player player)
        {
            try
            {
                string playerInsertion = $"INSERT INTO players (nameOfPlayer, summonerName, rankOfPlayer, phone, typeOfTurnament) VALUES ('{player.Name}','{player.Summonername}','{player.Rank}','{player.PhoneNumber}','{player.TurnamentType}')";

                DBConnection connect = new DBConnection();

                if (TestExistingPlayer(player.Summonername) == true)
                {
                    MessageBox.Show("summoner already exists already Exist");
                }
                else
                {
                    connect.Temp(playerInsertion);
                    MessageBox.Show("Added Player To database");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Player already Exist" + " " + e);
            }
        }




        //Fik hjælp fra Christian i denne del
        public bool TestExistingPlayer(string name)
        {
            try
            {
                string api = new WebClient().DownloadString(@$"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/%7Bname%7D?api_key=RGAPI-4698eaf0-5eeb-4ec7-a412-f9dc5443457e");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Denne bruger eksistere ikke i databasen!");
                return false;
            }
        }

        public void UpdatePlayerBox()
        {
            string pullQuery = "SELECT * FROM Players";

            DBConnection connect = new DBConnection();

            List<DataSet> table = DatasetToList.ToList<DataSet>(connect.TableReturner(pullQuery));

            foreach (var item in table)
            {
                
            }
        }
    }
}
