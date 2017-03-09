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
    $numbers = intval($_GET['num']);
    $oddNumbers;
    for ($i = $numbers; $i >= 1; $i--) {
        if ($i % 2 == 1) {
            $oddNumbers[] = $i;
        }
    }

    echo join(' ', $oddNumbers);
}
?>

</body>
</html>