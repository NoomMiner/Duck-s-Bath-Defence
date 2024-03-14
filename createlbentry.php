<?php
$servername = "dbd-leaderboard.c7sicgqg6s25.us-west-1.rds.amazonaws.com";
$username = "admin";
$password = "ducksbathdefense";
$db = "leaderboard";

try {
    // Create a PDO connection
    $conn = new PDO("mysql:host=$servername;dbname=$db", $username, $password);
    // Set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    // set up SQL query
    $inName = $_GET["name"];
    $inScore = $_GET["score"];
    $inWave = $_GET["wave"];
    $inMode = $_GET["mode"];
    $inDate = $_GET["date"];
    $query = "INSERT INTO Entry 
              VALUES(DEFAULT, '$inName', $inScore, $inWave, '$inMode', '$inDate');";

    // execute query
    $stmt = $conn->prepare($query);
    $stmt->execute();

    // show success message
    echo "<h1>Leaderboard entry was added successfully</h1>";
} catch (PDOException $e) {
    echo "<h1>Error: " . $e->getMessage() . "</h1>";
}
?>