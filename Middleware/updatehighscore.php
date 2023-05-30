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


// variables submited by user
$loginUsername = $_POST["loginUsername"];
$score = $_POST["score"];

$sql = "UPDATE users SET highscore = '" . $score . "' WHERE username = '" . $loginUsername . "'";
$result = $conn->query($sql);


$conn->close();

?>