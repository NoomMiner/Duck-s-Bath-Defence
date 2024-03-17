<!DOCTYPE html>
<html>
    <head>
        <title>Leaderboard</title>
        <link rel="stylesheet" href="styles.css">
	<script src="ducksFunction.js"> </script>
    </head>
    <body>
	<input type="button homeButton" class="button homeButton" onclick="gotoHome()" value="Return to Home">
        <br>
        <h1 class="lb-header">Leaderboard</h1>
        <?php
            // database connection parameters
            $servername = "dbd-leaderboard.c7sicgqg6s25.us-west-1.rds.amazonaws.com";
            $username = "admin";
            $password = "ducksbathdefense";
            $db = "leaderboard";

            function addRow($name, $score, $date) {
                // generates a table row with given values
                echo "<tr>
                      <td class=\"namedata\">$name</td>
                      <td class=\"scoredata\">$score</td>
                      <td class=\"datedata\">$date</td>
                      </tr>";
            }
                
            try {
                // Create a PDO connection
                $conn = new PDO("mysql:host=$servername;dbname=$db", $username, $password);
                // Set the PDO error mode to exception
                $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            
                // Query to select high scores from the database
                $sql = "SELECT name, score, date FROM Entry ORDER BY score DESC";
                $stmt = $conn->prepare($sql);
                $stmt->execute();
                
                echo "<table>";
                addRow("<b>Name</b>", "<b>Score</b>", "<b>Date</b>");
                
                // Display data in a table
                while($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
                    addRow($row["name"], $row["score"], $row["date"]);
                }
                
                /*
                testing
                addRow("lol", "123", "2024-03-16");
                addRow("lol", "123", "2024-03-16");
                addRow("lol", "123", "2024-03-16");
                addRow("lol", "123", "2024-03-16");
                addRow("lol", "123", "2024-03-16");
                */

                echo "</table>";
                
            } catch(PDOException $e) {
                echo "<h2>Error: " . $e->getMessage() . "</h2>";
            }

            // Close connection
            $conn = null;
        ?>
    </body>
</html>
