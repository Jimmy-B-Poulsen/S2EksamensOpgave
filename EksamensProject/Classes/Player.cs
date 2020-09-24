using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;

namespace EksamensProject.Classes
{
    public class Player
    {
        private string name;
        private string summonername;
        private string rank;
        private string phoneNumber;
        private string turnamentType;

        public string Name { get => name; set => name = value; }
        public string Summonername { get => summonername; set => summonername = value; }
        public string Rank { get => rank; set => rank = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string TurnamentType { get => turnamentType; set => turnamentType = value; }
        
        public Player(string name, string summonername, string rank, string phoneNumber, string turnamentType)
        {
            this.name = name;
            this.summonername = summonername;
            this.rank = rank;
            this.phoneNumber = phoneNumber;
            this.turnamentType = turnamentType;
        }

        public Player()
        {
        }

        
    }

    class Team : Player
    {
        private string teamName;
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        private Player player5;


        public string TeamName { get => teamName; set => teamName = value; }
        public Player Player1 { get => player1; set => player1 = value; }
        public Player Player2 { get => player2; set => player2 = value; }
        public Player Player3 { get => player3; set => player3 = value; }
        public Player Player4 { get => player4; set => player4 = value; }
        public Player Player5 { get => player5; set => player5 = value; }
        

        //constroctor for 5 man team aka 5v5 
        public Team(string teamName, Player player1, Player player2, Player player3, Player player4, Player player5)
        {
            TeamName = teamName;
            Player1 = player1;
            Player2 = player2;
            Player3 = player3;
            Player4 = player4;
            Player5 = player5;
        }

        //Constroctor for 3 man team aka 3v3, even though there isn't any 3v3 gamemode in "League of Legends"
        public Team(string teamName, Player player1, Player player2, Player player3)
        {
            TeamName = teamName;
            Player1 = player1;
            Player2 = player2;
            Player3 = player3;
        }

        
    }
}
