$(document.body).on("click", "#TrainerCreateButton", function () {
    var url = "/Course/GetTrainerCreatePV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#CourseCreateButton", function () {
    var url = "/Course/GetCourseCreatePv";
    getTrainerCreatePv(url);
});


$(document.body).on("click", "#AddCourseTrainer", function () {
    var url = "/Course/GetAddCourseTrainerPV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#CourseExamButton", function () {
    var url = "/Course/GetAddCourseExamPV";
    getTrainerCreatePv(url);
});

function getTrainerCreatePv(url) {
    
    $.post(url, function (rData) {
        if (rData != undefined && rData != "") {
            $("#PartialTrainerLoadDiv").html(rData);
        }
    });

}



function getTrainerCreateSuccess(e) {
    //alert("Your Custom Message");

    //this for server response Message
    alert(e);
    
}

function CourseCreateFailed(e) {
    alert(e);
}
