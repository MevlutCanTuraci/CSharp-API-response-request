<?php

extract($_GET);

$jsonData = array(
    "name" => $name,
    "age" => $age
);

echo json_encode($jsonData);