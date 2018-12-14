$(document.body).on("click", "#TrainerCreateButton", function () {
    var url = "/Course/GetTrainerCreatePV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#CourseCreateButton", function () {
    var url = "/Course/GetCourseCreatePv";
    getTrainerCreatePv(url);
});

function getTrainerCreatePv(url) {
    
    $.post(url, function (rData) {
        if (rData != undefined && rData != "") {
            $("#PartialTrainerLoadDiv").html(rData);
        }
    });

}
