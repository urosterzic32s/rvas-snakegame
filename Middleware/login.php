<?php

// KONEKCIJA

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


// variables submited by user
$loginUsername = $_POST["loginUsername"];
$loginPassword = $_POST["loginPassword"];

$sql = "SELECT id, username, highscore FROM users WHERE username = '" . $loginUsername . " 'AND password = '" . $loginPassword . "'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo $row["highscore"];
    
  }
} else {
  echo "bad";
}

$conn->close();

?>