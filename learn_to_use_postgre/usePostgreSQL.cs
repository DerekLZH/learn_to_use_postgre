using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Mono.Security;

namespace learn_to_use_postgre
{
    class usePostgreSQL
    {
        public string str = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=fosber55060;Database=postgres";

        public static string TestConnection()
        {



            string strMessage = string.Empty;

            try
            {

                NpgsqlConnection conn = new NpgsqlConnection(str);

                conn.Open();

                strMessage = "Success";
                MessageBox.Show(strMessage);

                conn.Close();

            }

            catch
            {

                strMessage = "Failure";
                MessageBox.Show(strMessage);

            }

            return strMessage;

        }



        public static void TestGetData()
        {

            IDbConnection dbcon;

            dbcon = new NpgsqlConnection(str);

            dbcon.Open();

            IDbCommand dbcmd = dbcon.CreateCommand();

            dbcmd.CommandText = "SELECT machine, begintime, endtime, codezone, code, description_lingua1, description_lingua2, sequence, type FROM syncro_db_4544.alarms order by begintime asc limit 10;";

            IDataReader dr = dbcmd.ExecuteReader();


            string strResult = string.Empty;


            //dr.Read();
            //strResult = dr[0].ToString();



            while (dr.Read())
            {

                string machine = dr[0].ToString();

                string begintime = dr[1].ToString();

                string endtime = dr[2].ToString();

                string code = dr[4].ToString();



                strResult += "machine: " + machine + " | begintime:" + begintime + " | endtime:" + endtime + " | code:" + code + '\r' + '\n';

            }



            dr.Close();

            dr = null;

            textBox1.Text = strResult;

        }

        //sqrstr = "INSERT INTO derek_test.test_for_insert(test_insert_1)VALUES ('fuck');";
        public static void TestInsertData()
        {
            IDbConnection dbcon;

            dbcon = new NpgsqlConnection(str);

            dbcon.Open();

            IDbCommand dbcmd = dbcon.CreateCommand();

            dbcmd.CommandText = "INSERT INTO derek_test.test_for_insert(test_insert_1)VALUES ('fuck');";

            dbcmd.ExecuteNonQuery();

        }


        public static void TestDeleteData()
        {
            IDbConnection dbcon;

            dbcon = new NpgsqlConnection(str);

            dbcon.Open();

            IDbCommand dbcmd = dbcon.CreateCommand();

            dbcmd.CommandText = "DELETE FROM derek_test.test_for_insert WHERE test_insert_1= 'fuck' ;";

            dbcmd.ExecuteNonQuery();

        }

        public static void TestUpdateData()
        {
            IDbConnection dbcon;

            dbcon = new NpgsqlConnection(str);

            dbcon.Open();

            IDbCommand dbcmd = dbcon.CreateCommand();

            dbcmd.CommandText = "UPDATE derek_test.test_for_insert SET test_insert_1= 'damn' WHERE test_insert_1='fuck';";

            dbcmd.ExecuteNonQuery();

        }

    }
}
