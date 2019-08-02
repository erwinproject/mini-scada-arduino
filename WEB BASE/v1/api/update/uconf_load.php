<?php
/*
* UPDATE DATA CONFIG LOAD
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

if(isset($_GET['token']) && isset($_GET['tegangan']) && isset($_GET['arus']) && isset($_GET['status'])){
    $token = $_GET['token'];
    $tegangan = $_GET['tegangan'];
    $arus = $_GET['arus'];
    $status = $_GET['status'];

	$com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $result_cektoken = mysqli_query($link, $com_cektoken);
    
	if(mysqli_num_rows($result_cektoken) > 0){
        $com_updates = "UPDATE setting_beban SET tegangan = '$tegangan', arus = '$arus', statusalat = '$status' WHERE token = '$token'";
        $result_updates = mysqli_query($link, $com_updates);
        if ($result_updates){
            echo 'Success Update Data';
        } else {
            echo 'Something Wrong';
        }
    } else {
        echo 'invalid token';
    }
}

?>