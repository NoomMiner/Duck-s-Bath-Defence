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
                function addRow($name, $score, $date) {
                    // generates a table row with given values
                    echo "<tr><td>$name</td><td>$score</td><td>$date</td></tr>";
                }

                addRow("Timmy", 200, "Today");
                addRow("Timmy", 300, "Today");
                addRow("Bob", 64, "Yesterday");
            ?>
        </table>
    </body>
</html>
