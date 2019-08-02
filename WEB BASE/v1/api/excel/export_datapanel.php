<!DOCTYPE html>
<html>

<head>
    <title>EXPORT DATA PANEL</title>
</head>

<body>
    <style type="text/css">
    body {
        font-family: sans-serif;
    }

    table {
        margin: 20px auto;
        border-collapse: collapse;
    }

    table th,
    table td {
        border: 1px solid #3c3c3c;
        padding: 3px 8px;

    }

    a {
        background: blue;
        color: #fff;
        padding: 8px 10px;
        text-decoration: none;
        border-radius: 2px;
    }
    </style>

    <?php
    header("Content-type: application/vnd-ms-excel");
	// header("Content-type: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
    
	header("Content-Disposition: attachment; filename=data_panel_recordserver.xls");
	?>

    <center>
        <h1>EXPORT DATA PANEL</h1>
    </center>

    <table border="1">
        <tr>
        <th>No</th>
			<th>Date</th>
			<th>Tegangan</th>
			<th>Arus</th>
			<th>Daya</th>
            <th>Status Alat</th>
            <th>Status Relay</th>
            <th>Persen Aki</th>
        </tr>
        <?php 
		require('../../config_db.php');
		if(isset($_GET['token'])){
            $token = $_GET['token'];

            $data = mysqli_query($link,"SELECT * FROM record_panel WHERE token = '$token'");
            $id = 1;
            while($d = mysqli_fetch_array($data)){
            ?>
                <tr>
                    <td><?php echo $no++; ?></td>
                    <td><?php echo $d['date']; ?></td>
                    <td><?php echo $d['tegangan']; ?></td>
                    <td><?php echo $d['arus']; ?></td>
                    <td><?php echo $d['daya']; ?></td>
                    <td><?php echo $d['statusalat']; ?></td>
                    <td><?php echo $d['statusrelay']; ?></td>
                    <td><?php echo $d['persenaki']; ?></td>
                </tr>
            <?php 
            }
		
		}
		?>
    </table>
</body>

</html>