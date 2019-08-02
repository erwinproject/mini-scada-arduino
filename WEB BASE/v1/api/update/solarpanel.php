<?php
 /*
 * UPDATE INSERT PANEL
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

if (isset($_GET['token']) && isset($_GET['date']) && isset($_GET['tegangan']) && isset($_GET['arus']) && isset($_GET['daya']) && isset($_GET['status']) && isset($_GET['relay']) && isset($_GET['persen'])){
    $token = $_GET['token'];
    $date = $_GET['date'];
    $tegangan = $_GET['tegangan'];
    $arus = $_GET['arus'];
    $daya = $_GET['daya'];
    $statusalat = $_GET['status'];
    $relay = $_GET['relay'];
    $persen = $_GET['persen'];

    $com_cektoken = "SELECT * FROM erwinproject WHERE token = '$token'";
    $cektoken = mysqli_query($link, $com_cektoken);

    if (mysqli_num_rows($cektoken) > 0){
        $com_record = "INSERT INTO record_panel(token,date,tegangan,arus,daya,statusalat,statusrelay,persenaki) VALUES('$token','$date','$tegangan','$arus','$daya','$statusalat','$relay','$persen')";
        $com_update = "UPDATE update_panel SET date = '$date', tegangan = '$tegangan', arus = '$arus', daya = '$daya', statusalat = '$statusalat', statusrelay = '$relay', persenaki = '$persen' WHERE token = '$token'";

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
   };
   
   

} else {
    $response["success"] = 0;
    $response["message"] = "Parameter Salah";

    echo json_encode($response);
}

?>