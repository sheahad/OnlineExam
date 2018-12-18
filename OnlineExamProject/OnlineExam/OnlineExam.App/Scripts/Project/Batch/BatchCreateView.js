
$(document.body).on("click", "#CourseExamButton", function () {
    var url = "/Batch/GetCourseCreatePv";
    getTrainerCreatePv(url);
});


$(document.body).on("click", "#TrainerCreateButton", function () {
    var url = "/Batch/GetAddCourseTrainerPV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#BatchCreateButton", function () {
    var url = "/Batch/GetAddBatchExamPV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#ParticipentCreateButton", function () {
    var url = "/Batch/GetParticipentLoadPV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#AddParticipents", function () {
    var url = "/Batch/GetAddParticipentCreatePV";
    getTrainerCreatePv(url);
});

$(document.body).on("click", "#TrainerCreateButton", function () {
    var url = "/Batch/GetAddAddCourseTrainerPV";
    getTrainerCreatePv(url);
});


$(document.body).on("click", "#AddCourseTrainer", function () {
    var url = "/Batch/GetAssginCourseTrainerPV";
    getTrainerCreatePv(url);
});



function getTrainerCreatePv(url) {
    
    $.post(url, function (rData) {
        if (rData != undefined && rData != "") {
            $("#PartialBatchLoadDiv").html(rData);
        }
    });

}



function getBatchUpdateSuccess(e) {
    //alert("Your Custom Message");

    //this for server response Message
    alert("Batch Update Successfully ");
   
}

function CourseCreateFailed(e) {
    alert(e);
}
