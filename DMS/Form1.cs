using MySql.Data.MySqlClient;
namespace DMS
{
    public partial class Form1 : Form
    {
        string query;
        int tableMain_CountColumns;
        int tableMain_CountRows;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnnect_Click(object sender, EventArgs e)
        {
            table_Main.Rows.Clear();
            table_Main.Columns.Clear();
            String strConnect = $"server={textBoxServer.Text};user={textBoxUser.Text};database={textBoxDatabase.Text};password={textBoxPassword.Text};";
            using (MySqlConnection conn = new MySqlConnection(strConnect))
            {
                MySqlCommand cmd_showTable = new MySqlCommand($"SELECT * FROM {textBoxTable.Text};", conn);
                MySqlCommand cmd_countColumns = new MySqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{textBoxTable.Text}'", conn);
                MySqlCommand cmd_countRows = new MySqlCommand($"SELECT COUNT(1) FROM {textBoxTable.Text}", conn);
                MySqlCommand cmd_nameColumns = new MySqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{textBoxTable.Text}';", conn);

                conn.Open();
                if (cmd_countColumns.ExecuteScalar() != null && cmd_countRows.ExecuteScalar() != null)
                {
                    tableMain_CountColumns = int.Parse(cmd_countColumns.ExecuteScalar().ToString());
                    tableMain_CountRows = int.Parse(cmd_countRows.ExecuteScalar().ToString());
                }
                cmd_countRows.Dispose();
                cmd_countColumns.Dispose();

                MySqlDataReader reader_1 = cmd_nameColumns.ExecuteReader();
                while (reader_1.Read())
                {
                    int i = 0;
                    table_Main.Columns.Add(reader_1.GetString(i), reader_1.GetString(i));
                    i++;
                }
                cmd_nameColumns.Dispose();
                reader_1.Close();

                MySqlDataReader reader_2 = cmd_showTable.ExecuteReader();
                string[] tableMain_Row = new string[tableMain_CountColumns];

                while (reader_2.Read())
                {
                    for (int j = 0; j < tableMain_CountColumns; j++)
                    {
                        if (!reader_2.IsDBNull(j))
                        {
                            tableMain_Row[j] = reader_2.GetString(j);
                        }
                        else
                        {
                            tableMain_Row[j] = "Null";
                        }
                    }
                    table_Main.Rows.Add(tableMain_Row);
                }
                cmd_showTable.Dispose();
                conn.Close();
            }
            
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            query = textBoxForQuery.Text;
            string[] arrQuery = new string[1];
            int count = 1;
            foreach (char? a in query)
            {
                if(a != ';')
                {
                    arrQuery[count-1] += a.ToString();
                }
                else
                {
                    arrQuery[count - 1] += a.ToString();
                    count++;
                    Array.Resize(ref arrQuery, count);
                }
                if(a == null)
                {
                    break;
                }
            }

            String strConnect = $"server={textBoxServer.Text};user={textBoxUser.Text};database={textBoxDatabase.Text};password={textBoxPassword.Text};";
            using (MySqlConnection conn = new MySqlConnection(strConnect))
            {
                conn.Open();
                try
                {
                    for (int i = 0; i < arrQuery.Length; i++)
                    {
                        MySqlCommand cmd_queryExecute = new MySqlCommand(arrQuery[i], conn);
                        cmd_queryExecute.ExecuteNonQuery();
                        cmd_queryExecute.Dispose();
                    }
                }
                catch (Exception)
                {
                }
                conn.Close();
            }
        }
    }
}