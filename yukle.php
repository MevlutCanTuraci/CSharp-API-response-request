<?php

if (isset($_GET) && !empty($_GET)) {

    extract($_GET);

    $jsonData = array(
        "name" => $name,
        "age" => $age,
        "status" => "GET"
    );

    echo json_encode($jsonData);
}

if (isset($_POST) && !empty($_POST)) {
    
    extract($_POST);

    $jsonData = array(
        "name" => $name,
        "age" => $age,
        "status" => "POST"
    );

    echo json_encode($jsonData);    

}