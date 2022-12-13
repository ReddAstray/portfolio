<?php

    include("db.php");

    $MaxPers = 12;
    $DatumBeschrikbaar = date("Y-m-d");

$servername='localhost';
$username='root';
$password='';
$dbname = "hg";
$conn = mysqli_connect($servername,$username,$password,$dbname);
if(!$conn){
   die('Could not Connect MySql Server:' .mysql_error());
}

$date = "SELECT SUM(aantalpersonen) FROM reservering WHERE `datum` = '$DatumBeschrikbaar'";


?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <link rel="stylesheet" type="text/css" href="css/style8.css">
    <title>Reserverings Pagina</title>
</head>
<body>
    <banner class="logo">
        <img src="afb/logo.png" width="15%" height="25%">
    </banner>
    <div class="navbar">
        <a href="home.php">Home</a>
        <a href="menu.php">Menu</a>
        <a class="active" href="ReserveringsPagina.php">Reserveren</a>
        <a href="feedback.php">Feedback</a>
      </div>
    <div class="container1">
    <form method="POST">
        <label>Aantal personen:</label></br>
        <select required name="personen" id="pers">
            <option value="1">1 persoon</option>
            <?php
            for ($i=2; $i <= $MaxPers ; $i++) {
                echo "<option value='$i'>$i personen</option>";
            }
            ?>
        </select></br>
        </br><label>Selecteer datum:</label></br>
        <input name="datum" type=date required min="<?php echo $DatumBeschrikbaar; ?>"value="<?php echo $DatumBeschrikbaar; ?>">
        </br></label>Selecteer Tijdsslot:</label></br>
        <select required name="tijdsslot" id="tijd">
            <?php
            for ($i=10; $i <= 20 ; $i++) {
                for ($j = "00"; $j<=30; $j+= 30) {
                    echo "<option value='$i:$j'>$i:$j</option>";
                }
            }
            ?>
        </select>
<!--    <select>-->
<!--            echo "<option value='00'>00</option>";-->
<!--        echo "<option value='30'>30</option>";-->
<!--    </select>-->
        </br></br><label>Reserverings naam:</label></br>
        <input name="naam" type=text placeholder="voer hier uw naam in."> 
        </br></br><input type=submit id="Knop" value="Reserveren" name="Reserveren">
    </form>
        </div>

    <div class="footer">
        <h1>Contactgegevens</h1>
        <p>Adres: Henri Dunantstraat 40</p>
        <p>5807 ES Oostrum</p>
        <div class="footermid">
            <a href="mailto:fayaaz.abdoel@student.gildeopleidingen.nl">Email ons</a>
            <a href="callto:+310617411258">Bel ons</a>
        </div>
    </div>

    <?php if(isset($_POST['Reserveren']))//verstuurt wat er in de form is ingvuld naar de databasse
    {
      echo "test2";
       $personen = $_POST['personen'];
       $datum = $_POST['datum'];
       $tijdsslot = $_POST['tijdsslot'];
       $naam = $_POST['naam'];
       // is de sql statement
      $sql = "INSERT INTO reservering (aantalpersonen,datum,tijdsslot,naam) VALUES ('$personen','$datum','$tijdsslot','$naam')";
          if (mysqli_query($conn, $sql)) {
          } else {
            echo "Error: " . $sql . ":-" . mysqli_error($conn);
          }
        mysqli_close($conn);

      } ?>
</body>
</html>