using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    class PlayerDBConnectManager
    {
        bool bIsConnected;
        private Player itsPlayer;

        private List<Pocketmon> itsPlayerPocketmonList;

        private List<ChoiceMachine> itsChoiceMachineList;


        PlayerDBConnectManager()
        {
            bIsConnected = false;
            itsPlayer = null;
            itsPlayerPocketmonList = null;
            itsChoiceMachineList = null;
        }


        private void ConnectToDB()
        {

        }

        private void LoadChoiceMachineList()
        {

        }

        private int CreatePlayerPocketmon(int mon_id)
        {
            return 0;
        }

        private int DeletePlayerPocketmon(int pocketmon_id)
        {
            return 0;
        }

        private int SelectPlayerOwnedPocketmonCountByLevel(int level)
        {
            return 0;
        }




        public bool LoadPlayer(String player_id, String player_pw)
        {
            return true;
        }

        public bool SavePlayer(Player _player)
        {
            return true;
        }

        public int UpgradeIncomeLevel()
        {
            return 0;
        }

        public int BuyRandomPocketmon(int machine_id)
        {
            int pocketmon_id = -1;

            return pocketmon_id;
        }

        public int ChangePlayerPocketmonStatus(int pocketmon_id, int status)
        {
            int changedStatus = -1;

            return changedStatus;
        }


        public bool isPlayerLoaded()
        {
            return bIsConnected;
        }

        public Player GetPlayer() {
            return itsPlayer;
        }

        public List<Pocketmon> GetPocketmonList()
        {
            return itsPlayerPocketmonList;
        }

        public List<ChoiceMachine> GetChoiceMachineList()
        {
            return itsChoiceMachineList;
        }

    }
}
