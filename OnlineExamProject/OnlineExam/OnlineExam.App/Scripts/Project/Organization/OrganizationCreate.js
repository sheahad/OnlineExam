$("#Name").change(function () {
    var name = $(this).val();

    var url = "../../Organization/IsNameExist";
    var params = { name: name };
    $.post(url, params, function (rData) {
        if (rData === true) {
            alert("Name Already Exist");
            validate = false;
            return false;
        }
        validate = true;
    });
});