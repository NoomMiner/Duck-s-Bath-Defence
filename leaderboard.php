<!DOCTYPE html>
<html>
    <head>
        <title>Leaderboard</title>
        <link rel="stylesheet" href="styles.css">
    </head>
    <body>
        <h1>Leaderboard</h1>
        <table>
            <tr>
                <th>Name</th>
                <th>Score</th>
                <th>Date</th>
            </tr>
            <?php
                // database connection parameters
                $servername = "dbd-leaderboard.c7sicgqg6s25.us-west-1.rds.amazonaws.com"
                $username = "admin"
                $password = "ducksbathdefense"
                $db = "dbd-leaderboard"

                function addRow($name, $score, $date) {
                    // generates a table row with given values
                    echo "<tr><td>$name</td><td>$score</td><td>$date</td></tr>";
                }
                
                try {
                    // Create a PDO connection
                    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
                    // Set the PDO error mode to exception
                    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            
                    // Query to select high scores from the database
                    $sql = "SELECT name, score, date FROM leaderboard ORDER BY score DESC";
                    $stmt = $conn->prepare($sql);
                    $stmt->execute();
            
                    // Display data in a table
                    while($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
                        addRow($row["name"], $row["score"], $row["date"]);
                    }
                } catch(PDOException $e) {
                    echo "<tr><td>Error: " . $e->getMessage() . "</td></tr>";
                }
                // Close connection
                $conn = null;
            ?>
        </table>
    </body>
</html>
