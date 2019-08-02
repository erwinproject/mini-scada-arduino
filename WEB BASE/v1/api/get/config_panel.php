<?php
/*
* GET DATA CONFIG PANEL
################## ERWINPROJECT ##################
CODER   : ERWIN NUR CAHYONO
KAMPUS  : UNIVERSITAS BHAYANGKARA SURABAYA
PRODI   : TEKNIK SISTEM TENAGA
SKRIPSI : MINI SCADA PLTS BERBASIS ARDUINO
################## ERWINPROJECT ##################
* jangan di hapus hargai penulis :) trims
*/
require('../../config_db.php');

header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

$response = array();
if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}
$response = array();

if (isset($_GET['token'])){
    $token = $_GET['token'];

    $com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $cektoken = mysqli_query($link, $com_cektoken);
    if (mysqli_num_rows($cektoken) > 0){
        $com_getconfig = "SELECT * FROM setting_panel WHERE token = '$token'";
        $getconfig = mysqli_query($link, $com_getconfig);

        if (mysqli_num_rows($getconfig)){
            $getconfig = mysqli_fetch_array($getconfig);

            $dataconfig = array();

            $dataconfig["tegangan"] = $getconfig['tegangan'];
            $dataconfig["arus"] = $getconfig["arus"];
            $dataconfig["control"] = $getconfig["control"];
            $dataconfig["settimea"] = $getconfig["settimea"];
            $dataconfig["settimeb"] = $getconfig["settimeb"];

            $response["success"] = 1;
            $response["dataconfig"] = array();

            array_push($response["dataconfig"], $dataconfig);
            echo json_encode($response);
        } else {
            $response["success"] = 0;
            $response["message"] = "No Data";

            echo json_encode($response);
        };
    
    } else {
        echo 'invalid token';
    };
} else {
    $response["success"] = 0;
    $response["message"] = "Parameter Salah";

    echo json_encode($response);
}

?>