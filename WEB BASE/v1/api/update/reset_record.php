<?php
/*
################## ERWINPROJECT ##################
CODER   : ERWIN NUR CAHYONO
KAMPUS  : UNIVERSITAS BHAYANGKARA SURABAYA
PRODI   : TEKNIK SISTEM TENAGA
SKRIPSI : MINI SCADA PLTS BERBASIS ARDUINO
################## ERWINPROJECT ##################
* jangan di hapus hargai penulis :) trims
*/
require('../../config_db.php');

header('content-type: application/json; charset=utf-8');
header("access-control-allow-origin: *");

if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

$response = array();

if (isset($_GET['token']) && isset($_GET['tabel'])) {
    $token = $_GET['token'];
    $tabelku = $_GET['tabel'];
    $com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $result_cektoken = mysqli_query($link, $com_cektoken);

    if(mysqli_num_rows($result_cektoken) > 0){
        $sql_resettbl = "DELETE FROM $tabelku WHERE token = '$token'";
        $result = mysqli_query($link, $sql_resettbl);
        if ($result){
            echo 'Reset Done';
        } else {
            echo 'Reset Failed';
            echo $sql_resettbl;
        }
    } else {
        echo 'invalid token';
    }
    //$sql_resettbl = "TRUNCATE TABLE $tabelku";
} else {

    $response["success"] = 0;
    $response["message"] = "Why are you in here ?";

    echo json_encode($response);
}