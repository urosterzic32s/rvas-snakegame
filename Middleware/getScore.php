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


$sql = "SELECT username, highscore FROM users ORDER BY highscore desc LIMIT 5";

$result = $conn->query($sql);

if ($result->num_rows > 0) {
    $scores = array();

    while($row = $result->fetch_assoc()) {
        $scores[] = $row;
    }

    echo json_encode($scores);
} else {

}

$conn->close();

?>