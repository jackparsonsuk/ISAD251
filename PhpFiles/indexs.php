<form method="post">
        <input type="text" name="userName" />
		<input type="password" name="passWord" />
        <input type="submit" value="Enter"/>
</form>

<?php
	
    $username = $_POST["userName"];
	$password = $_POST["passWord"];
	if($username == "admin" && $password =="letmein"){
		echo "LOGGEDIN ";
	}
	else{
		echo "NO LOG IN";
	}
    
?>
