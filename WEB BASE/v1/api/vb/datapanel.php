<?php
/*
* VB DATA CONFIG LOAD
################## ERWINPROJECT ##################
CODER   : ERWIN NUR CAHYONO
KAMPUS  : UNIVERSITAS BHAYANGKARA SURABAYA
PRODI   : TEKNIK SISTEM TENAGA
SKRIPSI : MINI SCADA PLTS BERBASIS ARDUINO
################## ERWINPROJECT ##################
* jangan di hapus hargai penulis :) trims
*/
require ('../../config_db.php');
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

$response = array();

if(isset($_GET['token'])){
	$token = $_GET['token'];
	
	$com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
	$result_cektoken = mysqli_query($link, $com_cektoken);
	if(mysqli_num_rows($result_cektoken) > 0){
		// Perintah dibawah
		$com_show_data = "SELECT * FROM update_panel WHERE token = '$token'";
		$com_show_data2 = "SELECT * FROM setting_panel WHERE token = '$token'";

		$result_data = mysqli_query($link, $com_show_data);
		$result_data2 = mysqli_query($link, $com_show_data2);
		
		// DATA LAST UPDATE
		if(mysqli_num_rows($result_data) > 0){
			while($row = mysqli_fetch_array($result_data)){
				echo $row['tegangan'];
				echo '|';
				echo $row['arus'];
				echo '|';
				echo $row['daya'];
				echo '|';
				echo $row['statusalat'];
				echo '|';
				echo $row['statusrelay'];
				echo '|';
				echo $row['persenaki'];
				echo '|';
			}
		}

		// DATA PROTEKSI
		if(mysqli_num_rows($result_data2) > 0){
			while($row2 = mysqli_fetch_array($result_data2)){
				echo $row2['tegangan'];
				echo '|';
				echo $row2['arus'];
				echo '|';
				echo $row2['control'];
				echo '|';
				echo $row2['settimea'];
				echo '|';
				echo $row2['settimeb'];
			}
		}
		mysqli_free_result($result_data);
		mysqli_free_result($result_data2);
	} else {
		echo 'invalid token';
	}
} else {
	$response['success'] = 0;
	$response['message'] = "Parameter Salah";
	echo json_encode($response);
}

?>
