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
        private bool bIsPlayerLoaded;


        public PlayerDBConnectManager()
        {
            itsPlayer = new Player();
            itsPlayerPocketmonList = new List<Pocketmon>();
            itsChoiceMachineList = new List<ChoiceMachine>();
            bIsPlayerLoaded = false;
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
                            itsPlayer.Id = (string)reader["player_id"];
                            itsPlayer.Pw = (string)reader["player_pw"];
                            itsPlayer.Coin = (int)reader["possess_coin"];
                            itsPlayer.IncomeLevel = (int)reader["income_level"];
                            bIsPlayerLoaded = true;
                        }
                        bSucces = true;
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

        public bool SavePocketmonStatus(int pocketmon_id, int pocketmon_status)
        {
            String sql = "update Pocketmon set pocketmon_status=@pocketmon_status where pocketmon_id=@pocketmon_id;";
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
                        comm.Parameters.AddWithValue("@pocketmon_status", pocketmon_status);

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
                        comm.Parameters.AddWithValue("@mon_id", mon_id);
                        comm.Parameters.AddWithValue("@player_id", itsPlayer.Id);

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

        private int SelectPlayerOwnedPocketmonCountByLevel(String player_id, int rank)
        {
            String sql = "select count(pocketmon_id) from pocketmon left join mon on pocketmon.mon_id = mon.mon_id where player_id=@player_id and rank=@rank";
            int? count = -1;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        comm.Prepare();
                        comm.Parameters.AddWithValue("@player_id", player_id);
                        comm.Parameters.AddWithValue("@rank", rank);

                        count = int.Parse( comm.ExecuteScalar().ToString());

                    }
                }
            }

            return (int)count;
        }

        private bool LoadPlayerPocketmonList(String player_id)
        {
            String sql = "select * from pocketmon left join mon on pocketmon.mon_id = mon.mon_id where player_id=@player_id;";
            bool bSucces = false;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        comm.Prepare();
                        comm.Parameters.AddWithValue("@player_id", player_id);

                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {
                            itsPlayerPocketmonList.Clear();
                            while (reader.Read())
                            {
                                Pocketmon pocketmon = new Pocketmon();
                                pocketmon.PocketmonId       = (int)reader["pocketmon_id"];
                                pocketmon.MonId             = (int)reader["mon_id"];
                                pocketmon.PocketmonStatus   = (int)reader["pocketmon_status"];
                                pocketmon.Rank              = (int)reader["rank"];
                                pocketmon.GainCoin          = (int)reader["gain_coin"];
                                pocketmon.PlayerId          = (String)reader["player_id"];
                                pocketmon.MonName           = (String)reader["mon_name"];
                                pocketmon.MonExplanation    = (String)reader["mon_explanation"];
                                pocketmon.GainCoinExplanation   = (String)reader["gain_coin_explanation"];

                                pocketmon.btnSave.Click += onPocketmonSaveClick;
                                pocketmon.btnLoad.Click += onPocketmonLoadClick;

                                itsPlayerPocketmonList.Add(pocketmon);
                            }
                            bSucces = true;
                        }
                    }
                }
            }
            return bSucces;
        }

        private bool LoadChoiceMachineList()
        {
            String sql = "select * from choice_machine;";

            bool bSucces = false;

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();

                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {
                            itsChoiceMachineList.Clear();
                            while (reader.Read())
                            {

                                ChoiceMachine machine = new ChoiceMachine();
                                machine.MachineId   = (int)reader["machine_id"];
                                machine.RankNormal  = (int)reader["rank_normal"];
                                machine.RankRare    = (int)reader["rank_rare"];
                                machine.ChanceRare  = (int)reader["chance_rare"];
                                machine.StartCost   = (int)reader["start_cost"];
                                machine.CostIncMultiplier   = (int)reader["cost_inc_multiplier"];

                                LoadPocketmonIdListWithRankToIdList(machine.NormalMonIdArray, machine.RankNormal);
                                LoadPocketmonIdListWithRankToIdList(machine.RareMonIdArray, machine.RankRare);
                                itsChoiceMachineList.Add(machine);

                                machine.btnHit.Click += this.onChoiceMachineClick;
                            }
                            bSucces = true;
                        }
                    }
                }

            }

            return bSucces;
        }

        private void LoadPocketmonIdListWithRankToIdList(List<int> idList, int rank)
        {
            String sql = "select mon_id from mon where rank=@rank;";

            if (isPlayerLoaded())
            {
                using (MySqlConnection conn = ConnectToDB())
                {
                    conn.Open();
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {

                        comm.Prepare();
                        comm.Parameters.AddWithValue("@rank", rank);

                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {

                            idList.Clear();
                            while (reader.Read())
                            {
                                int monId = (int)reader["mon_id"];
                                idList.Add(monId);
                            }
                        }
                    }
                }

            }
        }




        /* 접속 후에 사용자가 하는 행동들 */
        public bool UpgradeIncomeLevel()
        {
            bool bSuccess = false;
            if(isPlayerLoaded())
            {
                int curIncomeLevel = itsPlayer.IncomeLevel;
                int upgradeCost = GetCurPlayerIncomeUpgradeCost();

                if (itsPlayer.Coin >= upgradeCost)
                {
                    itsPlayer.Coin -= upgradeCost;
                    itsPlayer.IncomeLevel += 1;
                    SavePlayer();
                    bSuccess = true;
                }
            }
            return bSuccess;
        }

        public int GetCurPlayerIncomeUpgradeCost()
        {
            int upgradeCost = 0;

            upgradeCost = (int) Math.Pow(10, itsPlayer.IncomeLevel);

            return upgradeCost;
        }

        public int BuyRandomPocketmon(int machine_id)
        {
            int pocketmon_id = -1;
            if (isPlayerLoaded())
            {
                ChoiceMachine machine = null;
                foreach(ChoiceMachine cur in itsChoiceMachineList)
                {
                    if(cur.MachineId == machine_id)
                    {
                        machine = cur;
                        break;
                    }
                }
                if(machine != null)
                {
                    int playerMonCountForMachineRank = SelectPlayerOwnedPocketmonCountByLevel(itsPlayer.Id, machine.RankNormal);

                    int price = machine.CalculateSpinCost(playerMonCountForMachineRank);

                    if(itsPlayer.Coin >= price)
                    {
                        itsPlayer.Coin -= price;
                        int randomGeneratedMonsterId = machine.SpinForRandomMonId();
                        pocketmon_id = CreatePlayerPocketmon(randomGeneratedMonsterId);
                        SavePlayer();
                    }
                }
            }
                return pocketmon_id;
        }

        public bool ChangePlayerPocketmonStatus(int pocketmon_id, int status)
        {
            bool bSuccess = false;
            if (isPlayerLoaded())
            {
                Pocketmon selectPocketmon = null;
                foreach(Pocketmon cur in itsPlayerPocketmonList)
                {
                    if(cur.PocketmonId == pocketmon_id)
                    {
                        selectPocketmon = cur;
                        break;
                    }
                }

                if(selectPocketmon != null)
                {
                    selectPocketmon.PocketmonStatus = status;
                    SavePocketmonStatus(pocketmon_id, status);
                    bSuccess = true;
                }
            }
                return bSuccess;
        }




        /* 접속 정보를 시스템이 사용하기 위해 만든 getter checker 들 */
        public bool isPlayerLoaded()
        {
            return bIsPlayerLoaded;
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


        /* 인터페이스를 위한 이벤트 헨들러들 */

        public void onChoiceMachineClick(object sender, System.EventArgs e)
        {
            int id = ((ChoiceMachine)((Button)sender).Parent).MachineId;

            int buyResult = BuyRandomPocketmon(id);
            if(buyResult >= 1)
            {
                MessageBox.Show("뽑기 결과 : " + buyResult);
            }
            else
            {
                MessageBox.Show("구입 실패...");
            }

        }

        public void onPocketmonLoadClick(object sender, System.EventArgs e)
        {
            int id = ((Pocketmon)((Button)sender).Parent).PocketmonId;
            MessageBox.Show("Load : " + id);
            ChangePlayerPocketmonStatus(id, 1);
        }

        public void onPocketmonSaveClick(object sender, System.EventArgs e)
        {
            int id = ((Pocketmon)((Button)sender).Parent).PocketmonId;
            MessageBox.Show("Save : " + id);
            ChangePlayerPocketmonStatus(id, 0);
        }
    }
}
