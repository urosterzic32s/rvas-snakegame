<?php
$servername = "localhost";
$username = "root";
$password = "123";
$dbname = "snakegame";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully <br/><div>eee</div>";

$sql = "SELECT id, username, highscore FROM users";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "ID: " . $row["id"]. " - Name: " . $row["username"]. " Highscore: " . $row["highscore"]. "<br>"; 
  }
} else {
  echo "0 results";
}
$conn->close();

?>