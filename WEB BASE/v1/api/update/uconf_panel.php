<?php
/*
* UPDATE DATA CONFIG PANEL
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

if(isset($_GET['token']) && isset($_GET['tegangan']) && isset($_GET['arus']) && isset($_GET['control']) && isset($_GET['timea']) && isset($_GET['timeb'])){
    $token = $_GET['token'];
    $tegangan = $_GET['tegangan'];
    $arus = $_GET['arus'];
    $control = $_GET['control'];
    $timea = $_GET['timea'];
    $timeb = $_GET['timeb'];

	$com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $result_cektoken = mysqli_query($link, $com_cektoken);
    
	if(mysqli_num_rows($result_cektoken) > 0){
        $com_update = "UPDATE setting_panel SET tegangan = '$tegangan', arus = '$arus', control = '$control', settimea = '$timea', settimeb = '$timeb' WHERE token = '$token'";
        $result_update = mysqli_query($link, $com_update);
        if ($result_update){
            echo 'Success Update Data';
        } else {
            echo 'Something Wrong';
        }
    } else {
        echo 'invalid token';
    }
}

?>