using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PocketWorld
{
    class PlayerDBConnectManager
    {
        private Player itsPlayer;

        private List<Pocketmon> itsPlayerPocketmonList;

        private List<ChoiceMachine> itsChoiceMachineList;

        public PlayerDBConnectManager()
        {
            itsPlayer = null;
            itsPlayerPocketmonList = null;
            itsChoiceMachineList = null;
        }

        /* DB Connect, Load, Select, Save 를 위해 필요한 메서드들 */
        private MySqlConnection  ConnectToDB()
        {
            return new MySqlConnection("Server=220.66.67.250;Database=d201019010_2;Uid=201019010;Pwd=mis5312;");
        }

        public bool initConnectionWithPlayer(string player_id, string player_pw)
        {
            if ( LoadPlayer(player_id, player_pw) )
            {
                if (LoadChoiceMachineList() && LoadPlayerPocketmonList(player_id))
                {
                    return true;
                }
            }
            return false;
        }

        private bool LoadPlayer(String player_id, String player_pw)
        {
            String sql = "select * from Player where player_id=@value_id and player_pw=@value_pw;";
            bool bSucces = false;
            using (MySqlConnection conn = ConnectToDB())
            {
                conn.Open();

                using (MySqlCommand comm = new MySqlCommand(sql,conn))
                {
                    comm.Prepare();
                    comm.Parameters.AddWithValue("@value_id", player_id);
                    comm.Parameters.AddWithValue("@value_pw", player_pw);

                    using (MySqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itsPlayer = new Player();

                            itsPlayer.Id = (string)reader["player_id"];
                            itsPlayer.Pw = (string)reader["player_pw"];
                            itsPlayer.Coin = (int)reader["possess_coin"];
                            itsPlayer.IncomeLevel = (int)reader["income_level"];
                            bSucces = true;
                        }
                    }
                }
            }
            return bSucces;
        }

        public bool SavePlayer()
        {
            String sql = "update Player set possess_coin=@coin, income_level=@level where player_id=@id;";
            bool bSucces = false;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        comm.Prepare();
                        comm.Parameters.AddWithValue("@coin", itsPlayer.Coin);
                        comm.Parameters.AddWithValue("@level", itsPlayer.IncomeLevel);
                        comm.Parameters.AddWithValue("@id", itsPlayer.Id);

                        comm.ExecuteNonQuery();

                        bSucces = true;
                    }
                }
            }

            return bSucces;
        }

        public int CreatePlayerPocketmon(int mon_id)    // NEED TEST
        {
            String sql = "insert into Pocketmon(mon_id,player_id) values(@mon_id, @player_id)";
            int pocketmonId= -1;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        comm.Prepare();
                        comm.Parameters.AddWithValue("@mon_id", itsPlayer.Coin);
                        comm.Parameters.AddWithValue("@player_id", itsPlayer.IncomeLevel);

                        comm.ExecuteNonQuery();

                        pocketmonId = (int) comm.LastInsertedId;
                    }
                }
            }

            return pocketmonId;
        }

        public bool DeletePlayerPocketmon(int pocketmon_id)
        {
            String sql = "delete from Pocketmon where pocketmon_id=@pocketmon_id;";
            bool bSucces = false;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        comm.Prepare();
                        comm.Parameters.AddWithValue("@pocketmon_id", pocketmon_id);

                        comm.ExecuteNonQuery();

                        bSucces = true;
                    }
                }
            }

            return bSucces;
        }

        private int SelectPlayerOwnedPocketmonCountByLevel(int level)
        {
            return 0;
        }

        private bool LoadPlayerPocketmonList(String player_id)
        {
            return true;
        }

        private bool LoadChoiceMachineList()
        {
            return true;
        }





        /* 접속 후에 사용자가 하는 행동들 */
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




        /* 접속 정보를 시스템이 사용하기 위해 만든 getter checker 들 */
        public bool isPlayerLoaded()
        {
            return (itsPlayer != null) ? true : false;
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
