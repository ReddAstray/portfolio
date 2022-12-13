<?php 
	// Maakt een connectie met de database
	$servername='localhost';
    $username='root';
    $password='';
    $dbname = "hg";
    $conn=mysqli_connect($servername,$username,$password,$dbname);
      if(!$conn){
          die('Could not Connect MySql Server:' .mysql_error($conn));
        }

  function Feedback($conn){
//    echo "Test";
  if(isset($_POST['submit'])){//verstuurt wat er in de form is ingvuld naar de databasse
//    echo "Test2";
     $Vnaam = $_POST['voornaam'];
     $Anaam = $_POST['achternaam'];
     $email = $_POST['email'];
     $feedback = $_POST['feedback'];
     // is de sql statement
     $sql = "INSERT INTO feedback (voornaam,achternaam,email,feedback)
     VALUES ('$Vnaam','$Anaam','$email','$feedback')";
      //kijkt of er errors zijn
      if (mysqli_query($conn, $sql)) {
//          echo "great succes";
      } else {
        // echo "Error: " . $sql . ":-" . mysqli_error($conn);
      }
     mysqli_close($conn);
    }
  }
?>