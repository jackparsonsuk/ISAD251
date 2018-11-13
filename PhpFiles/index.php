<!DOCTYPE html>
<?php
    require_once 'functions.php';
    if(isset($_POST['table']))
    {
        $tableName = $_POST['table'];
    }
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <select name="table" id="ddTable">
            <option value="customers">customers</option>
            <option value="Orders">Orders</option>
            <option value="Order-Lines">Order Lines</option>
        </select>
        
        <h1>CREATE</h1>
        <p>
            
        </p>
        
        <h1>READ</h1>
        <p>
            <?php
			echo "starting";
                
					
                    $results = getAll("customers");
					 foreach($results as $row)
					{
						
						echo $row['customer_first_name']."<br/>";
					}
					
					
					$sql ='select * from customers';
					$q = getConnection() -> query($sql);				
					$q->setFetchMode(PDO::FETCH_ASSOC);

					

					
                
            ?>
        </p>
        <h1>UPDATE</h1>
        
        <h1>DELETE</h1>
		
		
		<table class="table table-bordered table-condensed">
					<thead>
						<tr>
							<th>First Name</th>
							<th>Last Name</th>
							<th>Email</th>
						</tr>
					</thead>
					<tbody>
						<?php while ($r = $q->fetch()): ?>
							<tr>
								<td><?php echo htmlspecialchars($r['customer_first_name']) ?></td>
								<td><?php echo htmlspecialchars($r['customer_last_name']); ?></td>
								<td><?php echo htmlspecialchars($r['customer_email']); ?></td>
							</tr>
						<?php endwhile; ?>
					</tbody>
				</table>
        
    </body>
</html>
