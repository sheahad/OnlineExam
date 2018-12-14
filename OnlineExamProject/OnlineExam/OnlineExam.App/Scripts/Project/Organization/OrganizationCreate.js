$(document).ready(function () {
    var url = "../../Organization/GetAutoCode";
    $.post(url, function (rData) {
        if (rData != undefined && rData != null && rData != "") {
            $("#Code").val(rData);
        }
    });


});


$("#btnsubmit").click(function () {
    alert("Do you want to save..!")
});


