<!--Begin van php-->
<?php
//Session aanmaken
session_start();
if(isset($_GET['reset'])){
  session_destroy();
  header("location:battle.php");
}
//Variabelen definen
$hp = 100;
$hilichurl = "afb/hilichurl.png";
//Een attack aanmaken die een waarde afhaald van de progress bar(health bar)
if(isset($_GET['attack'])){
  if($_GET['attack'] == 'a'){
    $hp = 100;
    $hp = $_GET['attack'];

  }else{
    $hp = $hp - $_GET['attack'];
  }
}
if ($hp == 0) {
  $hilichurl = "";
}
?>
<!--Begin van html-->
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" href="style.css">
    <!--Style toevoegen-->
    <style media="screen">
    body{
      background-image: url('afb/battleimg.jpg');
      background-size: cover;
    }

    </style>
  </head>
  <body>
    <!--Een attack button die een random waarde geeft tussen 1 en 100-->
    <a href="battle.php?attack=<?php echo rand(1, 100) ?>">
    <div class="attackbutton">
    <img src="afb/attackbutton.png" alt="">
    </div>
    </a>
    <!--Terug button-->
    <div class="terug">
      <a href="home.php">
        <img src="afb/terug.png" alt="" height="100%" width="50%">
      </a>
    </div>
    <!--Afbeelding van de Traveler-->
    <div class="travelerbattle">
      <img src="afb/traveler5.png" alt="">
    </div>
    <!--De healthbar-->
    <div class="healthbar">
      <progress value="<?php echo $hp;?>" max="100">
      </progress>
    </div>
    <!--Afbeelding van een enemie-->
    <div class="hilichurl">
        <img src="<?php echo $hilichurl?>" alt="">
    </div>
    <!--Reset knop-->
    <div class="reset">
    <a href="battle.php?reset=">Reset</a>
    </div>

  </body>
</html>
