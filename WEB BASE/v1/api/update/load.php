<?php
 /*
 * UPDATE INSERT LOAD
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

if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

$response = array();
if (isset($_GET['token']) && isset($_GET['tegangan']) && isset($_GET['arus']) && isset($_GET['daya']) && isset($_GET['relay'])){
    $token = $_GET['token'];
    $tegangan = $_GET['tegangan'];
    $arus = $_GET['arus'];
    $daya = $_GET['daya'];
    $relay = $_GET['relay'];

    $com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $cektoken = mysqli_query($link, $com_cektoken);
    if (mysqli_num_rows($cektoken) > 0){
        $com_record = "INSERT INTO record_beban(token,tegangan,arus,daya,statusrelay) VALUES('$token', '$tegangan', '$arus', '$daya', '$relay')";
        $com_update = "UPDATE update_beban SET tegangan = '$tegangan', arus = '$arus', daya = '$daya', statusrelay = '$relay' WHERE token = '$token'";
        $result_record = mysqli_query($link, $com_record);
        $result_update = mysqli_query($link, $com_update);    

        if ($result_record && $result_update){
            $response["success"] = 1;
            $response["message"] = "Permintaan Ok";

            echo json_encode($response);
        } else {
            $response["success"] = 0;
            $response["message"] = "Permintaan ditolak";

            echo json_encode($response);
        };
    } else {
        echo 'invalid token';
    }
} else {
    $response["success"] = 0;
    $response["message"] = "Parameter Salah";

    echo json_encode($response);
}

?>