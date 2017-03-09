<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])) {
    $num = intval($_GET['num']);
    $fibonacciSeq;
    $fibonacciSeq[] = 1;
    $fibonacciSeq[] = 1;
    $first = 1;
    $second = 1;
    for ($i=0; $i<$num-2; $i++){
        $third = $first + $second;
        $fibonacciSeq[] = $third;
        $first = $second;
        $second = $third;
    }
    echo join(' ',$fibonacciSeq);
}
?>
</body>
</html>