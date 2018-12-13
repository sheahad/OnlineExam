

$(document).ready(function () {
    var url = "../../Participants/GetAutoCode";
    $.post(url, function (rData) {
        if (rData != undefined && rData != null && rData != "") {
            $("#RegNo").val(rData);
        }
    });


});




$("#btnsubmit").click(function () {
    alert("Do you want to save..!")
});
