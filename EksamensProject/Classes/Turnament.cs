using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProject.Classes
{
    class Turnament
    {

        //Fields
        private string turnamentName;
        private int playerid;
        private string playerName;
        private string playerPhone;
        private int judgeID;
        private string judgeName;
        private string judgePhone;
        private int judgeLevel;

        //properties
        public string TurnamentName { get => turnamentName; set => turnamentName = value; }
        public int Playerid { get => playerid; set => playerid = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string PlayerPhone { get => playerPhone; set => playerPhone = value; }
        public int JudgeID { get => judgeID; set => judgeID = value; }
        public string JudgeName { get => judgeName; set => judgeName = value; }
        public string JudgePhone { get => judgePhone; set => judgePhone = value; }
        public int JudgeLevel { get => judgeLevel; set => judgeLevel = value; }
        
        //Constroctor with parameters
        public Turnament(string turnamentName, int playerid, string playerName, string playerPhone, int judgeID, string judgeName, string judgePhone, int judgeLevel)
        {
            TurnamentName = turnamentName;
            Playerid = playerid;
            PlayerName = playerName;
            PlayerPhone = playerPhone;
            JudgeID = judgeID;
            JudgeName = judgeName;
            JudgePhone = judgePhone;
            JudgeLevel = judgeLevel;
        }

        //Empty Constroctor
        public Turnament()
        {
        }
    }
}
