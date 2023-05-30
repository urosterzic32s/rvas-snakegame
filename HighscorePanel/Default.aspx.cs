using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "server=localhost;user id=root;password=;database=snakegame;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        string query = "SELECT * FROM users ORDER BY highscore DESC;";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader reader = command.ExecuteReader();

        gridViewHighscores.DataSource = reader;
        gridViewHighscores.DataBind();

        reader.Close();
        connection.Close();
    }
}