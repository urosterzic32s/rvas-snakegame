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

// variables submited by user
$loginUsername = $_POST["loginUsername"];
$loginPassword = $_POST["loginPassword"];

$sql = "SELECT username FROM users WHERE username = '" . $loginUsername . "'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "Username already taken!";
} else {
    echo "Creating user...";
    $sql = "INSERT INTO users (username, password) VALUES ('" . $loginUsername . "', '" . $loginPassword. "')";

    if ($conn->query($sql) === TRUE) {
        echo "New record created successfully!";
    } else {
        echo "Error" . $conn->error;
    }
}

$conn->close();

?>