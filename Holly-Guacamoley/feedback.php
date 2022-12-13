<?php
include("db.php");

function clickStar(){

}
?>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" type="text/css" href="css/style8.css">
<!--Icon Library-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
	<title>Holly Guacamoley</title>
</head>
<body>
    <banner class="logo">
        <img src="afb/logo.png" width="15%" height="25%">
    </banner>
	<subbanner>
    <div class="navbar">
        <a href="home.php">Home</a>
        <a href="menu.php">Menu</a>
        <a href="ReserveringsPagina.php">Reserveren</a>
        <a class="active" href="feedback.php">Feedback</a>
      </div>
    </subbanner>
    <div class="container1">
    <form method="POST">
        <label for="voornaam">Voornaam:</label></br>
        <input type="text" id="voornaam" name="voornaam" required></br>
        <label for="achternaam">Achternaam:</label></br>
        <input type="text" id="achternaam" name="achternaam" required></br>
        <label for="email">Email:</label></br>
        <input type="email" id="email" name="email" required></br>
        <label for="feedback">Feedback:</label></br>
        <textarea type="textarea" id="feedback" name="feedback" maxlength="125" placeholder="Schrijf uw feedback.." style="height:100px" required></textarea></br>

        <!--Sterren-->
        <span class="fa fa-star"></span>
        <span class="fa fa-star "></span>
        <span class="fa fa-star "></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <br>
        <input type="submit" id="knop" name="submit">
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
    <?php
    Feedback($conn);
    ?>
</body>
</html>